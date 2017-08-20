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

namespace KVM.Forms
{
    public partial class frmQuickSell : DevExpress.XtraEditors.XtraForm
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
            sc = p._GetProducts();
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
    }
}