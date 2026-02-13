namespace dxReports.Reports.TEST
{
    partial class scripts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scripts));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.powerBIDataSet1 = new dxReports.PowerBIDataSet();
            this.userTaskTableAdapter = new dxReports.PowerBIDataSetTableAdapters.UserTaskTableAdapter();
            this.xpInstantFeedbackView1 = new DevExpress.Xpo.XPInstantFeedbackView(this.components);
            this.xpInstantFeedbackSource1 = new DevExpress.Xpo.XPInstantFeedbackSource(this.components);
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.xpPageSelector1 = new DevExpress.Xpo.XPPageSelector(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.powerBIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Name = "Detail";
            this.Detail.Scripts.OnBeforePrint = "Detail_BeforePrint";
            // 
            // powerBIDataSet1
            // 
            this.powerBIDataSet1.DataSetName = "PowerBIDataSet";
            this.powerBIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTaskTableAdapter
            // 
            this.userTaskTableAdapter.ClearBeforeFill = true;
            // 
            // scripts
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.powerBIDataSet1,
            this.xpInstantFeedbackView1,
            this.xpInstantFeedbackSource1,
            this.xpCollection1,
            this.xpServerCollectionSource1,
            this.xpPageSelector1});
            this.DataAdapter = this.userTaskTableAdapter;
            this.DataMember = "UserTask";
            this.DataSource = this.powerBIDataSet1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.ScriptsSource = resources.GetString("$this.ScriptsSource");
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.powerBIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private PowerBIDataSet powerBIDataSet1;
        private PowerBIDataSetTableAdapters.UserTaskTableAdapter userTaskTableAdapter;
        private XPInstantFeedbackView xpInstantFeedbackView1;
        private XPInstantFeedbackSource xpInstantFeedbackSource1;
        private XPCollection xpCollection1;
        private XPServerCollectionSource xpServerCollectionSource1;
        private XPPageSelector xpPageSelector1;
    }
}
