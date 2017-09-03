using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KVM.Codes;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Filtering;
using DevExpress.XtraGrid.Columns;
using IMS2.Reports;
using DevExpress.XtraReports.UI;

namespace KVM.Forms
{
    public partial class frmQuickSell : XtraForm
    {
        wrSettings.MySettings g = new wrSettings.MySettings();
        wrProducts.Products p = new wrProducts.Products();
        wrTransact.Sale s = new wrTransact.Sale();
        
        public frmQuickSell()
        {
            InitializeComponent();
            Init();
            InitDataTable();
            grv.IndicatorWidth = 30;
        }

        void Init()
        {
            txtBCD.Focus();
            dtpSDT.DateTime = DateTime.Now;
            txtINV.Text = g.GetSalesInvoice(DateTime.Now, "KVM");

            wrProducts.ServerToClient sc = new wrProducts.ServerToClient();
            sc = p._GetCategories();
            repCAT.DataSource = sc.DT;
            repCAT.DisplayMember = "CategoryName";
            repCAT.ValueMember = "ID";

            sc = p._GetAvailableProducts();
            luePRD.Properties.DataSource = sc.DT;
            luePRD.Properties.DisplayMember = "ProductName";
            luePRD.Properties.ValueMember = "ID";
        }

        DataTable dt = new DataTable();

        void InitDataTable()
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("HSN", typeof(string));
            dt.Columns.Add("BarCode", typeof(string));
            dt.Columns.Add("SellingValue", typeof(double));
            dt.Columns.Add("BuyingValue", typeof(double));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Amount", typeof(double));
        }

        private void txtBCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //lbM.Text = "";
                string bcd = txtBCD.Text.ToUpper();
                p = new wrProducts.Products();
                wrProducts.ServerToClient sc = new wrProducts.ServerToClient();

                int i = p._GetProductCountByBarCode(bcd);
                if(i <= 0)
                {
                    lbMSG.Text = "Product not available!";

                }
                else if(i == 1)
                {
                    wrProducts.Product prd = new wrProducts.Product();
                    prd = p._GetProductDetailByBarCode(bcd);
                    dt.Rows.Add(prd.ID, prd.ProductName, prd.HSN, prd.BarCode, prd.SellingValue, prd.BuyingValue, 1, prd.SellingValue);
                    grd.DataSource = dt;
                    grd.Refresh();

                    double tot = Convert.ToDouble(colAMT.SummaryText);
                    dgTTL.Text = tot.ToString();
                }
                else
                {
                    frmQuickSelectProduct frm = new frmQuickSelectProduct(bcd);
                    if(frm.ShowDialog() == DialogResult.OK)
                    {
                        wrProducts.Product prd = new wrProducts.Product();
                        prd = p._GetProductDetailByID(frm.ProductID);
                        dt.Rows.Add(prd.ID, prd.ProductName, prd.HSN, prd.BarCode, prd.SellingValue, prd.BuyingValue, 1, prd.SellingValue);
                        grd.DataSource = dt;
                        grd.Refresh();

                        double tot = Convert.ToDouble(colAMT.SummaryText);
                        dgTTL.Text = tot.ToString();
                    }
                }

