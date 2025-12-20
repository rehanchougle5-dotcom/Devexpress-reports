using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace dxReports.Reports.StockIssue
{
    public partial class StockIssue : DevExpress.XtraReports.UI.XtraReport
    {
        public StockIssue()
        {
            InitializeComponent();
        }

        private void StockIssue_BeforePrint(object sender, CancelEventArgs e)
        {

        }
    }
}
