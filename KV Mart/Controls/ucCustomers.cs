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
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;

namespace KVM.Controls
{
    public partial class ucCustomers : XtraUserControl
    {
        wrPeoples.ServerToClient sc = new wrPeoples.ServerToClient();
        wrPeoples.Peoples p = new wrPeoples.Peoples();
        wrPeoples.Customer c = new wrPeoples.Customer();
        public ucCustomers()
        {
            InitializeComponent();
            InitializeMenuItems();
            //new DevExpress.XtraGrid.Design.XViewsPrinting(grdCus);
            LoadCustomers();
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

        void LoadCustomers()
        {
            sc = new wrPeoples.ServerToClient();
            p = new wrPeoples.Peoples();
            sc = p._GetCustomers();
            grdCus.DataSource = sc.DT;
            
        }

        void LoadCustomerAccount(int ID)
        {
            sc = new wrPeoples.ServerToClient();
            p = new wrPeoples.Peoples();
            sc = p._GetCustomerAccountByID(ID);

            grdCdt.DataSource = sc.DT;
        }

        private void grvCus_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (grvCus.RowCount <= 0) return;
            int id = Convert.ToInt32(grvCus.GetFocusedRowCellValue(colCID));

            LoadCustomerAccount(id);
        }

        private void bNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.frmCustomer frm = new Forms.frmCustomer();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                c = new wrPeoples.Customer();
                c.CustomerName = frm._cnm;
                c.Address = frm._adr;
                c.Phone = frm._phn;

                sc = new wrPeoples.ServerToClient();
                p = new wrPeoples.Peoples();

                sc = p._AddCustomer(c);

                if (sc.Message == null)
                {
                    XtraMessageBox.Show("New customer added successfully!");
                    LoadCustomers();
                }
                else
                    XtraMessageBox.Show(sc.Message);
            }
        }

        private void bEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grvCus.RowCount <= 0) return;

            int id = Convert.ToInt32(grvCus.GetFocusedRowCellValue(colCID));

            sc = new wrPeoples.ServerToClient();
            p = new wrPeoples.Peoples();
            c = new wrPeoples.Customer();

            c = p._GetCustomer(id);

            Forms.frmCustomer frm = new Forms.frmCustomer(c);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                c = new wrPeoples.Customer();
                c.ID = id;
                c.CustomerName = frm._cnm;
                c.Address = frm._adr;
                c.Phone = frm._phn;

                sc = p._UpdateCustomer(c);
                if (sc.Message == null)
                {
                    XtraMessageBox.Show("Customer details updated successfully!");
                    LoadCustomers();
                }
                else
                    XtraMessageBox.Show(sc.Message);
            }

        }
        private void bDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grvCus.RowCount <= 0) return;
            int id = Convert.ToInt32(grvCus.GetFocusedRowCellValue(colCID));

            sc = new wrPeoples.ServerToClient();
            p = new wrPeoples.Peoples();

            if(XtraMessageBox.Show("Do you really want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sc = p._DeleteCustomer(id);
                if(sc.Message == null)
                {
                    XtraMessageBox.Show("Customer deleted successfully!");
                    LoadCustomers();
                }
                else
                {
                    XtraMessageBox.Show(sc.Message);
                }
            }
        }

        private void grvCus_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                grvCus.FocusedRowHandle = e.HitInfo.RowHandle;
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
            //grvCus.ShowEditor();
        }

        private void ItemDelete_Click(object sender, EventArgs e)
        {
            bDelete_ItemClick(null, null);
        }

        private void ItemPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
