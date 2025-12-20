
namespace dxReports.Reports
{
    partial class Stock_Count_Detail_Sub_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Count_Detail_Sub_Report));
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField3 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(14.46303F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField3 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCrossTab2 = new DevExpress.XtraReports.UI.XRCrossTab();
            this.crossTabHeaderCell14 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabDataCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell15 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell16 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell17 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell10 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell18 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell19 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell20 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell11 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell21 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell22 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell23 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell12 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell24 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell25 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabDataCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell13 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell14 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell15 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell26 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabDataCell6 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell16 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell17 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell18 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.sr_StockCountId = new DevExpress.XtraReports.Parameters.Parameter();
            this.costDifference = new DevExpress.XtraReports.UI.CalculatedField();
            this.retailDifference = new DevExpress.XtraReports.UI.CalculatedField();
            this.crossTabGeneralStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabHeaderStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabDataStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabTotalStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 24.82F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 20.02F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrPictureBox1,
            this.xrLabel2,
            this.xrCrossTab2});
            this.Detail.HeightF = 159.3993F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            // 
            // xrLine1
            // 
            this.xrLine1.BackColor = System.Drawing.Color.White;
            this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.xrLine1.LineWidth = 1.5F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(351.2072F, 10.13383F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(452.7929F, 17.15686F);
            this.xrLine1.StylePriority.UseBackColor = false;
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(6.07F, 9.037993F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(18.812F, 18.25269F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            this.xrPictureBox1.StylePriority.UseBorders = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.BorderWidth = 1.2F;
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("neotech", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(102)))), ((int)(((byte)(122)))));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(27.14995F, 0F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(324.0573F, 27.29068F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseBorderWidth = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Retail Audit Summary ( Category Level )";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrCrossTab2
            // 
            this.xrCrossTab2.Cells.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.crossTabHeaderCell14,
            this.crossTabDataCell4,
            this.crossTabHeaderCell15,
            this.crossTabHeaderCell16,
            this.crossTabHeaderCell17,
            this.crossTabTotalCell10,
            this.crossTabHeaderCell18,
            this.crossTabHeaderCell19,
            this.crossTabHeaderCell20,
            this.crossTabTotalCell11,
            this.crossTabHeaderCell21,
            this.crossTabHeaderCell22,
            this.crossTabHeaderCell23,
            this.crossTabTotalCell12,
            this.crossTabHeaderCell24,
            this.crossTabHeaderCell25,
            this.crossTabDataCell5,
            this.crossTabTotalCell13,
            this.crossTabTotalCell14,
            this.crossTabTotalCell15,
            this.crossTabHeaderCell26,
            this.crossTabDataCell6,
            this.crossTabTotalCell16,
            this.crossTabTotalCell17,
            this.crossTabTotalCell18});
            this.xrCrossTab2.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(133.9783F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(133.9783F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(133.9783F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(133.9783F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(133.9783F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(133.9783F)});
            this.xrCrossTab2.DataAreaStyleName = "crossTabDataStyle1";
            crossTabDataField1.FieldName = "qtyDiff";
            crossTabDataField2.FieldName = "costDifference";
            crossTabDataField3.FieldName = "retailDifference";
            this.xrCrossTab2.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
            crossTabDataField1,
            crossTabDataField2,
            crossTabDataField3});
            this.xrCrossTab2.FilterString = "[qtyDiff] <> 0.0m";
            this.xrCrossTab2.GeneralStyleName = "crossTabGeneralStyle1";
            this.xrCrossTab2.HeaderAreaStyleName = "crossTabHeaderStyle1";
            this.xrCrossTab2.LocationFloat = new DevExpress.Utils.PointFloat(0.1302085F, 34.1152F);
            this.xrCrossTab2.Name = "xrCrossTab2";
            crossTabRowDefinition1.Visible = false;
            this.xrCrossTab2.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
            crossTabRowDefinition1,
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(17.99999F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(17.99999F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(24.99999F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(17.99999F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(17.99999F)});
            crossTabRowField1.FieldName = "qtyDiffStatus";
            crossTabRowField2.FieldName = "itemGroupDesc";
            crossTabRowField3.FieldName = "itemCategoryDesc";
            this.xrCrossTab2.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
            crossTabRowField1,
            crossTabRowField2,
            crossTabRowField3});
            this.xrCrossTab2.SizeF = new System.Drawing.SizeF(803.8698F, 111.463F);
            this.xrCrossTab2.TotalAreaStyleName = "crossTabTotalStyle1";
            // 
            // crossTabHeaderCell14
            // 
            this.crossTabHeaderCell14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell14.BorderColor = System.Drawing.Color.Silver;
            this.crossTabHeaderCell14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.crossTabHeaderCell14.BorderWidth = 1F;
            this.crossTabHeaderCell14.ColumnIndex = 0;
            this.crossTabHeaderCell14.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Regular", 6F);
            this.crossTabHeaderCell14.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell14.Name = "crossTabHeaderCell14";
            this.crossTabHeaderCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            this.crossTabHeaderCell14.RowIndex = 0;
            this.crossTabHeaderCell14.RowSpan = 2;
            this.crossTabHeaderCell14.Text = "Difference Type";
            this.crossTabHeaderCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabDataCell4
            // 
            this.crossTabDataCell4.BorderColor = System.Drawing.Color.Silver;
            this.crossTabDataCell4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabDataCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabDataCell4.BorderWidth = 0.6F;
            this.crossTabDataCell4.ColumnIndex = 3;
            this.crossTabDataCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "Iif([qtyDiffStatus] = \'Shortage\', \'#E57070\' , \'Black\' )")});
            this.crossTabDataCell4.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabDataCell4.ForeColor = System.Drawing.Color.Black;
            this.crossTabDataCell4.Name = "crossTabDataCell4";
            this.crossTabDataCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.crossTabDataCell4.RowIndex = 2;
            this.crossTabDataCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabDataCell4.TextFormatString = "{0:#,#0.000;(#,#0.000);0.000}";
            // 
            // crossTabHeaderCell15
            // 
            this.crossTabHeaderCell15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.crossTabHeaderCell15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.crossTabHeaderCell15.BorderWidth = 0.1F;
            this.crossTabHeaderCell15.ColumnIndex = 3;
            this.crossTabHeaderCell15.ColumnSpan = 3;
            this.crossTabHeaderCell15.Font = new DevExpress.Drawing.DXFont("tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabHeaderCell15.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell15.Name = "crossTabHeaderCell15";
            this.crossTabHeaderCell15.RowIndex = 0;
            this.crossTabHeaderCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell16
            // 
            this.crossTabHeaderCell16.BackColor = System.Drawing.Color.Transparent;
            this.crossTabHeaderCell16.BorderColor = System.Drawing.Color.Silver;
            this.crossTabHeaderCell16.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabHeaderCell16.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell16.BorderWidth = 0.6F;
            this.crossTabHeaderCell16.ColumnIndex = 0;
            this.crossTabHeaderCell16.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabHeaderCell16.ForeColor = System.Drawing.Color.Black;
            this.crossTabHeaderCell16.Name = "crossTabHeaderCell16";
            this.crossTabHeaderCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            this.crossTabHeaderCell16.RowIndex = 2;
            this.crossTabHeaderCell16.RowSpan = 2;
            // 
            // crossTabHeaderCell17
            // 
            this.crossTabHeaderCell17.BackColor = System.Drawing.Color.Transparent;
            this.crossTabHeaderCell17.BorderColor = System.Drawing.Color.Silver;
            this.crossTabHeaderCell17.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabHeaderCell17.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell17.BorderWidth = 0.6F;
            this.crossTabHeaderCell17.ColumnIndex = 0;
            this.crossTabHeaderCell17.ColumnSpan = 3;
            this.crossTabHeaderCell17.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabHeaderCell17.ForeColor = System.Drawing.Color.Black;
            this.crossTabHeaderCell17.Name = "crossTabHeaderCell17";
            this.crossTabHeaderCell17.RowIndex = 5;
            this.crossTabHeaderCell17.Text = "  Grand Total";
            // 
            // crossTabTotalCell10
            // 
            this.crossTabTotalCell10.BackColor = System.Drawing.Color.Transparent;
            this.crossTabTotalCell10.BorderColor = System.Drawing.Color.Silver;
            this.crossTabTotalCell10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabTotalCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabTotalCell10.BorderWidth = 0.6F;
            this.crossTabTotalCell10.ColumnIndex = 3;
            this.crossTabTotalCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "/*Iif([qtyDiffStatus] = \'Shortage\', \'#E57070\' , \'Black\' )*/\n\nIif([qtyDiff]<0,\'#E5" +
                    "7070\' , \'Black\' )\n\n\n\n")});
            this.crossTabTotalCell10.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabTotalCell10.ForeColor = System.Drawing.Color.Black;
            this.crossTabTotalCell10.Name = "crossTabTotalCell10";
            this.crossTabTotalCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.crossTabTotalCell10.RowIndex = 5;
            this.crossTabTotalCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabTotalCell10.TextFormatString = "{0:#,#0.###;(#,#0.###);0.###}";
            // 
            // crossTabHeaderCell18
            // 
            this.crossTabHeaderCell18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell18.BorderColor = System.Drawing.Color.Silver;
            this.crossTabHeaderCell18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.crossTabHeaderCell18.BorderWidth = 1F;
            this.crossTabHeaderCell18.ColumnIndex = 1;
            this.crossTabHeaderCell18.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Regular", 6F);
            this.crossTabHeaderCell18.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell18.Name = "crossTabHeaderCell18";
            this.crossTabHeaderCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            this.crossTabHeaderCell18.RowIndex = 0;
            this.crossTabHeaderCell18.RowSpan = 2;
            this.crossTabHeaderCell18.Text = "Item Group";
            this.crossTabHeaderCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabHeaderCell19
            // 
            this.crossTabHeaderCell19.BackColor = System.Drawing.Color.Transparent;
            this.crossTabHeaderCell19.BorderColor = System.Drawing.Color.Silver;
            this.crossTabHeaderCell19.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabHeaderCell19.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell19.BorderWidth = 0.6F;
            this.crossTabHeaderCell19.ColumnIndex = 1;
            this.crossTabHeaderCell19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[itemGroupDesc]")});
            this.crossTabHeaderCell19.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabHeaderCell19.ForeColor = System.Drawing.Color.Black;
            this.crossTabHeaderCell19.Name = "crossTabHeaderCell19";
            this.crossTabHeaderCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            this.crossTabHeaderCell19.RowIndex = 2;
            // 
            // crossTabHeaderCell20
            // 
            this.crossTabHeaderCell20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.crossTabHeaderCell20.BorderColor = System.Drawing.Color.Silver;
            this.crossTabHeaderCell20.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabHeaderCell20.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell20.BorderWidth = 0.6F;
            this.crossTabHeaderCell20.ColumnIndex = 0;
            this.crossTabHeaderCell20.ColumnSpan = 3;
            this.crossTabHeaderCell20.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabHeaderCell20.ForeColor = System.Drawing.Color.Black;
            this.crossTabHeaderCell20.Name = "crossTabHeaderCell20";
            this.crossTabHeaderCell20.RowIndex = 4;
            this.crossTabHeaderCell20.TextFormatString = "  Total {0}";
            // 
            // crossTabTotalCell11
            // 
            this.crossTabTotalCell11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.crossTabTotalCell11.BorderColor = System.Drawing.Color.Silver;
            this.crossTabTotalCell11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabTotalCell11.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabTotalCell11.BorderWidth = 0.6F;
            this.crossTabTotalCell11.ColumnIndex = 3;
            this.crossTabTotalCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "/*Iif([Result1].[qtyDiff] < 0,\'Red\',\'Black\')*/\nIif([qtyDiffStatus] = \'Shortage\', " +
                    "\'#E57070\' , \'Black\' )\n")});
            this.crossTabTotalCell11.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabTotalCell11.ForeColor = System.Drawing.Color.Black;
            this.crossTabTotalCell11.Name = "crossTabTotalCell11";
            this.crossTabTotalCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.crossTabTotalCell11.RowIndex = 4;
            this.crossTabTotalCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabTotalCell11.TextFormatString = "{0:#,#0.000;(#,#0.000);0.000}";
            // 
            // crossTabHeaderCell21
            // 
            this.crossTabHeaderCell21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell21.BorderColor = System.Drawing.Color.Silver;
            this.crossTabHeaderCell21.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.crossTabHeaderCell21.BorderWidth = 1F;
            this.crossTabHeaderCell21.ColumnIndex = 2;
            this.crossTabHeaderCell21.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Regular", 6F);
            this.crossTabHeaderCell21.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell21.Name = "crossTabHeaderCell21";
            this.crossTabHeaderCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            this.crossTabHeaderCell21.RowIndex = 0;
            this.crossTabHeaderCell21.RowSpan = 2;
            this.crossTabHeaderCell21.Text = "Item Category";
            this.crossTabHeaderCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabHeaderCell22
            // 
            this.crossTabHeaderCell22.BackColor = System.Drawing.Color.Transparent;
            this.crossTabHeaderCell22.BorderColor = System.Drawing.Color.Silver;
            this.crossTabHeaderCell22.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabHeaderCell22.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell22.BorderWidth = 0.6F;
            this.crossTabHeaderCell22.ColumnIndex = 2;
            this.crossTabHeaderCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[itemCategoryDesc]")});
            this.crossTabHeaderCell22.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabHeaderCell22.ForeColor = System.Drawing.Color.Black;
            this.crossTabHeaderCell22.Name = "crossTabHeaderCell22";
            this.crossTabHeaderCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            this.crossTabHeaderCell22.RowIndex = 2;
            // 
            // crossTabHeaderCell23
            // 
            this.crossTabHeaderCell23.BackColor = System.Drawing.Color.Transparent;
            this.crossTabHeaderCell23.BorderColor = System.Drawing.Color.Silver;
            this.crossTabHeaderCell23.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell23.BorderWidth = 0.6F;
            this.crossTabHeaderCell23.ColumnIndex = 1;
            this.crossTabHeaderCell23.ColumnSpan = 2;
            this.crossTabHeaderCell23.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabHeaderCell23.ForeColor = System.Drawing.Color.Black;
            this.crossTabHeaderCell23.Name = "crossTabHeaderCell23";
            this.crossTabHeaderCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.crossTabHeaderCell23.RowIndex = 3;
            this.crossTabHeaderCell23.TextFormatString = "Total {0}";
            // 
            // crossTabTotalCell12
            // 
            this.crossTabTotalCell12.BackColor = System.Drawing.Color.Transparent;
            this.crossTabTotalCell12.BorderColor = System.Drawing.Color.Silver;
            this.crossTabTotalCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabTotalCell12.BorderWidth = 0.6F;
            this.crossTabTotalCell12.ColumnIndex = 3;
            this.crossTabTotalCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "Iif([qtyDiffStatus] = \'Shortage\', \'#E57070\' , \'Black\' )\n")});
            this.crossTabTotalCell12.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabTotalCell12.ForeColor = System.Drawing.Color.Black;
            this.crossTabTotalCell12.Name = "crossTabTotalCell12";
            this.crossTabTotalCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.crossTabTotalCell12.RowIndex = 3;
            this.crossTabTotalCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabTotalCell12.TextFormatString = "{0:#,#0.000;(#,#0.000);0.000}";
            // 
            // crossTabHeaderCell24
            // 
            this.crossTabHeaderCell24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell24.BorderColor = System.Drawing.Color.Silver;
            this.crossTabHeaderCell24.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.crossTabHeaderCell24.BorderWidth = 1F;
            this.crossTabHeaderCell24.ColumnIndex = 3;
            this.crossTabHeaderCell24.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Regular", 6F);
            this.crossTabHeaderCell24.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell24.Name = "crossTabHeaderCell24";
            this.crossTabHeaderCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.crossTabHeaderCell24.RowIndex = 1;
            this.crossTabHeaderCell24.Text = "Qty Difference";
            this.crossTabHeaderCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabHeaderCell25
            // 
            this.crossTabHeaderCell25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell25.BorderColor = System.Drawing.Color.Silver;
            this.crossTabHeaderCell25.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.crossTabHeaderCell25.BorderWidth = 1F;
            this.crossTabHeaderCell25.ColumnIndex = 4;
            this.crossTabHeaderCell25.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabHeaderCell25.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell25.Name = "crossTabHeaderCell25";
            this.crossTabHeaderCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.crossTabHeaderCell25.RowIndex = 1;
            this.crossTabHeaderCell25.Text = "Cost Difference";
            this.crossTabHeaderCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabDataCell5
            // 
            this.crossTabDataCell5.BorderColor = System.Drawing.Color.Silver;
            this.crossTabDataCell5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabDataCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabDataCell5.BorderWidth = 0.6F;
            this.crossTabDataCell5.ColumnIndex = 4;
            this.crossTabDataCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "Iif([qtyDiffStatus] = \'Shortage\', \'#E57070\' , \'Black\' )\n")});
            this.crossTabDataCell5.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabDataCell5.ForeColor = System.Drawing.Color.Black;
            this.crossTabDataCell5.Name = "crossTabDataCell5";
            this.crossTabDataCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.crossTabDataCell5.RowIndex = 2;
            this.crossTabDataCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabDataCell5.TextFormatString = "{0:#,#0.000;(#,#0.000);0.000}";
            // 
            // crossTabTotalCell13
            // 
            this.crossTabTotalCell13.BackColor = System.Drawing.Color.Transparent;
            this.crossTabTotalCell13.BorderColor = System.Drawing.Color.Silver;
            this.crossTabTotalCell13.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabTotalCell13.BorderWidth = 0.6F;
            this.crossTabTotalCell13.ColumnIndex = 4;
            this.crossTabTotalCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "Iif([qtyDiffStatus] = \'Shortage\', \'#E57070\' , \'Black\' )\n")});
            this.crossTabTotalCell13.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabTotalCell13.ForeColor = System.Drawing.Color.Black;
            this.crossTabTotalCell13.Name = "crossTabTotalCell13";
            this.crossTabTotalCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.crossTabTotalCell13.RowIndex = 3;
            this.crossTabTotalCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabTotalCell13.TextFormatString = "{0:#,#0.000;(#,#0.000);0.000}";
            // 
            // crossTabTotalCell14
            // 
            this.crossTabTotalCell14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.crossTabTotalCell14.BorderColor = System.Drawing.Color.Silver;
            this.crossTabTotalCell14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabTotalCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabTotalCell14.BorderWidth = 0.6F;
            this.crossTabTotalCell14.ColumnIndex = 4;
            this.crossTabTotalCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "Iif([qtyDiffStatus] = \'Shortage\', \'#E57070\' , \'Black\' )\n")});
            this.crossTabTotalCell14.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabTotalCell14.ForeColor = System.Drawing.Color.Black;
            this.crossTabTotalCell14.Name = "crossTabTotalCell14";
            this.crossTabTotalCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.crossTabTotalCell14.RowIndex = 4;
            this.crossTabTotalCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabTotalCell14.TextFormatString = "{0:#,#0.000;(#,#0.000);0.000}";
            // 
            // crossTabTotalCell15
            // 
            this.crossTabTotalCell15.BackColor = System.Drawing.Color.Transparent;
            this.crossTabTotalCell15.BorderColor = System.Drawing.Color.Silver;
            this.crossTabTotalCell15.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabTotalCell15.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabTotalCell15.BorderWidth = 0.6F;
            this.crossTabTotalCell15.ColumnIndex = 4;
            this.crossTabTotalCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "/*Iif([qtyDiff] < 0, \'#E57070\' , \'Black\' )*/\n\nIif([retailDifference] < 0, \'#E5707" +
                    "0\' , \'Black\' )\n\n\n")});
            this.crossTabTotalCell15.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabTotalCell15.ForeColor = System.Drawing.Color.Black;
            this.crossTabTotalCell15.Name = "crossTabTotalCell15";
            this.crossTabTotalCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.crossTabTotalCell15.RowIndex = 5;
            this.crossTabTotalCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabTotalCell15.TextFormatString = "{0:#,#0.000;(#,#0.000);0.000}";
            // 
            // crossTabHeaderCell26
            // 
            this.crossTabHeaderCell26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell26.BorderColor = System.Drawing.Color.Silver;
            this.crossTabHeaderCell26.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.crossTabHeaderCell26.BorderWidth = 1F;
            this.crossTabHeaderCell26.ColumnIndex = 5;
            this.crossTabHeaderCell26.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Regular", 6F);
            this.crossTabHeaderCell26.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell26.Name = "crossTabHeaderCell26";
            this.crossTabHeaderCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.crossTabHeaderCell26.RowIndex = 1;
            this.crossTabHeaderCell26.Text = "Retail Difference";
            this.crossTabHeaderCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabDataCell6
            // 
            this.crossTabDataCell6.BorderColor = System.Drawing.Color.Silver;
            this.crossTabDataCell6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabDataCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabDataCell6.BorderWidth = 0.6F;
            this.crossTabDataCell6.ColumnIndex = 5;
            this.crossTabDataCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "/*Iif([retailDifference] < 0, \'#E57070\' , \'Black\' )*/\n\nIif([qtyDiffStatus] = \'Sho" +
                    "rtage\', \'#E57070\' , \'Black\' )\n\n")});
            this.crossTabDataCell6.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabDataCell6.ForeColor = System.Drawing.Color.Black;
            this.crossTabDataCell6.Name = "crossTabDataCell6";
            this.crossTabDataCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.crossTabDataCell6.RowIndex = 2;
            this.crossTabDataCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabDataCell6.TextFormatString = "{0:#,#0.000;(#,#0.000);0.000}";
            // 
            // crossTabTotalCell16
            // 
            this.crossTabTotalCell16.BackColor = System.Drawing.Color.Transparent;
            this.crossTabTotalCell16.BorderColor = System.Drawing.Color.Silver;
            this.crossTabTotalCell16.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabTotalCell16.BorderWidth = 0.6F;
            this.crossTabTotalCell16.ColumnIndex = 5;
            this.crossTabTotalCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "Iif([qtyDiffStatus] = \'Shortage\', \'#E57070\' , \'Black\' )\n")});
            this.crossTabTotalCell16.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabTotalCell16.ForeColor = System.Drawing.Color.Black;
            this.crossTabTotalCell16.Name = "crossTabTotalCell16";
            this.crossTabTotalCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.crossTabTotalCell16.RowIndex = 3;
            this.crossTabTotalCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabTotalCell16.TextFormatString = "{0:#,#0.000;(#,#0.000);0.000}";
            // 
            // crossTabTotalCell17
            // 
            this.crossTabTotalCell17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.crossTabTotalCell17.BorderColor = System.Drawing.Color.Silver;
            this.crossTabTotalCell17.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabTotalCell17.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabTotalCell17.BorderWidth = 0.6F;
            this.crossTabTotalCell17.ColumnIndex = 5;
            this.crossTabTotalCell17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "/*Iif([retailDifference] < 0, \'#E57070\' , \'Black\' )*/\n\nIif([qtyDiffStatus] = \'Sho" +
                    "rtage\', \'#E57070\' , \'Black\' )\n\n")});
            this.crossTabTotalCell17.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabTotalCell17.ForeColor = System.Drawing.Color.Black;
            this.crossTabTotalCell17.Name = "crossTabTotalCell17";
            this.crossTabTotalCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.crossTabTotalCell17.RowIndex = 4;
            this.crossTabTotalCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabTotalCell17.TextFormatString = "{0:#,#0.000;(#,#0.000);0.000}";
            // 
            // crossTabTotalCell18
            // 
            this.crossTabTotalCell18.BackColor = System.Drawing.Color.Transparent;
            this.crossTabTotalCell18.BorderColor = System.Drawing.Color.Silver;
            this.crossTabTotalCell18.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabTotalCell18.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabTotalCell18.BorderWidth = 0.6F;
            this.crossTabTotalCell18.ColumnIndex = 5;
            this.crossTabTotalCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "Iif([retailDifference] < 0, \'#E57070\' , \'Black\' )\n\n\n")});
            this.crossTabTotalCell18.Font = new DevExpress.Drawing.DXFont("duCoHeadline16-Light", 6F);
            this.crossTabTotalCell18.ForeColor = System.Drawing.Color.Black;
            this.crossTabTotalCell18.Name = "crossTabTotalCell18";
            this.crossTabTotalCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.crossTabTotalCell18.RowIndex = 5;
            this.crossTabTotalCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabTotalCell18.TextFormatString = "{0:#,#0.000;(#,#0.000);0.000}";
            // 
            // sr_StockCountId
            // 
            this.sr_StockCountId.Name = "sr_StockCountId";
            this.sr_StockCountId.Visible = false;
            // 
            // costDifference
            // 
            this.costDifference.DataMember = "RPT_STOCK_COUNT";
            this.costDifference.Expression = "[qtyDiff] * [costPrice]";
            this.costDifference.Name = "costDifference";
            // 
            // retailDifference
            // 
            this.retailDifference.DataMember = "RPT_STOCK_COUNT";
            this.retailDifference.Expression = "[qtyDiff] * [retailPrice]";
            this.retailDifference.Name = "retailDifference";
            // 
            // crossTabGeneralStyle1
            // 
            this.crossTabGeneralStyle1.BackColor = System.Drawing.Color.White;
            this.crossTabGeneralStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(141)))), ((int)(((byte)(44)))));
            this.crossTabGeneralStyle1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabGeneralStyle1.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.crossTabGeneralStyle1.ForeColor = System.Drawing.Color.Black;
            this.crossTabGeneralStyle1.Name = "crossTabGeneralStyle1";
            this.crossTabGeneralStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // crossTabHeaderStyle1
            // 
            this.crossTabHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.crossTabHeaderStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(141)))), ((int)(((byte)(44)))));
            this.crossTabHeaderStyle1.Name = "crossTabHeaderStyle1";
            this.crossTabHeaderStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabDataStyle1
            // 
            this.crossTabDataStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(141)))), ((int)(((byte)(44)))));
            this.crossTabDataStyle1.Name = "crossTabDataStyle1";
            this.crossTabDataStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabTotalStyle1
            // 
            this.crossTabTotalStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(141)))), ((int)(((byte)(44)))));
            this.crossTabTotalStyle1.Name = "crossTabTotalStyle1";
            this.crossTabTotalStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "PowerBI";
            this.sqlDataSource2.Name = "sqlDataSource2";
            storedProcQuery1.Name = "RPT_STOCK_COUNT_II";
            queryParameter1.Name = "@auditNo";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?sr_StockCountId", typeof(string));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "RPT_STOCK_COUNT_II";
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // Stock_Count_Detail_Sub_Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.costDifference,
            this.retailDifference});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource2});
            this.DataMember = "RPT_STOCK_COUNT_II";
            this.DataSource = this.sqlDataSource2;
            this.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "Iif([Result1].[qtyDiffStatus] = \'Shortage\', \'#F3C6C6\' , \'#F1F0F0\' )\n")});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(35F, 11F, 24.82F, 20.02F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.sr_StockCountId});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.crossTabGeneralStyle1,
            this.crossTabHeaderStyle1,
            this.crossTabDataStyle1,
            this.crossTabTotalStyle1});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.Parameters.Parameter sr_StockCountId;
        private DevExpress.XtraReports.UI.CalculatedField costDifference;
        private DevExpress.XtraReports.UI.CalculatedField retailDifference;
        private DevExpress.XtraReports.UI.XRCrossTab xrCrossTab2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell14;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabDataCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell15;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell16;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell17;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell10;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell18;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell19;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell20;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell11;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell21;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell22;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell23;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell12;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell24;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell25;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabDataCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell13;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell14;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell15;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell26;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabDataCell6;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell16;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell17;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell18;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle1;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
    }
}
