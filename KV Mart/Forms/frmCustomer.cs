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

namespace KVM.Forms
{
    public partial class frmCustomer : XtraForm
    {
        public int _id { get; set; }
        public string _cnm { get; set; }
        public string _adr { get; set; }
        public string _phn { get; set; }

        public frmCustomer()
        {
            InitializeComponent();
        }

        public frmCustomer(wrPeoples.Customer c)
        {
            InitializeComponent();
            _id = c.ID;
            txtADR.Text = c.Address;
            txtCNM.Text = c.CustomerName;
            txtPHN.Text = c.Phone;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _cnm = txtCNM.Text;
            _adr = txtADR.Text;
            _phn = txtPHN.Text;

            DialogResult = DialogResult.OK;
        }
    }
}