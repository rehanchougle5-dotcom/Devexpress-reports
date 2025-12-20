namespace dxReports.Reports.IT_Operations
{
    partial class IT_Operations_Main_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IT_Operations_Main_Report));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.dateFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.dateTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.sr_Cover_Page = new DevExpress.XtraReports.UI.XRSubreport();
            this.sr_IT_Operations_Stock = new DevExpress.XtraReports.UI.XRSubreport();
            this.sr_IT_support = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 38.53F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 19.5F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 35.99777F;
            this.Detail.Name = "Detail";
            // 
            // dateFrom
            // 
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Type = typeof(System.DateTime);
            this.dateFrom.ValueInfo = "1753-01-01";
            // 
            // dateTo
            // 
            this.dateTo.Name = "dateTo";
            this.dateTo.Type = typeof(System.DateTime);
            this.dateTo.ValueInfo = "2025-12-31";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "PowerBI";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "RPT_IT_OPERATIONS_MAIN";
            queryParameter1.Name = "@DateFrom";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?dateFrom", typeof(System.DateTime));
            queryParameter2.Name = "@DateTo";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?dateTo", typeof(System.DateTime));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2});
            storedProcQuery1.StoredProcName = "RPT_IT_OPERATIONS_MAIN";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.sr_Cover_Page});
            this.ReportHeader.HeightF = 79.55556F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.sr_IT_support});
            this.GroupHeader1.HeightF = 73F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.sr_IT_Operations_Stock});
            this.GroupHeader2.HeightF = 73F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // sr_Cover_Page
            // 
            this.sr_Cover_Page.GenerateOwnPages = true;
            this.sr_Cover_Page.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.sr_Cover_Page.Name = "sr_Cover_Page";
            this.sr_Cover_Page.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("dateFrom", null, "RPT_IT_OPERATIONS_MAIN.dateFrom"));
            this.sr_Cover_Page.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("dateTo", null, "RPT_IT_OPERATIONS_MAIN.dateTo"));
            this.sr_Cover_Page.ReportSource = new dxReports.Reports.IT_Comprehensive_Report.IT_Comprehensive_Report_Cover();
            this.sr_Cover_Page.SizeF = new System.Drawing.SizeF(781F, 79.55556F);
            // 
            // sr_IT_Operations_Stock
            // 
            this.sr_IT_Operations_Stock.LocationFloat = new DevExpress.Utils.PointFloat(2.119276E-05F, 0F);
            this.sr_IT_Operations_Stock.Name = "sr_IT_Operations_Stock";
            this.sr_IT_Operations_Stock.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("dateFrom", this.dateFrom));
            this.sr_IT_Operations_Stock.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("dateTo", this.dateTo));
            this.sr_IT_Operations_Stock.ReportSource = new dxReports.Reports.IT_Operations.IT_Operations_Stock();
            this.sr_IT_Operations_Stock.SizeF = new System.Drawing.SizeF(781F, 73F);
            // 
            // sr_IT_support
            // 
            this.sr_IT_support.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.sr_IT_support.Name = "sr_IT_support";
            this.sr_IT_support.SizeF = new System.Drawing.SizeF(781.0001F, 73F);
            // 
            // IT_Operations_Main_Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.GroupHeader1,
            this.GroupHeader2});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "RPT_IT_OPERATIONS_MAIN";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(39F, 30F, 38.53F, 19.5F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.dateFrom, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.dateTo, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.dateFrom,
            this.dateTo});
            this.Version = "23.1";
            this.Watermark.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("IT_Operations_Main_Report.Watermark.ImageSource"));
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRSubreport sr_Cover_Page;
        private DevExpress.XtraReports.Parameters.Parameter dateFrom;
        private DevExpress.XtraReports.Parameters.Parameter dateTo;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRSubreport sr_IT_Operations_Stock;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRSubreport sr_IT_support;
    }
}
