using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace dxReports.Reports.Inventory_Transfer
{
    public partial class Inventory_Transfer_2 : DevExpress.XtraReports.UI.XtraReport
    {
        int _groupSrNo = 0;
        bool _isAlternateGroup = false;

        public Inventory_Transfer_2()
        {
            InitializeComponent();
        }

        private void Inventory_Transfer_2_BeforePrint(object sender, CancelEventArgs e)
        {
            ResetGroupSrNo();
            _isAlternateGroup = false;
        }

        public void ResetGroupSrNo()
        {
            _groupSrNo = 0;
        }

        public int GetGroupSrNo()
        {
            _groupSrNo++;
            return _groupSrNo;
        }

        private void xrTableCell4_BeforePrint(object sender, CancelEventArgs e)
        {
            XRTableCell cell = sender as XRTableCell;
            if (cell != null)
                cell.Text = GetGroupSrNo().ToString();
        }

        private void xrTableRow3_BeforePrint(object sender, CancelEventArgs e)
        {
            //XRTableRow row = sender as XRTableRow;
            //if (row == null) return;

            //_isAlternateGroup = !_isAlternateGroup;
            //Color bg = _isAlternateGroup
            //   ? Color.White              
            //    : Color.FromArgb(237, 242, 245);

            //foreach (XRTableCell c in row.Cells)
            //    c.BackColor = bg;
        }

        private void xrTable6_BeforePrint(object sender, CancelEventArgs e)
        {
            XRTable table = sender as XRTable;
            XRTableRow row = table.Rows[0];
            if (row == null) return;

            _isAlternateGroup = !_isAlternateGroup;
            Color bg = _isAlternateGroup
               ? Color.White               
                : Color.FromArgb(237, 242, 245);

            foreach (XRTableCell c in row.Cells)
                c.BackColor = bg;
        }
    }
}
