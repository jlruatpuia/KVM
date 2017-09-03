using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KVM.Forms;
using DevExpress.Utils.Menu;

namespace KVM.Controls
{
    public partial class ucProducts : XtraUserControl
    {
        wrProducts.ServerToClient sc = new wrProducts.ServerToClient();
        wrProducts.Products P = new wrProducts.Products();

        public ucProducts()
        {
            InitializeComponent();
            InitializeMenuItems();
            LoadData();
        }

        void LoadData()
        {
            sc = new wrProducts.ServerToClient();
            P = new wrProducts.Products();

            sc = P._GetCategories();
            repCAT.DataSource = sc.DT;
            repCAT.DisplayMember = "CategoryName";
            repCAT.ValueMember = "ID";

            sc = P._GetProducts();
            grd.DataSource = sc.DT;
        }

        DXMenuItem[] menuItems;
        void InitializeMenuItems()
        {
            DXMenuItem itemNew = new DXMenuItem("New", ItemNew_Click, imgCol.Images[0]);
            DXMenuItem itemEdit = new DXMenuItem("Edit", ItemEdit_Click, imgCol.Images[1]);
            DXMenuItem itemDelete = new DXMenuItem("Delete", ItemDelete_Click, imgCol.Images[2]);
            DXMenuItem itemPrint = new DXMenuItem("Detail Report", ItemPrint_Click, imgCol.Images[3]);
            itemPrint.BeginGroup = true;
            menuItems = new DXMenuItem[] { itemNew, itemEdit, itemDelete, itemPrint };
        }

        private void bNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProduct frm = new frmProduct();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                sc = new wrProducts.ServerToClient();
                P = new wrProducts.Products();
                wrProducts.Product p = new wrProducts.Product();

                p.Category = frm.Category;
                p.SubCategory = frm.SubCategory;
                p.Company = frm.Company;
                p.ProductName = frm.PrdName;
                p.PackageSize = frm.PackageSize;
                p.BuyingValue = frm.BuyingValue;
                p.SellingValue = frm.SellingValue;
                p.MfgDate = frm.MfgDate;
                p.ExpDate = frm.ExpDate;
                p.Quantity = frm.Quantity;
                p.BarCode = frm.BarCode;
                p.SupplierID = frm.SupplierID;
                p.HSN = frm.HSN;
                p.TaxRate = frm.TaxRate;

                sc = P._InsertProduct(p);
                if (sc.Message == null)
                {
                    XtraMessageBox.Show("New Product added!");
                    LoadData();
                }
                else
                    XtraMessageBox.Show(sc.Message);
            }
        }

        private void bEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(grv.RowCount <= 0)
            {
                XtraMessageBox.Show("No product to edit!");
                return;
            }
            int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colPID));
            int f = grv.FocusedRowHandle;

            sc = new wrProducts.ServerToClient();
            P = new wrProducts.Products();
            wrProducts.Product p = new wrProducts.Product();

            p = P._GetProductDetailByID(id);

            frmProduct frm = new frmProduct(p);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                p = new wrProducts.Product();
                p.ID = id;
                p.Category = frm.Category;
                p.SubCategory = frm.SubCategory;
                p.Company = frm.Company;
                p.ProductName = frm.PrdName;
                p.PackageSize = frm.PackageSize;
                p.BuyingValue = frm.BuyingValue;
                p.SellingValue = frm.SellingValue;
                p.MfgDate = frm.MfgDate;
                p.ExpDate = frm.ExpDate;
                p.Quantity = frm.Quantity;
                p.BarCode = frm.BarCode;
                p.SupplierID = frm.SupplierID;
                p.HSN = frm.HSN;
                p.TaxRate = frm.TaxRate;

                sc = P._UpdateProduct(p);
                if (sc.Message == null)
                {
                    XtraMessageBox.Show("Product detail updated!");
                    LoadData();
                    grv.SelectRow(f);
                }
                else
                    XtraMessageBox.Show(sc.Message);
            }
        }

        private void bDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grv.RowCount <= 0) return;
            int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colPID));
            //int f = grv.FocusedRowHandle;

            sc = new wrProducts.ServerToClient();
            P = new wrProducts.Products();

            if(XtraMessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sc = P._DeleteProduct(id);

                if (sc.Message == null)
                {
                    XtraMessageBox.Show("Product deleted successfully!");
                    LoadData();
                    //grv.SelectRow(f);
                }
                else
                    XtraMessageBox.Show(sc.Message);
            }
        }

        private void grv_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow && e.HitInfo.InGroupRow == false)
            {
                grv.FocusedRowHandle = e.HitInfo.RowHandle;
                foreach (DXMenuItem item in menuItems)
                    e.Menu.Items.Add(item);
            }
        }

        private void ItemNew_Click(object sender, EventArgs e)
        {
            bNew_ItemClick(null, null);
        }

        private void ItemEdit_Click(object sender, EventArgs e)
        {
            bEdit_ItemClick(null, null);
        }

        private void ItemDelete_Click(object sender, EventArgs e)
        {
            bDel_ItemClick(null, null);
        }

        private void ItemPrint_Click(object sender, EventArgs e)
        {

        }

        private void grv_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                //string category = grv.GetRowCellDisplayText(e.RowHandle, grv.Columns["ExpDate"]);
                
                //if (category == "Beverages")
                //{
                //    e.Appearance.BackColor = Color.Salmon;
                //    e.Appearance.BackColor2 = Color.SeaShell;
                //}
            }
        }
    }
}
