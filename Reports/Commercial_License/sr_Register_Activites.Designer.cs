
namespace dxReports.Reports.Commercial_License
{
    partial class sr_Register_Activites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sr_Register_Activites));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrPictureBox5 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTable10 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sr_licenseId = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 26.02F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(18.24373F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(785.7563F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Register details will be shown here...";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox5,
            this.xrTable10});
            this.GroupHeader1.HeightF = 37.80264F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrPictureBox5
            // 
            this.xrPictureBox5.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox5.ImageSource"));
            this.xrPictureBox5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 13.81944F);
            this.xrPictureBox5.Name = "xrPictureBox5";
            this.xrPictureBox5.SizeF = new System.Drawing.SizeF(18.24373F, 17.19383F);
            this.xrPictureBox5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // xrTable10
            // 
            this.xrTable10.LocationFloat = new DevExpress.Utils.PointFloat(18.24373F, 10F);
            this.xrTable10.Name = "xrTable10";
            this.xrTable10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow25});
            this.xrTable10.SizeF = new System.Drawing.SizeF(259.5497F, 21.01328F);
            // 
            // xrTableRow25
            // 
            this.xrTableRow25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.xrTableRow25.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableRow25.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell71});
            this.xrTableRow25.Name = "xrTableRow25";
            this.xrTableRow25.StylePriority.UseBackColor = false;
            this.xrTableRow25.StylePriority.UseBorderColor = false;
            this.xrTableRow25.StylePriority.UseBorders = false;
            this.xrTableRow25.Weight = 1D;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell71.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell71.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'Register Details\'")});
            this.xrTableCell71.Font = new DevExpress.Drawing.DXFont("neoTech", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell71.ForeColor = System.Drawing.Color.Maroon;
            this.xrTableCell71.Multiline = true;
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.StylePriority.UseBackColor = false;
            this.xrTableCell71.StylePriority.UseBorders = false;
            this.xrTableCell71.StylePriority.UseFont = false;
            this.xrTableCell71.StylePriority.UseForeColor = false;
            this.xrTableCell71.StylePriority.UseTextAlignment = false;
            this.xrTableCell71.Text = "xrTableCell215";
            this.xrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrTableCell71.Weight = 1.647345559315291D;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SMART VIEW DBMS SERVER";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // sr_licenseId
            // 
            this.sr_licenseId.Description = "Sub Report License Id";
            this.sr_licenseId.Name = "sr_licenseId";
            this.sr_licenseId.Type = typeof(int);
            this.sr_licenseId.ValueInfo = "0";
            // 
            // sr_Register_Activites
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.GroupHeader1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Query";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(35F, 11F, 26.02F, 0F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.sr_licenseId});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.Parameters.Parameter sr_licenseId;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTable xrTable10;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow25;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell71;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox5;
    }
}
