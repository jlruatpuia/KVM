﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace KVM.Reports
{
    public partial class rptInvoice : DevExpress.XtraReports.UI.XtraReport
    {
        public rptInvoice()
        {
            InitializeComponent();
        }

        private void rptInvoice_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
