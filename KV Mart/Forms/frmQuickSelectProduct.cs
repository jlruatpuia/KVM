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
    public partial class frmQuickSelectProduct : XtraForm
    {
        public int ProductID { get; set; }

        wrProducts.Products p = new wrProducts.Products();
        wrProducts.ServerToClient sc = new wrProducts.ServerToClient();
        public frmQuickSelectProduct(string BarCode)
        {
            InitializeComponent();
            sc = p._GetProductDataByBarCode(BarCode);
            grd.DataSource = sc.DT;
        }

        private void grv_DoubleClick(object sender, EventArgs e)
        {
            ProductID = Convert.ToInt32(grv.GetFocusedRowCellValue(colPID));
            DialogResult = DialogResult.OK;
        }

        private void grv_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ProductID = Convert.ToInt32(grv.GetFocusedRowCellValue(colPID));
                DialogResult = DialogResult.OK;
            }
        }
    }
}