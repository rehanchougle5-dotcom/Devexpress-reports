using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace dxReports.Reports
{
    public partial class Stock_Count_Sub_Report_CrossTab : DevExpress.XtraReports.UI.XtraReport
    {
        public Stock_Count_Sub_Report_CrossTab()
        {
            InitializeComponent();
        }

        private void xrCrossTab1_BeforePrint(object sender, CancelEventArgs e)
        {
            this.crossTabDataCell4.Index = this.xrCrossTab1.ColumnDefinitions.Count -1 ; // Set to the last position

        }
    }
}
