using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace dxReports.Reports.UserTask
{
    public partial class UserTaskSetup1 : DevExpress.XtraReports.UI.XtraReport
    {
        public UserTaskSetup1()
        {
            InitializeComponent();
        }

        private void BottomMargin_BeforePrint(object sender, CancelEventArgs e)
        {

        }
    }
}
