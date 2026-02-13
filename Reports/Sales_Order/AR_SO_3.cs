using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DevExpress_Reports.Reports
{
    public partial class AR_SO_3 : DevExpress.XtraReports.UI.XtraReport
    {
        public AR_SO_3()
        {
            InitializeComponent();
        }

        private void AR_SO_3_BeforePrint(object sender, CancelEventArgs e)
        {
            //var page = this.Pages[1];
            //if (Convert.ToBoolean(Parameters["isArabic"].Value))
            //{
            //    page.AssignWatermark(Watermarks["Watermark2"]);
            //}
        }
    }
}
