using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SmartCounterApi.Reports;

namespace dxReports
{
    public partial class frmdxReport : Form
    {
        public frmdxReport()
        {
            InitializeComponent();

            txtEmpID.Text = "BSG001PS230000057";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //PrintReport report = new PrintReport();
            //report.Parameters["DocNo"].Value = "BSG001PS230000156";
            //report.ExportToPdf("F:\\Reports\\Smart Counter\\ABC.PDF");



            //AccountReceivable_Invoice rpt = new AccountReceivable_Invoice();
            //rpt.Parameters["DocNo"].Value = txtEmpID.Text;
            ////hrPaySlip rpt = new hrPaySlip();
            ////hrPaySlip rpt = new hrPaySlip();


            ////rpt.Parameters["EmpID"].Value = txtEmpID.Text;
            ////rpt.Parameters["MonthID"].Value = txtMonthID.Text;

            ////string filename = txtEmpID.Text + "_" + txtMonthID.Text + "_" + DateTime.Now.Year.ToString("00") + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") + DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00") + DateTime.Now.Millisecond.ToString("00");
            ////filename = string.Format("D:\\{0}.pdf", filename);
            //rpt.Print();
            //rpt.ExportToPdf("F:\\Reports\\Smart Counter\\ABC.PDF");

            ////System.Diagnostics.Process.Start(filename);
        }
    }
}
