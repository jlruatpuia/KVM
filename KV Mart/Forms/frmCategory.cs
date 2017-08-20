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
    public partial class frmCategory : DevExpress.XtraEditors.XtraForm
    {
        public int cid { get; set; }
        public string cnm { get; set; }
        public frmCategory()
        {
            InitializeComponent();
        }
    }
}