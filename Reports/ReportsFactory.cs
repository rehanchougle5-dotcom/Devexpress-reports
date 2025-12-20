using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCounterApi.Reports
{
    public static class ReportsFactory
    {
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>()
        {
            //["ProductReport"] = () => new ProductReport(),
            //["AccountReceivable_Invoice"] = () => new AccountReceivable_Invoice()


        };
    }
}