                txtBCD.Text = "";
                txtBCD.Focus();
            }
        }

        private void sluePRD_ColumnFilterChanged(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            FunctionOperator functionOperator = gridView.DataController.FilterCriteria as FunctionOperator;
            if (!ReferenceEquals(functionOperator, null))
            {
                GroupOperator groupOperator = new GroupOperator();
                groupOperator.OperatorType = GroupOperatorType.Or;

                foreach (GridColumn col in gridView.VisibleColumns)
                {
                    FunctionOperator fOperator = new FunctionOperator();
                    fOperator.OperatorType = FunctionOperatorType.StartsWith;
                    fOperator.Operands.Add(new OperandProperty(col.FieldName));
                    fOperator.Operands.Add(new ConstantValue(((ConstantValue)functionOperator.Operands[1]).Value));
                    groupOperator.Operands.Add(fOperator);
                }

                gridView.DataController.FilterCriteria = groupOperator;
            }
        }

        private void grv_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            wrProducts.Product prd = new wrProducts.Product();
            p = new wrProducts.Products();

            int id = Convert.ToInt32(luePRD.EditValue);

            prd = p._GetProductDetailByID(id);
            dt.Rows.Add(prd.ID, prd.ProductName, prd.HSN, prd.BarCode, prd.SellingValue, prd.BuyingValue, 1, prd.SellingValue);
            grd.DataSource = dt;
            grd.Refresh();

            double tot = Convert.ToDouble(colAMT.SummaryText);
            dgTTL.Text = tot.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            wrTransact.ServerToClient tt = new wrTransact.ServerToClient();
            wrTransact.Transact tx = new wrTransact.Transact();
            s = new wrTransact.Sale();
            wrTransact.SaleDetail sd = new wrTransact.SaleDetail();

            wrPeoples.Peoples pp = new wrPeoples.Peoples();
            wrPeoples.Customer c = new wrPeoples.Customer();
            //wrPeoples.CustomerAccount ca = new wrPeoples.CustomerAccount();

            //wrTransact.Sale s = new wrTransact.Sale();

            c = pp.DefaultCustomer();

            s.InvoiceNo = g.GetSalesInvoice(DateTime.Now, "KVM");
            s.SellDate = dtpSDT.DateTime;
            s.CustomerID = c.ID;
            s.Amount = Convert.ToDouble(dgTTL.Text);
            s.Discount = Convert.ToDouble(txtDSC.Text);
            s.Payment = s.Amount - s.Discount;
            s.Balance = 0;
            tt = tx._AddSale(s);

            //ca.CustomerID = c.ID;
            //ca.TransDate = s.SellDate;
            //ca.Description = s.InvoiceNo;

            //if(s.Balance == 0)
            //{
            //    ca.Debit = s.Payment;
            //    ca.Credit = s.Payment;
            //}
            //else
            //{
            //    ca.Debit = s.Payment;
            //    ca.Credit = s.Payment;
            //}

            //ca.Balance = s.Balance;

            //tt = tx._addtr

            if (tt.Message == null)
            {
                for (int i = 0; i <= grv.RowCount - 1; i++)
                {
                    sd.InvoiceNo = s.InvoiceNo;
                    sd.ProductID = Convert.ToInt32(grv.GetRowCellValue(i, colPID));
                    sd.BuyingValue = Convert.ToDouble(grv.GetRowCellValue(i, colBVL));
                    sd.SellingValue = Convert.ToDouble(grv.GetRowCellValue(i, colSVL));
                    sd.Quantity = Convert.ToInt32(grv.GetRowCellValue(i, colQTY));
                    sd.Amount = Convert.ToDouble(grv.GetRowCellValue(i, colAMT));
                    //pdid = Convert.ToInt32(grv.GetRowCellValue(i, colPDID));
                    tt = tx._AddSaleDetails(sd);
                    if (tt.Message != null)
                    {
                        XtraMessageBox.Show(tt.Message);
                        break;
                    }
                    else
                    {
                        //int pdid = sc.Count;
                        wrProducts.ServerToClient sc = new wrProducts.ServerToClient();
                        wrProducts.Products pd = new wrProducts.Products();
                        sc = pd._UpdateProductQuantity(sd.Quantity, "-", sd.ProductID);
                    }
                }
                if (XtraMessageBox.Show("Product(s) sold. Print Receipt?", "Print", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    rptQuickSale rpt = new rptQuickSale();
                    tx = new wrTransact.Transact();
                    tt = tx._QuickSaleReport(s.InvoiceNo);
                    rpt.DataSource = tt.DT;
                    XRSummary qty = new XRSummary();
                    qty.Running = SummaryRunning.Report;

                    rpt.lbINV.Text = s.InvoiceNo;

                    rpt.lbSDT.Text = s.SellDate.ToShortDateString() + ", " + s.SellDate.ToShortTimeString();
                    rpt.lbQTY.DataBindings.Add("Text", null, "Quantity");
                    rpt.lbITM.DataBindings.Add("Text", null, "productname");
                    rpt.lbPRC.DataBindings.Add("Text", null, "Amount", "{0:C2}");
                    //rpt.lbTQT.Text = sc.Count.ToString();
                    rpt.lbTQT.DataBindings.Add("Text", null, "Quantity");

                    rpt.lbSTT.Text = s.Amount.ToString("C", Cultures.India);
                    if (s.Discount > 0)
                        rpt.lbDSC.Text = s.Discount.ToString("C", Cultures.India);
                    else
                    {
                        rpt.xrTableCell1.Visible = false;
                        rpt.lbDSC.Visible = false;
                    }
                    rpt.lbTTL.Text = (s.Amount - s.Discount).ToString("C", Cultures.India);
                    rpt.lbTQT.Summary = qty;
                    //rpt.PrinterName = Properties.Settings.Default.ReceiptPrinter;
                    rpt.ShowPrintMarginsWarning = false;
                    ReportPrintTool rp = new ReportPrintTool(rpt);
                    rp.Print();
                    //rpt.PrintDialog();
                }
            }
            else
            {
                XtraMessageBox.Show(tt.Message);
                return;
            }

            //Reset();
        }

        private void grv_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            double svl = Convert.ToDouble(grv.GetFocusedRowCellValue(colSVL));
            int qty = Convert.ToInt32(grv.GetFocusedRowCellValue(colQTY));
            double amt = qty * svl;
            grv.SetFocusedRowCellValue(colAMT, amt);

            grv.UpdateSummary();

            double TotalAmount = Convert.ToDouble(colAMT.SummaryText);
            //txtTAM.Text = TotalAmount.ToString();
            dgTTL.Text = TotalAmount.ToString();
        }
    }
}