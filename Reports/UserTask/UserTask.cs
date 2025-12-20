using DevExpress.CodeParser;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace dxReports.Reports.UserTask
{
    public partial class UserTask : DevExpress.XtraReports.UI.XtraReport
    {
        public UserTask()
        {
            InitializeComponent();
        }

        private void xrChart1_CustomDrawSeriesPoint(object sender, DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs e)
        {
            string code = e.SeriesPoint.Argument.ToString().Trim().ToUpper();

            switch (code)
            {
                case "Assigned":  // Assigned
                    e.SeriesPoint.Color = Color.Blue;
                    break;
                case "Completed":  // Completed
                    e.SeriesPoint.Color = Color.Green;
                    break;
                case "Confirmed":  // Confirmed
                    e.SeriesPoint.Color = Color.DarkGreen;
                    break;
                case "Hold":  // Hold
                    e.SeriesPoint.Color = Color.Orange;
                    break;
                case "Not Confirmed":  // Not Confirmed
                    e.SeriesPoint.Color = Color.Red;
                    break;
                case "Postponed":  // Postponed
                    e.SeriesPoint.Color = Color.Purple;
                    break;
                case "Pending":  // Pending
                    e.SeriesPoint.Color = Color.Yellow;
                    break;
                case "In-Process":  // In-Process
                    e.SeriesPoint.Color = Color.Cyan;
                    break;
                case "Close":  // Close
                    e.SeriesPoint.Color = Color.Gray;
                    break;
                case "Cancelled":  // Cancelled
                    e.SeriesPoint.Color = Color.Black;
                    break;
                default:
                    e.SeriesPoint.Color = Color.LightGray;
                    break;
            }
        }



    }
}
