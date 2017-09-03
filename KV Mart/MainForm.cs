using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KVM.Controls;
using DevExpress.XtraEditors;

namespace KVM
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitConsolidatedSales();
        }

        void InitConsolidatedSales()
        {
            dtpConSalesFr.DateTime = DateTime.Now;
            dtpConSalesTo.DateTime = DateTime.Now;
            rdoConSalesHSN.SelectedIndex = 0;
        }
        private void LoadControl(XtraUserControl ctrl)
        {
            ctrl.Dock = DockStyle.Fill;
            pnl.Controls.Clear();
            pnl.Controls.Add(ctrl);
            //bClose.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            //MainRibbon.MergeRibbon(ctrl.ribbonControl);
            //MainRibbon.SelectedPage = MainRibbon.MergedRibbon.SelectedPage;
        }

        private void bQSell_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Forms.frmQuickSell().Show();
        }

        private void bSell_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bPurchase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Forms.frmPurchase().ShowDialog();
        }

        private void bCat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bPrd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucProducts uc = new ucProducts();
            LoadControl(uc);
            MainRibbon.MergeRibbon(uc.rcProducts);
            MainRibbon.SelectedPage = MainRibbon.MergedRibbon.SelectedPage;
        }

        private void bSup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bCus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucCustomers uc = new ucCustomers();
            LoadControl(uc);
            MainRibbon.MergeRibbon(uc.rcCustomer);
            MainRibbon.SelectedPage = MainRibbon.MergedRibbon.SelectedPage;
        }
    }
}
