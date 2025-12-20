
namespace dxReports.Reports
{
    partial class Stock_Count_On_Hand_Sub_Report_CrossTab
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
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition3 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField3 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField4 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Count_On_Hand_Sub_Report_CrossTab));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrCrossTab1 = new DevExpress.XtraReports.UI.XRCrossTab();
            this.crossTabHeaderCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabDataCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell6 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell7 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell8 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell9 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell10 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell11 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell12 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell13 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.crossTabGeneralStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabHeaderStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabDataStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabTotalStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.sr_StockCountId = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab1)).BeginInit();
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
            this.xrCrossTab1});
            this.Detail.HeightF = 129F;
            this.Detail.Name = "Detail";
            // 
            // xrCrossTab1
            // 
            this.xrCrossTab1.Cells.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.crossTabHeaderCell1,
            this.crossTabDataCell1,
            this.crossTabHeaderCell2,
            this.crossTabHeaderCell3,
            this.crossTabHeaderCell4,
            this.crossTabTotalCell1,
            this.crossTabHeaderCell5,
            this.crossTabHeaderCell6,
            this.crossTabHeaderCell7,
            this.crossTabTotalCell2,
            this.crossTabHeaderCell8,
            this.crossTabHeaderCell9,
            this.crossTabHeaderCell10,
            this.crossTabTotalCell3,
            this.crossTabHeaderCell11,
            this.crossTabHeaderCell12,
            this.crossTabHeaderCell13,
            this.crossTabTotalCell4});
            this.xrCrossTab1.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(160.8F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(90.05343F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(81.37288F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(310.9735F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(160.8002F)});
            this.xrCrossTab1.DataAreaStyleName = "crossTabDataStyle1";
            crossTabDataField1.FieldName = "qty";
            this.xrCrossTab1.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
            crossTabDataField1});
            this.xrCrossTab1.DataMember = "RPT_STOCK_COUNT.Result1";
            this.xrCrossTab1.DataSource = this.sqlDataSource1;
            this.xrCrossTab1.FilterString = "[qtyDiff] <> 0.0m";
            this.xrCrossTab1.GeneralStyleName = "crossTabGeneralStyle1";
            this.xrCrossTab1.HeaderAreaStyleName = "crossTabHeaderStyle1";
            this.xrCrossTab1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCrossTab1.Name = "xrCrossTab1";
            crossTabRowDefinition1.Visible = false;
            crossTabRowDefinition2.Visible = false;
            crossTabRowDefinition3.Visible = false;
            this.xrCrossTab1.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(18F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(18F),
            crossTabRowDefinition1,
            crossTabRowDefinition2,
            crossTabRowDefinition3,
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(18F)});
            crossTabRowField1.FieldName = "itemGroupDesc";
            crossTabRowField2.FieldName = "itemCategoryDesc";
            crossTabRowField3.FieldName = "itemCode";
            crossTabRowField4.FieldName = "itemName";
            this.xrCrossTab1.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
            crossTabRowField1,
            crossTabRowField2,
            crossTabRowField3,
            crossTabRowField4});
            this.xrCrossTab1.SizeF = new System.Drawing.SizeF(804F, 129F);
            this.xrCrossTab1.TotalAreaStyleName = "crossTabTotalStyle1";
            // 
            // crossTabHeaderCell1
            // 
            this.crossTabHeaderCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabHeaderCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell1.BorderWidth = 1F;
            this.crossTabHeaderCell1.ColumnIndex = 0;
            this.crossTabHeaderCell1.Font = new DevExpress.Drawing.DXFont("ubuntu", 7.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabHeaderCell1.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell1.Name = "crossTabHeaderCell1";
            this.crossTabHeaderCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.crossTabHeaderCell1.RowIndex = 0;
            this.crossTabHeaderCell1.Text = "  Item Group";
            this.crossTabHeaderCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabDataCell1
            // 
            this.crossTabDataCell1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabDataCell1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabDataCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabDataCell1.BorderWidth = 1F;
            this.crossTabDataCell1.ColumnIndex = 4;
            this.crossTabDataCell1.Font = new DevExpress.Drawing.DXFont("ubuntu", 7.5F);
            this.crossTabDataCell1.ForeColor = System.Drawing.Color.Black;
            this.crossTabDataCell1.Name = "crossTabDataCell1";
            this.crossTabDataCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.crossTabDataCell1.RowIndex = 1;
            this.crossTabDataCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabDataCell1.TextFormatString = "{0:#,#0;(#,#0);0}";
            // 
            // crossTabHeaderCell2
            // 
            this.crossTabHeaderCell2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell2.BorderWidth = 1F;
            this.crossTabHeaderCell2.ColumnIndex = 4;
            this.crossTabHeaderCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'Total\'")});
            this.crossTabHeaderCell2.Font = new DevExpress.Drawing.DXFont("ubuntu", 7.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabHeaderCell2.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell2.Name = "crossTabHeaderCell2";
            this.crossTabHeaderCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.crossTabHeaderCell2.RowIndex = 0;
            this.crossTabHeaderCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabHeaderCell3
            // 
            this.crossTabHeaderCell3.BackColor = System.Drawing.Color.Transparent;
            this.crossTabHeaderCell3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabHeaderCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell3.BorderWidth = 1F;
            this.crossTabHeaderCell3.ColumnIndex = 0;
            this.crossTabHeaderCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'  \' + [itemGroupDesc]")});
            this.crossTabHeaderCell3.Font = new DevExpress.Drawing.DXFont("ubuntu", 7.5F);
            this.crossTabHeaderCell3.ForeColor = System.Drawing.Color.Black;
            this.crossTabHeaderCell3.Name = "crossTabHeaderCell3";
            this.crossTabHeaderCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.crossTabHeaderCell3.RowIndex = 1;
            this.crossTabHeaderCell3.RowSpan = 3;
            this.crossTabHeaderCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabHeaderCell4
            // 
            this.crossTabHeaderCell4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.crossTabHeaderCell4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabHeaderCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell4.BorderWidth = 1F;
            this.crossTabHeaderCell4.ColumnIndex = 0;
            this.crossTabHeaderCell4.ColumnSpan = 4;
            this.crossTabHeaderCell4.Font = new DevExpress.Drawing.DXFont("ubuntu", 7.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabHeaderCell4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(102)))), ((int)(((byte)(122)))));
            this.crossTabHeaderCell4.Name = "crossTabHeaderCell4";
            this.crossTabHeaderCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.crossTabHeaderCell4.RowIndex = 5;
            this.crossTabHeaderCell4.Text = "  Grand Total";
            // 
            // crossTabTotalCell1
            // 
            this.crossTabTotalCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.crossTabTotalCell1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabTotalCell1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabTotalCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabTotalCell1.BorderWidth = 1F;
            this.crossTabTotalCell1.ColumnIndex = 4;
            this.crossTabTotalCell1.Font = new DevExpress.Drawing.DXFont("ubuntu", 7.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabTotalCell1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(102)))), ((int)(((byte)(122)))));
            this.crossTabTotalCell1.Name = "crossTabTotalCell1";
            this.crossTabTotalCell1.RowIndex = 5;
            this.crossTabTotalCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabTotalCell1.TextFormatString = "{0:#,#0;(#,#0);0}";
            // 
            // crossTabHeaderCell5
            // 
            this.crossTabHeaderCell5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabHeaderCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell5.BorderWidth = 1F;
            this.crossTabHeaderCell5.ColumnIndex = 1;
            this.crossTabHeaderCell5.Font = new DevExpress.Drawing.DXFont("ubuntu", 7.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabHeaderCell5.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell5.Name = "crossTabHeaderCell5";
            this.crossTabHeaderCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.crossTabHeaderCell5.RowIndex = 0;
            this.crossTabHeaderCell5.Text = "Item Category";
            this.crossTabHeaderCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabHeaderCell6
            // 
            this.crossTabHeaderCell6.BackColor = System.Drawing.Color.Transparent;
            this.crossTabHeaderCell6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabHeaderCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell6.BorderWidth = 1F;
            this.crossTabHeaderCell6.ColumnIndex = 1;
            this.crossTabHeaderCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[itemCategoryDesc]")});
            this.crossTabHeaderCell6.Font = new DevExpress.Drawing.DXFont("ubuntu", 7.5F);
            this.crossTabHeaderCell6.ForeColor = System.Drawing.Color.Black;
            this.crossTabHeaderCell6.Name = "crossTabHeaderCell6";
            this.crossTabHeaderCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.crossTabHeaderCell6.RowIndex = 1;
            this.crossTabHeaderCell6.RowSpan = 2;
            this.crossTabHeaderCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabHeaderCell7
            // 
            this.crossTabHeaderCell7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.crossTabHeaderCell7.BorderColor = System.Drawing.Color.Silver;
            this.crossTabHeaderCell7.BorderWidth = 1F;
            this.crossTabHeaderCell7.ColumnIndex = 0;
            this.crossTabHeaderCell7.ColumnSpan = 4;
            this.crossTabHeaderCell7.Font = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            this.crossTabHeaderCell7.ForeColor = System.Drawing.Color.Black;
            this.crossTabHeaderCell7.Name = "crossTabHeaderCell7";
            this.crossTabHeaderCell7.RowIndex = 4;
            this.crossTabHeaderCell7.TextFormatString = "Total {0}";
            // 
            // crossTabTotalCell2
            // 
            this.crossTabTotalCell2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.crossTabTotalCell2.BorderColor = System.Drawing.Color.Silver;
            this.crossTabTotalCell2.BorderWidth = 1F;
            this.crossTabTotalCell2.ColumnIndex = 4;
            this.crossTabTotalCell2.Font = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            this.crossTabTotalCell2.ForeColor = System.Drawing.Color.Black;
            this.crossTabTotalCell2.Name = "crossTabTotalCell2";
            this.crossTabTotalCell2.RowIndex = 4;
            // 
            // crossTabHeaderCell8
            // 
            this.crossTabHeaderCell8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabHeaderCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell8.BorderWidth = 1F;
            this.crossTabHeaderCell8.ColumnIndex = 2;
            this.crossTabHeaderCell8.Font = new DevExpress.Drawing.DXFont("ubuntu", 7.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabHeaderCell8.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell8.Name = "crossTabHeaderCell8";
            this.crossTabHeaderCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.crossTabHeaderCell8.RowIndex = 0;
            this.crossTabHeaderCell8.Text = "Item Code";
            this.crossTabHeaderCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabHeaderCell9
            // 
            this.crossTabHeaderCell9.BackColor = System.Drawing.Color.Transparent;
            this.crossTabHeaderCell9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabHeaderCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell9.BorderWidth = 1F;
            this.crossTabHeaderCell9.ColumnIndex = 2;
            this.crossTabHeaderCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[itemCode]")});
            this.crossTabHeaderCell9.Font = new DevExpress.Drawing.DXFont("ubuntu", 7.5F);
            this.crossTabHeaderCell9.ForeColor = System.Drawing.Color.Black;
            this.crossTabHeaderCell9.Name = "crossTabHeaderCell9";
            this.crossTabHeaderCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.crossTabHeaderCell9.RowIndex = 1;
            this.crossTabHeaderCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabHeaderCell10
            // 
            this.crossTabHeaderCell10.BorderColor = System.Drawing.Color.Silver;
            this.crossTabHeaderCell10.BorderWidth = 1F;
            this.crossTabHeaderCell10.ColumnIndex = 1;
            this.crossTabHeaderCell10.ColumnSpan = 3;
            this.crossTabHeaderCell10.Font = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            this.crossTabHeaderCell10.Name = "crossTabHeaderCell10";
            this.crossTabHeaderCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.crossTabHeaderCell10.RowIndex = 3;
            this.crossTabHeaderCell10.TextFormatString = "Total {0}";
            // 
            // crossTabTotalCell3
            // 
            this.crossTabTotalCell3.BorderColor = System.Drawing.Color.Silver;
            this.crossTabTotalCell3.BorderWidth = 1F;
            this.crossTabTotalCell3.ColumnIndex = 4;
            this.crossTabTotalCell3.Font = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            this.crossTabTotalCell3.Name = "crossTabTotalCell3";
            this.crossTabTotalCell3.RowIndex = 3;
            // 
            // crossTabHeaderCell11
            // 
            this.crossTabHeaderCell11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabHeaderCell11.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell11.BorderWidth = 1F;
            this.crossTabHeaderCell11.ColumnIndex = 3;
            this.crossTabHeaderCell11.Font = new DevExpress.Drawing.DXFont("ubuntu", 7.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabHeaderCell11.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell11.Name = "crossTabHeaderCell11";
            this.crossTabHeaderCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.crossTabHeaderCell11.RowIndex = 0;
            this.crossTabHeaderCell11.Text = " Item Name";
            this.crossTabHeaderCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabHeaderCell12
            // 
            this.crossTabHeaderCell12.BackColor = System.Drawing.Color.Transparent;
            this.crossTabHeaderCell12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(122)))), ((int)(((byte)(160)))));
            this.crossTabHeaderCell12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.crossTabHeaderCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabHeaderCell12.BorderWidth = 1F;
            this.crossTabHeaderCell12.ColumnIndex = 3;
            this.crossTabHeaderCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'  \' + [itemName]")});
            this.crossTabHeaderCell12.Font = new DevExpress.Drawing.DXFont("ubuntu", 7.5F);
            this.crossTabHeaderCell12.ForeColor = System.Drawing.Color.Black;
            this.crossTabHeaderCell12.Name = "crossTabHeaderCell12";
            this.crossTabHeaderCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.crossTabHeaderCell12.RowIndex = 1;
            this.crossTabHeaderCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabHeaderCell13
            // 
            this.crossTabHeaderCell13.BorderColor = System.Drawing.Color.Silver;
            this.crossTabHeaderCell13.BorderWidth = 1F;
            this.crossTabHeaderCell13.ColumnIndex = 2;
            this.crossTabHeaderCell13.ColumnSpan = 2;
            this.crossTabHeaderCell13.Font = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            this.crossTabHeaderCell13.Name = "crossTabHeaderCell13";
            this.crossTabHeaderCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.crossTabHeaderCell13.RowIndex = 2;
            this.crossTabHeaderCell13.TextFormatString = "Total {0}";
            // 
            // crossTabTotalCell4
            // 
            this.crossTabTotalCell4.BorderColor = System.Drawing.Color.Silver;
            this.crossTabTotalCell4.BorderWidth = 1F;
            this.crossTabTotalCell4.ColumnIndex = 4;
            this.crossTabTotalCell4.Font = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            this.crossTabTotalCell4.Name = "crossTabTotalCell4";
            this.crossTabTotalCell4.RowIndex = 2;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "PowerBI";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "RPT_STOCK_COUNT";
            queryParameter1.Name = "@stockCountId";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?sr_StockCountId", typeof(string));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "RPT_STOCK_COUNT";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // crossTabGeneralStyle1
            // 
            this.crossTabGeneralStyle1.BackColor = System.Drawing.Color.White;
            this.crossTabGeneralStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(45)))));
            this.crossTabGeneralStyle1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabGeneralStyle1.BorderWidth = 0.1F;
            this.crossTabGeneralStyle1.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.crossTabGeneralStyle1.ForeColor = System.Drawing.Color.Black;
            this.crossTabGeneralStyle1.Name = "crossTabGeneralStyle1";
            this.crossTabGeneralStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // crossTabHeaderStyle1
            // 
            this.crossTabHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.crossTabHeaderStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(45)))));
            this.crossTabHeaderStyle1.BorderWidth = 0.1F;
            this.crossTabHeaderStyle1.Name = "crossTabHeaderStyle1";
            this.crossTabHeaderStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabDataStyle1
            // 
            this.crossTabDataStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(45)))));
            this.crossTabDataStyle1.BorderWidth = 0.1F;
            this.crossTabDataStyle1.Name = "crossTabDataStyle1";
            this.crossTabDataStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabTotalStyle1
            // 
            this.crossTabTotalStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(45)))));
            this.crossTabTotalStyle1.BorderWidth = 0.1F;
            this.crossTabTotalStyle1.Name = "crossTabTotalStyle1";
            this.crossTabTotalStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // sr_StockCountId
            // 
            this.sr_StockCountId.Name = "sr_StockCountId";
            this.sr_StockCountId.Visible = false;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox2,
            this.xrLine1,
            this.xrLabel6});
            this.PageHeader.HeightF = 30.50069F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPictureBox2.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::dxReports.Properties.Resources.productquickshippments, true);
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 9.040003F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(18.81F, 18.25F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            this.xrPictureBox2.StylePriority.UseBorders = false;
            // 
            // xrLine1
            // 
            this.xrLine1.BorderWidth = 0F;
            this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(102)))), ((int)(((byte)(122)))));
            this.xrLine1.LineWidth = 1.5F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(139.841F, 10.41667F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(664.1592F, 16.87405F);
            this.xrLine1.StylePriority.UseBorderWidth = false;
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.BorderWidth = 1.2F;
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("neotech", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(102)))), ((int)(((byte)(122)))));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(18.81002F, 0F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(121.031F, 27.2907F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseBorderWidth = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Stock on Hand";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel22});
            this.PageFooter.HeightF = 80F;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1});
            this.PageFooter.Visible = false;
            // 
            // xrLabel22
            // 
            this.xrLabel22.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(102)))), ((int)(((byte)(122)))));
            this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel22.BorderWidth = 1.5F;
            this.xrLabel22.Font = new DevExpress.Drawing.DXFont("neotech", 10F);
            this.xrLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(102)))), ((int)(((byte)(122)))));
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(560.4847F, 43.44146F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(238.3485F, 29.60506F);
            this.xrLabel22.StylePriority.UseBackColor = false;
            this.xrLabel22.StylePriority.UseBorderColor = false;
            this.xrLabel22.StylePriority.UseBorders = false;
            this.xrLabel22.StylePriority.UseBorderWidth = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseForeColor = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "Signature : Shop Incharge";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2});
            this.SubBand1.HeightF = 20.02384F;
            this.SubBand1.Name = "SubBand1";
            this.SubBand1.Visible = false;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.BorderColor = System.Drawing.Color.Transparent;
            this.xrPageInfo2.BorderWidth = 0F;
            this.xrPageInfo2.Font = new DevExpress.Drawing.DXFont("tahoma", 8F);
            this.xrPageInfo2.ForeColor = System.Drawing.Color.Silver;
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(804.0001F, 20.02384F);
            this.xrPageInfo2.StylePriority.UseBorderColor = false;
            this.xrPageInfo2.StylePriority.UseBorderWidth = false;
            this.xrPageInfo2.StylePriority.UseFont = false;
            this.xrPageInfo2.StylePriority.UseForeColor = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrPageInfo2.TextFormatString = "Page : {0} of {1}";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.ReportFooter.HeightF = 25.15543F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("ubuntu", 7.5F);
            this.xrLabel1.ForeColor = System.Drawing.Color.Gray;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(804F, 25.15543F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "End of \"Stock on Hand\"";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // Stock_Count_On_Hand_Sub_Report_CrossTab
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader,
            this.PageFooter,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "RPT_STOCK_COUNT";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(35F, 11F, 24.82F, 20.02F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.sr_StockCountId, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.sr_StockCountId});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.crossTabGeneralStyle1,
            this.crossTabHeaderStyle1,
            this.crossTabDataStyle1,
            this.crossTabTotalStyle1});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRCrossTab xrCrossTab1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabDataCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell3;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle1;
        private DevExpress.XtraReports.Parameters.Parameter sr_StockCountId;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell6;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell7;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell8;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell9;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell10;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell3;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell11;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell12;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell13;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell4;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}
