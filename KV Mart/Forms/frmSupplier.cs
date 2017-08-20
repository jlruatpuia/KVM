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
    public partial class frmSupplier : DevExpress.XtraEditors.XtraForm
    {
        public int SID { get; set; }
        public string SNM { get; set; }
        public string ADR { get; set; }
        public string PHN { get; set; }
        public string CST { get; set; }
        public string TIN { get; set; }

        Timer tmr = new Timer();
        int counter = 0;

        void Reset()
        {
            txtSNM.Text = "";
            txtADR.Text = "";
            txtPHN.Text = "";
            txtCST.Text = "";
            txtTIN.Text = "";

            txtSNM.Focus();
        }
        public frmSupplier()
        {
            InitializeComponent();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(this.tmr_tick);
        }

        public frmSupplier(int ID)
        {
            InitializeComponent();

            wrPeoples.Peoples x = new wrPeoples.Peoples();
            wrPeoples.Supplier s = new wrPeoples.Supplier();

            s = x._GetSupplier(ID);

            SID = s.ID;
            txtSNM.Text = s.SupplierName;
            txtADR.Text = s.Address;
            txtPHN.Text = s.Phone;
            txtCST.Text = s.CST;
            txtTIN.Text = s.TIN;

            btnSave.Text = "&Update";
       }
        public frmSupplier(string s)
        {
            InitializeComponent();
            btnSave.Text = "&Add";
        }

        private void tmr_tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 2)
            {
                lbMSG.Text = string.Empty;

                tmr.Stop();
                counter = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (!dxvp.Validate()) return;
            wrPeoples.ServerToClient sc = new wrPeoples.ServerToClient();
            wrPeoples.Peoples x = new wrPeoples.Peoples();
            wrPeoples.Supplier s = new wrPeoples.Supplier();

            if (btnSave.Text == "&Save")
            {
                s.SupplierName = txtSNM.Text;
                s.Address = txtADR.Text;
                s.Phone = txtPHN.Text;
                s.CST = txtCST.Text;
                s.TIN = txtTIN.Text;

                sc = x._AddSupplier(s);
                if (sc.Message == null)
                {
                    lbMSG.Text = "New Supplier added!";
                    Reset();
                }
                else
                    lbMSG.Text = sc.Message;
                tmr.Enabled = true;
                tmr.Start();
            }
            else if (btnSave.Text == "&Update")
            {
                s.ID = SID;
                s.SupplierName = txtSNM.Text;
                s.Address = txtADR.Text;
                s.Phone = txtPHN.Text;
                s.CST = txtCST.Text;
                s.TIN = txtTIN.Text;

                sc = x._UpdateSupplier(s);
                if (sc.Message == null)
                {
                    lbMSG.Text = "Supplier Details updated!";
                    Close();
                }
                else
                    lbMSG.Text = sc.Message;
            }
            else
            {
                SNM = txtSNM.Text;
                ADR = txtADR.Text;
                PHN = txtPHN.Text;
                CST = txtCST.Text;
                TIN = txtTIN.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}