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
using KVM.wrProducts;

namespace KVM.Forms
{
    public partial class frmProduct : DevExpress.XtraEditors.XtraForm
    {
        public int ID { get; set; }
        public int Category { get; set; }
        public string SubCategory { get; set; }
        public string Company { get; set; }
        public string PrdName { get; set; }
        public string PackageSize { get; set; }
        public double BuyingValue { get; set; }
        public double SellingValue { get; set; }
        public string MfgDate { get; set; }
        public string ExpDate { get; set; }
        public int Quantity { get; set; }
        public string BarCode { get; set; }
        public string HSN { get; set; }
        public double TaxRate { get; set; }
        public int SupplierID { get; set; }
        public int Count { get; set; }
        public frmProduct()
        {
            InitializeComponent();

            LoadCategory();
            LoadSubCategory();
            LoadCompany();
        }

        void LoadCategory()
        {
            Products pd = new Products();
            ServerToClient sc = new ServerToClient();

            sc = pd._GetCategories();
            lueCAT.Properties.DataSource = sc.DT;
            lueCAT.Properties.DisplayMember = "CategoryName";
            lueCAT.Properties.ValueMember = "ID";
        }

        void LoadSubCategory()
        {
            Products pd = new Products();
            ServerToClient sc = new ServerToClient();

            sc = pd._GetSubCategories();
            for(int i = 0; i <= sc.DT.Rows.Count - 1; i++)
            {
                cboSCT.Properties.Items.Add(sc.DT.Rows[i].ItemArray[0].ToString());
            }
        }

        void LoadCompany()
        {
            Products pd = new Products();
            ServerToClient sc = new ServerToClient();

            sc = pd._GetCompanies();
            for(int i = 0; i <= sc.DT.Rows.Count - 1; i++)
            {
                cboCMP.Properties.Items.Add(sc.DT.Rows[i].ItemArray[0].ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Category = Convert.ToInt32(lueCAT.EditValue);
            SubCategory = cboSCT.Text;
            Company = cboCMP.Text;
            PrdName = txtPNM.Text;
            PackageSize = txtPKG.Text;
            BuyingValue = Convert.ToDouble(txtBVL.Text);
            SellingValue = Convert.ToDouble(txtSVL.Text);
            MfgDate = txtMFG.Text;
            ExpDate = txtEXP.Text;
            Quantity = 0;
            BarCode = null;
            SupplierID = 0;
            HSN = txtHSN.Text;
            TaxRate = Convert.ToDouble(txtTAX.Text);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}