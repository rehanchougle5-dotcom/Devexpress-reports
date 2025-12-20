using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace dxReports.Reports.AP_Invoice
{
    public partial class AR_Invoice_Barcode : DevExpress.XtraReports.UI.XtraReport
    {
        public AR_Invoice_Barcode()
        {
            InitializeComponent();
        }

        private void xrBarCode4_BeforePrint(object sender, CancelEventArgs e)
        {

        }
    }
}
