namespace dxReports.Reports.Outgoing_Payments
{
    partial class Outgoing_Payment_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Outgoing_Payment_2));
            DevExpress.XtraPrinting.BarCode.Code39Generator code39Generator1 = new DevExpress.XtraPrinting.BarCode.Code39Generator();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle1 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.SubBand10 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand3 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand4 = new DevExpress.XtraReports.UI.SubBand();
            this.DocEntry = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.SubBand8 = new DevExpress.XtraReports.UI.SubBand();
            this.cf_Currency = new DevExpress.XtraReports.UI.CalculatedField();
            this.cf_CheckCurrency = new DevExpress.XtraReports.UI.CalculatedField();
            this.cf_Amount2 = new DevExpress.XtraReports.UI.CalculatedField();
            this.cf_SubTotal = new DevExpress.XtraReports.UI.CalculatedField();
            this.cf_AmountFlag2 = new DevExpress.XtraReports.UI.CalculatedField();
            this.cf_CreditSum = new DevExpress.XtraReports.UI.CalculatedField();
            this.cf_CheckSum = new DevExpress.XtraReports.UI.CalculatedField();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTable26 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow35 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell130 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrShape3 = new DevExpress.XtraReports.UI.XRShape();
            this.xrTableCell131 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable25 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow31 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell126 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow32 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell127 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow33 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell128 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow34 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell129 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SubBand7 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.SubBand5 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow60 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell234 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell235 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell236 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SubBand6 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.cf_BankSum = new DevExpress.XtraReports.UI.CalculatedField();
            this.cf_CashSum = new DevExpress.XtraReports.UI.CalculatedField();
            this.cf_TotalSum = new DevExpress.XtraReports.UI.CalculatedField();
            this.cf_DdctSum = new DevExpress.XtraReports.UI.CalculatedField();
            this.cf_Remarks = new DevExpress.XtraReports.UI.CalculatedField();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable24 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell123 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell124 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell125 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine13 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTable19 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell95 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SubBand9 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLine10 = new DevExpress.XtraReports.UI.XRLine();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader4 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader5 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader6 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader7 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.SubBand11 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable14 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell102 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell103 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell104 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SubBand17 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter4 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrTable23 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell120 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell121 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell122 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine11 = new DevExpress.XtraReports.UI.XRLine();
            this.SubBand26 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLine12 = new DevExpress.XtraReports.UI.XRLine();
            this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable9 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader8 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.SubBand12 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable15 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell106 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell107 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SubBand16 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter3 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTable18 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SubBand25 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLine9 = new DevExpress.XtraReports.UI.XRLine();
            this.DetailReport2 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail3 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable11 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader9 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.SubBand13 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable16 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell108 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell109 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell110 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SubBand15 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable10 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
            this.DetailReport3 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail4 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable13 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell101 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader10 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.SubBand14 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable17 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell111 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SubBand18 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable12 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell98 = new DevExpress.XtraReports.UI.XRTableCell();
            this.DetailReport4 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail5 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader11 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SubBand19 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.SubBand23 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SubBand20 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTable20 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell112 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell113 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SubBand21 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable21 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell114 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell115 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell116 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
            this.SubBand22 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTable22 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell117 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell118 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell119 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SubBand24 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLine8 = new DevExpress.XtraReports.UI.XRLine();
            this.cf_DocumentNumber = new DevExpress.XtraReports.UI.CalculatedField();
            this.cf_DocTotal = new DevExpress.XtraReports.UI.CalculatedField();
            this.cf_WTSum = new DevExpress.XtraReports.UI.CalculatedField();
            this.cf_PaymentOnAccount = new DevExpress.XtraReports.UI.CalculatedField();
            this.cf_Total = new DevExpress.XtraReports.UI.CalculatedField();
            this.SubBand27 = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 29.48718F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 71.99409F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand10,
            this.SubBand1,
            this.SubBand2,
            this.SubBand3,
            this.SubBand4});
            // 
            // SubBand10
            // 
            this.SubBand10.HeightF = 0F;
            this.SubBand10.Name = "SubBand10";
            // 
            // SubBand1
            // 
            this.SubBand1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[cf_CreditSum] <> 0")});
            this.SubBand1.HeightF = 0F;
            this.SubBand1.Name = "SubBand1";
            // 
            // SubBand2
            // 
            this.SubBand2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[cf_CheckSum] <> 0")});
            this.SubBand2.HeightF = 0F;
            this.SubBand2.Name = "SubBand2";
            // 
            // SubBand3
            // 
            this.SubBand3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[cf_BankSum] <> 0")});
            this.SubBand3.HeightF = 0F;
            this.SubBand3.Name = "SubBand3";
            // 
            // SubBand4
            // 
            this.SubBand4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[cf_CashSum] <> 0")});
            this.SubBand4.HeightF = 0F;
            this.SubBand4.Name = "SubBand4";
            // 
            // DocEntry
            // 
            this.DocEntry.Name = "DocEntry";
            this.DocEntry.Type = typeof(int);
            this.DocEntry.ValueInfo = "55035";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Far_hana";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            queryParameter1.Name = "DOCENTRY";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?DocEntry", typeof(int));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "AMG_TRD_UAE.RPT_OUTGIONG_PAYMENT_II";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.HeightF = 0F;
            this.GroupHeader1.Level = 5;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand8});
            // 
            // SubBand8
            // 
            this.SubBand8.HeightF = 0F;
            this.SubBand8.Name = "SubBand8";
            // 
            // cf_Currency
            // 
            this.cf_Currency.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_Currency.Expression = resources.GetString("cf_Currency.Expression");
            this.cf_Currency.Name = "cf_Currency";
            // 
            // cf_CheckCurrency
            // 
            this.cf_CheckCurrency.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_CheckCurrency.Expression = "Iif([cf_Currency] == [OADM_MainCurncy],\'True\' , \'False\' )";
            this.cf_CheckCurrency.Name = "cf_CheckCurrency";
            // 
            // cf_Amount2
            // 
            this.cf_Amount2.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_Amount2.Expression = "/*Iif([cf_Currency] = [OADM_MainCurncy], [VPM2_SumApplied],\n    Iif([cf_Currency]" +
    " == [OADM_SysCurrncy], [VPM2_AppliedSys],\n        [VPM2_AppliedFC]))*/\n\n[VPM2_Su" +
    "mApplied]";
            this.cf_Amount2.Name = "cf_Amount2";
            // 
            // cf_SubTotal
            // 
            this.cf_SubTotal.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_SubTotal.Expression = "Iif([OVPM_DocCurr] == [OADM_MainCurncy], [OVPM_DocTotal],\nIif([OVPM_DocCurr] == [" +
    "OADM_SysCurrncy], [OVPM_DocTotalSy], [OVPM_DocTotalFC]))\n\n\n";
            this.cf_SubTotal.Name = "cf_SubTotal";
            // 
            // cf_AmountFlag2
            // 
            this.cf_AmountFlag2.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_AmountFlag2.Expression = resources.GetString("cf_AmountFlag2.Expression");
            this.cf_AmountFlag2.Name = "cf_AmountFlag2";
            // 
            // cf_CreditSum
            // 
            this.cf_CreditSum.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_CreditSum.Expression = "Iif([OVPM_DocCurr] == [OADM_MainCurncy], [OVPM_CreditSum], [OVPM_CredSumFC])";
            this.cf_CreditSum.Name = "cf_CreditSum";
            // 
            // cf_CheckSum
            // 
            this.cf_CheckSum.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_CheckSum.Expression = "Iif([OVPM_DocCurr] == [OADM_MainCurncy], [OVPM_CheckSum], [OVPM_CheckSumFC])\n";
            this.cf_CheckSum.Name = "cf_CheckSum";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode1,
            this.xrTable26,
            this.xrTable25,
            this.xrPictureBox1});
            this.PageHeader.HeightF = 74.60587F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand7,
            this.SubBand5,
            this.SubBand6});
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.AutoModule = true;
            this.xrBarCode1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "IsNullOrEmpty([GlblLocNum]) || IsNullOrEmpty([Building])"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OVPM_DocNum]")});
            this.xrBarCode1.Font = new DevExpress.Drawing.DXFont("CALIBRI", 10F);
            this.xrBarCode1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(556.7507F, 36.70164F);
            this.xrBarCode1.Module = 1.2F;
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode1.ShowText = false;
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(195.2493F, 37.90423F);
            this.xrBarCode1.StylePriority.UseFont = false;
            this.xrBarCode1.StylePriority.UseForeColor = false;
            this.xrBarCode1.StylePriority.UseTextAlignment = false;
            code39Generator1.WideNarrowRatio = 3F;
            this.xrBarCode1.Symbology = code39Generator1;
            this.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTable26
            // 
            this.xrTable26.LocationFloat = new DevExpress.Utils.PointFloat(556.7507F, 0F);
            this.xrTable26.Name = "xrTable26";
            this.xrTable26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable26.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow35});
            this.xrTable26.SizeF = new System.Drawing.SizeF(195.2492F, 32.01414F);
            // 
            // xrTableRow35
            // 
            this.xrTableRow35.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell130,
            this.xrTableCell131});
            this.xrTableRow35.Name = "xrTableRow35";
            this.xrTableRow35.Weight = 1D;
            // 
            // xrTableCell130
            // 
            this.xrTableCell130.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrShape3});
            this.xrTableCell130.Multiline = true;
            this.xrTableCell130.Name = "xrTableCell130";
            this.xrTableCell130.Text = "xrTableCell9";
            this.xrTableCell130.Weight = 0.22418991298183943D;
            // 
            // xrShape3
            // 
            this.xrShape3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(164)))), ((int)(((byte)(31)))));
            this.xrShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrShape3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrShape3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(164)))), ((int)(((byte)(31)))));
            this.xrShape3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrShape3.LocationFloat = new DevExpress.Utils.PointFloat(8.50177F, 6.94561F);
            this.xrShape3.Name = "xrShape3";
            this.xrShape3.Shape = shapeRectangle1;
            this.xrShape3.SizeF = new System.Drawing.SizeF(7.368408F, 25.06853F);
            this.xrShape3.StylePriority.UseBackColor = false;
            this.xrShape3.StylePriority.UseBorderColor = false;
            this.xrShape3.StylePriority.UseBorders = false;
            this.xrShape3.StylePriority.UseForeColor = false;
            // 
            // xrTableCell131
            // 
            this.xrTableCell131.Font = new DevExpress.Drawing.DXFont("Calibri", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell131.ForeColor = System.Drawing.Color.Maroon;
            this.xrTableCell131.Multiline = true;
            this.xrTableCell131.Name = "xrTableCell131";
            this.xrTableCell131.StylePriority.UseFont = false;
            this.xrTableCell131.StylePriority.UseForeColor = false;
            this.xrTableCell131.StylePriority.UseTextAlignment = false;
            this.xrTableCell131.Tag = "PROFORMA INVOICE";
            this.xrTableCell131.Text = "PROFORMA INVOICE";
            this.xrTableCell131.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.xrTableCell131.Weight = 2.23454744191635D;
            // 
            // xrTable25
            // 
            this.xrTable25.Font = new DevExpress.Drawing.DXFont("Arial", 22F);
            this.xrTable25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable25.LocationFloat = new DevExpress.Utils.PointFloat(75.13053F, 0F);
            this.xrTable25.Name = "xrTable25";
            this.xrTable25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable25.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow31,
            this.xrTableRow32,
            this.xrTableRow33,
            this.xrTableRow34});
            this.xrTable25.SizeF = new System.Drawing.SizeF(481.6201F, 74.60587F);
            this.xrTable25.StylePriority.UseFont = false;
            this.xrTable25.StylePriority.UseForeColor = false;
            // 
            // xrTableRow31
            // 
            this.xrTableRow31.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell126});
            this.xrTableRow31.Name = "xrTableRow31";
            this.xrTableRow31.Weight = 0.25D;
            // 
            // xrTableCell126
            // 
            this.xrTableCell126.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[U_Name]")});
            this.xrTableCell126.Font = new DevExpress.Drawing.DXFont("Calibri", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell126.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell126.Multiline = true;
            this.xrTableCell126.Name = "xrTableCell126";
            this.xrTableCell126.StylePriority.UseFont = false;
            this.xrTableCell126.StylePriority.UseForeColor = false;
            this.xrTableCell126.StylePriority.UseTextAlignment = false;
            this.xrTableCell126.Text = "xrTableCell3";
            this.xrTableCell126.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell126.Weight = 2.3963924593205168D;
            // 
            // xrTableRow32
            // 
            this.xrTableRow32.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell127});
            this.xrTableRow32.Name = "xrTableRow32";
            this.xrTableRow32.Weight = 0.18618992405363946D;
            // 
            // xrTableCell127
            // 
            this.xrTableCell127.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'Sales Office : \' +  [U_SaleOfficeAddress_EN]")});
            this.xrTableCell127.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.xrTableCell127.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell127.Multiline = true;
            this.xrTableCell127.Name = "xrTableCell127";
            this.xrTableCell127.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.xrTableCell127.StylePriority.UseFont = false;
            this.xrTableCell127.StylePriority.UseForeColor = false;
            this.xrTableCell127.StylePriority.UseTextAlignment = false;
            this.xrTableCell127.Text = "xrTableCell33";
            this.xrTableCell127.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell127.Weight = 2.078791818049698D;
            // 
            // xrTableRow33
            // 
            this.xrTableRow33.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell128});
            this.xrTableRow33.Name = "xrTableRow33";
            this.xrTableRow33.Weight = 0.18618992405363949D;
            // 
            // xrTableCell128
            // 
            this.xrTableCell128.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[U_TRNLabel_EN] + \' : \' + [U_TRNValue_EN]")});
            this.xrTableCell128.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.xrTableCell128.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell128.Multiline = true;
            this.xrTableCell128.Name = "xrTableCell128";
            this.xrTableCell128.StylePriority.UseFont = false;
            this.xrTableCell128.StylePriority.UseForeColor = false;
            this.xrTableCell128.StylePriority.UseTextAlignment = false;
            this.xrTableCell128.Text = "xrTableCell4";
            this.xrTableCell128.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell128.Weight = 2.3963924593205168D;
            // 
            // xrTableRow34
            // 
            this.xrTableRow34.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell129});
            this.xrTableRow34.Name = "xrTableRow34";
            this.xrTableRow34.Weight = 0.18618992405363949D;
            // 
            // xrTableCell129
            // 
            this.xrTableCell129.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[U_SaleOfficeTel_EN]")});
            this.xrTableCell129.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.xrTableCell129.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell129.Multiline = true;
            this.xrTableCell129.Name = "xrTableCell129";
            this.xrTableCell129.StylePriority.UseFont = false;
            this.xrTableCell129.StylePriority.UseForeColor = false;
            this.xrTableCell129.StylePriority.UseTextAlignment = false;
            this.xrTableCell129.Text = "xrTableCell55";
            this.xrTableCell129.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell129.Weight = 2.3963924593205168D;
            // 
            // SubBand7
            // 
            this.SubBand7.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1});
            this.SubBand7.HeightF = 33.11632F;
            this.SubBand7.Name = "SubBand7";
            // 
            // xrLine1
            // 
            this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrLine1.LineWidth = 1.5F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(751.9999F, 23F);
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // SubBand5
            // 
            this.SubBand5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.SubBand5.HeightF = 120.529F;
            this.SubBand5.Name = "SubBand5";
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow17,
            this.xrTableRow60,
            this.xrTableRow5,
            this.xrTableRow6});
            this.xrTable1.SizeF = new System.Drawing.SizeF(751.9999F, 120.529F);
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell11,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.CanShrink = true;
            this.xrTableCell1.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.Text = "Invoice to";
            this.xrTableCell1.Weight = 1.188868172496643D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UseForeColor = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.Text = ":";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell11.Weight = 0.24675818566843877D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OVPM_CardName]")});
            this.xrTableCell3.Font = new DevExpress.Drawing.DXFont("CALIBRI", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell3.ForeColor = System.Drawing.Color.Maroon;
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseForeColor = false;
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.Weight = 10.298528851269602D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.xrTableCell13,
            this.xrTableCell4,
            this.xrTableCell17,
            this.xrTableCell21,
            this.xrTableCell25});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.CanShrink = true;
            this.xrTableCell2.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseForeColor = false;
            this.xrTableCell2.Text = "Code";
            this.xrTableCell2.Weight = 1.1888683150515786D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.StylePriority.UseForeColor = false;
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.Text = ":";
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell13.Weight = 0.24675747289376054D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OVPM_CardCode]")});
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.Weight = 7.487061886566595D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell17.Multiline = true;
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseFont = false;
            this.xrTableCell17.StylePriority.UseForeColor = false;
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            this.xrTableCell17.Text = "Invoice #";
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell17.Weight = 1.3520086852356328D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell21.Multiline = true;
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseFont = false;
            this.xrTableCell21.StylePriority.UseForeColor = false;
            this.xrTableCell21.StylePriority.UseTextAlignment = false;
            this.xrTableCell21.Text = ":";
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell21.Weight = 0.21082621650226832D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OVPM_DocNum]")});
            this.xrTableCell25.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell25.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell25.Multiline = true;
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.StylePriority.UseFont = false;
            this.xrTableCell25.StylePriority.UseForeColor = false;
            this.xrTableCell25.StylePriority.UseTextAlignment = false;
            this.xrTableCell25.Text = "xrTableCell25";
            this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell25.Weight = 1.248632633184847D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell14,
            this.xrTableCell6,
            this.xrTableCell23,
            this.xrTableCell30,
            this.xrTableCell29});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.CanShrink = true;
            this.xrTableCell5.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseForeColor = false;
            this.xrTableCell5.Text = "VAT/C.R #";
            this.xrTableCell5.Weight = 1.1888680299417074D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell14.Multiline = true;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.StylePriority.UseForeColor = false;
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            this.xrTableCell14.Text = ":";
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell14.Weight = 0.24675661756414663D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OCRD_LicTradNum]")});
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "xrTableCell6";
            this.xrTableCell6.Weight = 7.4870623029588046D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell23.Multiline = true;
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseForeColor = false;
            this.xrTableCell23.StylePriority.UseTextAlignment = false;
            this.xrTableCell23.Text = "Invoice Date";
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell23.Weight = 1.3520081064231606D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell30.Multiline = true;
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.StylePriority.UseForeColor = false;
            this.xrTableCell30.StylePriority.UseTextAlignment = false;
            this.xrTableCell30.Text = ":";
            this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell30.Weight = 0.21082733561514705D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OVPM_TaxDate]")});
            this.xrTableCell29.Multiline = true;
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.StylePriority.UseTextAlignment = false;
            this.xrTableCell29.Text = "xrTableCell29";
            this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell29.TextFormatString = "{0:dd-MMM-yy}";
            this.xrTableCell29.Weight = 1.2486328169317149D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell15,
            this.xrTableCell8,
            this.xrTableCell26});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.CanShrink = true;
            this.xrTableCell7.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UseForeColor = false;
            this.xrTableCell7.Text = "Phone";
            this.xrTableCell7.Weight = 1.188868172496643D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell15.Multiline = true;
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.StylePriority.UseForeColor = false;
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.Text = ":";
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell15.Weight = 0.24675590478946841D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OCRD_Phone2]")});
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "xrTableCell8";
            this.xrTableCell8.Weight = 7.4870655817223257D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell26.Multiline = true;
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.StylePriority.UseFont = false;
            this.xrTableCell26.StylePriority.UseForeColor = false;
            this.xrTableCell26.Text = "Contact Person :";
            this.xrTableCell26.Weight = 2.8114655504262456D;
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell86,
            this.xrTableCell87,
            this.xrTableCell88,
            this.xrTableCell27});
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.Weight = 1D;
            // 
            // xrTableCell86
            // 
            this.xrTableCell86.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell86.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell86.Multiline = true;
            this.xrTableCell86.Name = "xrTableCell86";
            this.xrTableCell86.StylePriority.UseFont = false;
            this.xrTableCell86.StylePriority.UseForeColor = false;
            this.xrTableCell86.Text = "City";
            this.xrTableCell86.Weight = 1.3152321416275088D;
            // 
            // xrTableCell87
            // 
            this.xrTableCell87.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell87.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell87.Multiline = true;
            this.xrTableCell87.Name = "xrTableCell87";
            this.xrTableCell87.StylePriority.UseFont = false;
            this.xrTableCell87.StylePriority.UseForeColor = false;
            this.xrTableCell87.StylePriority.UseTextAlignment = false;
            this.xrTableCell87.Text = ":";
            this.xrTableCell87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell87.Weight = 0.2729847413812917D;
            // 
            // xrTableCell88
            // 
            this.xrTableCell88.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OCRD_City]")});
            this.xrTableCell88.Multiline = true;
            this.xrTableCell88.Name = "xrTableCell88";
            this.xrTableCell88.Text = "xrTableCell88";
            this.xrTableCell88.Weight = 8.2828641845501352D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OSLP_SlpName] + \'\n\'+[OHEM_OfficeTel] +\'\n\'+[OHEM_Email]")});
            this.xrTableCell27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell27.Multiline = true;
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.RowSpan = 3;
            this.xrTableCell27.StylePriority.UseForeColor = false;
            this.xrTableCell27.Weight = 3.1102958956588775D;
            // 
            // xrTableRow60
            // 
            this.xrTableRow60.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell234,
            this.xrTableCell235,
            this.xrTableCell236,
            this.xrTableCell28});
            this.xrTableRow60.Name = "xrTableRow60";
            this.xrTableRow60.Weight = 1D;
            // 
            // xrTableCell234
            // 
            this.xrTableCell234.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell234.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell234.Multiline = true;
            this.xrTableCell234.Name = "xrTableCell234";
            this.xrTableCell234.StylePriority.UseFont = false;
            this.xrTableCell234.StylePriority.UseForeColor = false;
            this.xrTableCell234.Text = "Country";
            this.xrTableCell234.Weight = 1.3152321416275088D;
            // 
            // xrTableCell235
            // 
            this.xrTableCell235.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell235.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell235.Multiline = true;
            this.xrTableCell235.Name = "xrTableCell235";
            this.xrTableCell235.StylePriority.UseFont = false;
            this.xrTableCell235.StylePriority.UseForeColor = false;
            this.xrTableCell235.StylePriority.UseTextAlignment = false;
            this.xrTableCell235.Text = ":";
            this.xrTableCell235.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell235.Weight = 0.2729847413812917D;
            // 
            // xrTableCell236
            // 
            this.xrTableCell236.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OCRD_Country]")});
            this.xrTableCell236.Multiline = true;
            this.xrTableCell236.Name = "xrTableCell236";
            this.xrTableCell236.Text = "xrTableCell236";
            this.xrTableCell236.Weight = 8.28286092155121D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.Multiline = true;
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.Weight = 3.1102991586578028D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell12,
            this.xrTableCell24});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UseForeColor = false;
            this.xrTableCell9.Text = "Reference";
            this.xrTableCell9.Weight = 1.3152322993345891D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.StylePriority.UseForeColor = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.Text = ":";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell10.Weight = 0.27298647615917471D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OVPM_CounterRef]")});
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Text = "xrTableCell12";
            this.xrTableCell12.Weight = 8.2828583623992955D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.Multiline = true;
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.StylePriority.UseTextAlignment = false;
            this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell24.Weight = 3.1102998253247507D;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell18,
            this.xrTableCell19,
            this.xrTableCell22});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell18.Multiline = true;
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseFont = false;
            this.xrTableCell18.StylePriority.UseForeColor = false;
            this.xrTableCell18.Text = "Address";
            this.xrTableCell18.Weight = 1.3152322993345891D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTableCell19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell19.Multiline = true;
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseFont = false;
            this.xrTableCell19.StylePriority.UseForeColor = false;
            this.xrTableCell19.StylePriority.UseTextAlignment = false;
            this.xrTableCell19.Text = ":";
            this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell19.Weight = 0.27298647615917471D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Multiline = true;
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Weight = 11.393158187724048D;
            // 
            // SubBand6
            // 
            this.SubBand6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2});
            this.SubBand6.HeightF = 23F;
            this.SubBand6.Name = "SubBand6";
            // 
            // xrLine2
            // 
            this.xrLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrLine2.LineWidth = 1.5F;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(751.9999F, 23F);
            this.xrLine2.StylePriority.UseForeColor = false;
            // 
            // cf_BankSum
            // 
            this.cf_BankSum.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_BankSum.Expression = "Iif([OVPM_DocCurr] == [OADM_MainCurncy], [OVPM_TrsfrSum], [OVPM_TrsfrSumFC])";
            this.cf_BankSum.Name = "cf_BankSum";
            // 
            // cf_CashSum
            // 
            this.cf_CashSum.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_CashSum.Expression = "Iif([OVPM_DocCurr] == [OADM_MainCurncy], [OVPM_CashSum], [OVPM_CashSumFC])\n";
            this.cf_CashSum.Name = "cf_CashSum";
            // 
            // cf_TotalSum
            // 
            this.cf_TotalSum.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_TotalSum.Expression = "[cf_CheckSum] + [cf_BankSum] + [cf_CashSum] + [cf_CreditSum] + [OVPM_VatSum] + [c" +
    "f_DdctSum]";
            this.cf_TotalSum.Name = "cf_TotalSum";
            // 
            // cf_DdctSum
            // 
            this.cf_DdctSum.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_DdctSum.Expression = "Iif([OVPM_DocCurr] == [OADM_MainCurncy], [OVPM_DdctSum], [OVPM_DdctSumFC])";
            this.cf_DdctSum.Name = "cf_DdctSum";
            // 
            // cf_Remarks
            // 
            this.cf_Remarks.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_Remarks.Expression = resources.GetString("cf_Remarks.Expression");
            this.cf_Remarks.Name = "cf_Remarks";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrTable24,
            this.xrLine13,
            this.xrTable19});
            this.GroupFooter1.HeightF = 74.38417F;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand9,
            this.SubBand27});
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cf_Remarks]")});
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(14.45313F, 51.38417F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(691.5469F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrTable24
            // 
            this.xrTable24.LocationFloat = new DevExpress.Utils.PointFloat(0F, 34.1967F);
            this.xrTable24.Name = "xrTable24";
            this.xrTable24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable24.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow30});
            this.xrTable24.SizeF = new System.Drawing.SizeF(751.9999F, 17.1875F);
            // 
            // xrTableRow30
            // 
            this.xrTableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell123,
            this.xrTableCell124,
            this.xrTableCell125});
            this.xrTableRow30.Name = "xrTableRow30";
            this.xrTableRow30.Weight = 1D;
            // 
            // xrTableCell123
            // 
            this.xrTableCell123.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.xrTableCell123.Multiline = true;
            this.xrTableCell123.Name = "xrTableCell123";
            this.xrTableCell123.StylePriority.UseBackColor = false;
            this.xrTableCell123.Weight = 0.068348040580749475D;
            // 
            // xrTableCell124
            // 
            this.xrTableCell124.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell124.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell124.Multiline = true;
            this.xrTableCell124.Name = "xrTableCell124";
            this.xrTableCell124.StylePriority.UseFont = false;
            this.xrTableCell124.StylePriority.UseForeColor = false;
            this.xrTableCell124.StylePriority.UseTextAlignment = false;
            this.xrTableCell124.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell124.Weight = 0.076183255923368165D;
            // 
            // xrTableCell125
            // 
            this.xrTableCell125.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell125.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell125.Multiline = true;
            this.xrTableCell125.Name = "xrTableCell125";
            this.xrTableCell125.StylePriority.UseFont = false;
            this.xrTableCell125.StylePriority.UseForeColor = false;
            this.xrTableCell125.StylePriority.UseTextAlignment = false;
            this.xrTableCell125.Text = "Remarks";
            this.xrTableCell125.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell125.Weight = 6.9154669495035215D;
            // 
            // xrLine13
            // 
            this.xrLine13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrLine13.LocationFloat = new DevExpress.Utils.PointFloat(512.1641F, 29.09374F);
            this.xrLine13.Name = "xrLine13";
            this.xrLine13.SizeF = new System.Drawing.SizeF(237.8349F, 5.102949F);
            this.xrLine13.StylePriority.UseForeColor = false;
            // 
            // xrTable19
            // 
            this.xrTable19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable19.LocationFloat = new DevExpress.Utils.PointFloat(512.1639F, 10.00002F);
            this.xrTable19.Name = "xrTable19";
            this.xrTable19.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow25});
            this.xrTable19.SizeF = new System.Drawing.SizeF(237.8351F, 19.09375F);
            this.xrTable19.StylePriority.UseBorderColor = false;
            // 
            // xrTableRow25
            // 
            this.xrTableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell92,
            this.xrTableCell95,
            this.xrTableCell96});
            this.xrTableRow25.Name = "xrTableRow25";
            this.xrTableRow25.Weight = 1D;
            // 
            // xrTableCell92
            // 
            this.xrTableCell92.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.xrTableCell92.Multiline = true;
            this.xrTableCell92.Name = "xrTableCell92";
            this.xrTableCell92.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell92.StylePriority.UseBackColor = false;
            this.xrTableCell92.Weight = 8.3826607195987535D;
            // 
            // xrTableCell95
            // 
            this.xrTableCell95.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell95.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell95.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell95.Multiline = true;
            this.xrTableCell95.Name = "xrTableCell95";
            this.xrTableCell95.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell95.StylePriority.UseBorderColor = false;
            this.xrTableCell95.StylePriority.UseFont = false;
            this.xrTableCell95.StylePriority.UseForeColor = false;
            this.xrTableCell95.StylePriority.UseTextAlignment = false;
            this.xrTableCell95.Text = "Total Payment Amount :";
            this.xrTableCell95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell95.Weight = 103.73068873710926D;
            // 
            // xrTableCell96
            // 
            this.xrTableCell96.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell96.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[cf_TotalSum]")});
            this.xrTableCell96.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell96.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell96.Multiline = true;
            this.xrTableCell96.Name = "xrTableCell96";
            this.xrTableCell96.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell96.StylePriority.UseBorderColor = false;
            this.xrTableCell96.StylePriority.UseFont = false;
            this.xrTableCell96.StylePriority.UseForeColor = false;
            this.xrTableCell96.StylePriority.UseTextAlignment = false;
            this.xrTableCell96.Text = "xrTableCell62";
            this.xrTableCell96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell96.TextFormatString = "{0:N2}";
            this.xrTableCell96.Weight = 101.27973127430133D;
            // 
            // SubBand9
            // 
            this.SubBand9.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport1});
            this.SubBand9.HeightF = 135.3027F;
            this.SubBand9.Name = "SubBand9";
            // 
            // xrLine10
            // 
            this.xrLine10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrLine10.LineWidth = 1.5F;
            this.xrLine10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine10.Name = "xrLine10";
            this.xrLine10.SizeF = new System.Drawing.SizeF(749.9998F, 23F);
            this.xrLine10.StylePriority.UseForeColor = false;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.HeightF = 0F;
            this.GroupHeader2.Level = 4;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // GroupHeader3
            // 
            this.GroupHeader3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[cf_CreditSum] <> 0\n")});
            this.GroupHeader3.HeightF = 0F;
            this.GroupHeader3.Level = 3;
            this.GroupHeader3.Name = "GroupHeader3";
            // 
            // GroupHeader4
            // 
            this.GroupHeader4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[cf_CheckSum] <> 0\n")});
            this.GroupHeader4.HeightF = 0F;
            this.GroupHeader4.Level = 2;
            this.GroupHeader4.Name = "GroupHeader4";
            // 
            // GroupHeader5
            // 
            this.GroupHeader5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[cf_BankSum] <> 0\n")});
            this.GroupHeader5.HeightF = 0F;
            this.GroupHeader5.Level = 1;
            this.GroupHeader5.Name = "GroupHeader5";
            // 
            // GroupHeader6
            // 
            this.GroupHeader6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[cf_CashSum] <> 0")});
            this.GroupHeader6.HeightF = 0F;
            this.GroupHeader6.Name = "GroupHeader6";
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.GroupHeader7,
            this.GroupFooter4});
            this.DetailReport.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[cf_CreditSum] <> 0")});
            this.DetailReport.Level = 1;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6});
            this.Detail1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[cf_CreditSum] <> 0\n")});
            this.Detail1.HeightF = 23F;
            this.Detail1.Name = "Detail1";
            // 
            // xrTable6
            // 
            this.xrTable6.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(1.000135F, 0F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow11});
            this.xrTable6.SizeF = new System.Drawing.SizeF(751F, 23F);
            this.xrTable6.StylePriority.UseFont = false;
            this.xrTable6.StylePriority.UseTextAlignment = false;
            this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell50,
            this.xrTableCell51,
            this.xrTableCell52,
            this.xrTableCell53,
            this.xrTableCell54,
            this.xrTableCell55});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 1D;
            // 
            // xrTableCell50
            // 
            this.xrTableCell50.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OCRC_CardName]")});
            this.xrTableCell50.Multiline = true;
            this.xrTableCell50.Name = "xrTableCell50";
            this.xrTableCell50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell50.StylePriority.UseTextAlignment = false;
            this.xrTableCell50.Text = "xrLabel13";
            this.xrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell50.Weight = 199.10253723371275D;
            // 
            // xrTableCell51
            // 
            this.xrTableCell51.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VPM3_OwnerIdNum]")});
            this.xrTableCell51.Multiline = true;
            this.xrTableCell51.Name = "xrTableCell51";
            this.xrTableCell51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell51.StylePriority.UseTextAlignment = false;
            this.xrTableCell51.Text = "xrLabel14";
            this.xrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell51.Weight = 80.703895514311583D;
            // 
            // xrTableCell52
            // 
            this.xrTableCell52.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VPM3_NumOfPmnts]")});
            this.xrTableCell52.Multiline = true;
            this.xrTableCell52.Name = "xrTableCell52";
            this.xrTableCell52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell52.StylePriority.UseTextAlignment = false;
            this.xrTableCell52.Text = "xrLabel15";
            this.xrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell52.Weight = 104.26311324566048D;
            // 
            // xrTableCell53
            // 
            this.xrTableCell53.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VPM3_FirstSum]")});
            this.xrTableCell53.Multiline = true;
            this.xrTableCell53.Name = "xrTableCell53";
            this.xrTableCell53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell53.StylePriority.UseTextAlignment = false;
            this.xrTableCell53.Text = "xrLabel16";
            this.xrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell53.Weight = 104.26297182981477D;
            // 
            // xrTableCell54
            // 
            this.xrTableCell54.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VPM3_AddPmntSum]")});
            this.xrTableCell54.Multiline = true;
            this.xrTableCell54.Name = "xrTableCell54";
            this.xrTableCell54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell54.StylePriority.UseTextAlignment = false;
            this.xrTableCell54.Text = "xrLabel17";
            this.xrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell54.Weight = 104.26314112933393D;
            // 
            // xrTableCell55
            // 
            this.xrTableCell55.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VPM3_CreditSum]")});
            this.xrTableCell55.Multiline = true;
            this.xrTableCell55.Name = "xrTableCell55";
            this.xrTableCell55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell55.StylePriority.UseTextAlignment = false;
            this.xrTableCell55.Text = "xrLabel18";
            this.xrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell55.Weight = 104.26307192743695D;
            // 
            // GroupHeader7
            // 
            this.GroupHeader7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[cf_CreditSum] <> 0\n")});
            this.GroupHeader7.HeightF = 0F;
            this.GroupHeader7.Name = "GroupHeader7";
            this.GroupHeader7.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand11,
            this.SubBand17});
            // 
            // SubBand11
            // 
            this.SubBand11.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable14});
            this.SubBand11.HeightF = 37.9752F;
            this.SubBand11.Name = "SubBand11";
            // 
            // xrTable14
            // 
            this.xrTable14.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.xrTable14.Name = "xrTable14";
            this.xrTable14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable14.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow20});
            this.xrTable14.SizeF = new System.Drawing.SizeF(751.9992F, 17.1875F);
            // 
            // xrTableRow20
            // 
            this.xrTableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell102,
            this.xrTableCell103,
            this.xrTableCell104});
            this.xrTableRow20.Name = "xrTableRow20";
            this.xrTableRow20.Weight = 1D;
            // 
            // xrTableCell102
            // 
            this.xrTableCell102.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.xrTableCell102.Multiline = true;
            this.xrTableCell102.Name = "xrTableCell102";
            this.xrTableCell102.StylePriority.UseBackColor = false;
            this.xrTableCell102.Weight = 0.068348040580749475D;
            // 
            // xrTableCell103
            // 
            this.xrTableCell103.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell103.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell103.Multiline = true;
            this.xrTableCell103.Name = "xrTableCell103";
            this.xrTableCell103.StylePriority.UseFont = false;
            this.xrTableCell103.StylePriority.UseForeColor = false;
            this.xrTableCell103.StylePriority.UseTextAlignment = false;
            this.xrTableCell103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell103.Weight = 0.076183255923368165D;
            // 
            // xrTableCell104
            // 
            this.xrTableCell104.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell104.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell104.Multiline = true;
            this.xrTableCell104.Name = "xrTableCell104";
            this.xrTableCell104.StylePriority.UseFont = false;
            this.xrTableCell104.StylePriority.UseForeColor = false;
            this.xrTableCell104.StylePriority.UseTextAlignment = false;
            this.xrTableCell104.Text = "Credit Card";
            this.xrTableCell104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell104.Weight = 7.37546085100889D;
            // 
            // SubBand17
            // 
            this.SubBand17.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable7});
            this.SubBand17.HeightF = 23F;
            this.SubBand17.Name = "SubBand17";
            // 
            // xrTable7
            // 
            this.xrTable7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.xrTable7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable7.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable7.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTable7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(0.9999642F, 0F);
            this.xrTable7.Name = "xrTable7";
            this.xrTable7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow12});
            this.xrTable7.SizeF = new System.Drawing.SizeF(751F, 23F);
            this.xrTable7.StylePriority.UseBackColor = false;
            this.xrTable7.StylePriority.UseBorderColor = false;
            this.xrTable7.StylePriority.UseBorders = false;
            this.xrTable7.StylePriority.UseFont = false;
            this.xrTable7.StylePriority.UseForeColor = false;
            this.xrTable7.StylePriority.UseTextAlignment = false;
            this.xrTable7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell56,
            this.xrTableCell57,
            this.xrTableCell58,
            this.xrTableCell59,
            this.xrTableCell60,
            this.xrTableCell61});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 1D;
            // 
            // xrTableCell56
            // 
            this.xrTableCell56.Multiline = true;
            this.xrTableCell56.Name = "xrTableCell56";
            this.xrTableCell56.Text = "Card Name";
            this.xrTableCell56.Weight = 2.2025263727796274D;
            // 
            // xrTableCell57
            // 
            this.xrTableCell57.Multiline = true;
            this.xrTableCell57.Name = "xrTableCell57";
            this.xrTableCell57.Text = "ID Number";
            this.xrTableCell57.Weight = 0.8927705072298936D;
            // 
            // xrTableCell58
            // 
            this.xrTableCell58.Multiline = true;
            this.xrTableCell58.Name = "xrTableCell58";
            this.xrTableCell58.Text = "No. of Payments";
            this.xrTableCell58.Weight = 1.1533867677315122D;
            // 
            // xrTableCell59
            // 
            this.xrTableCell59.Multiline = true;
            this.xrTableCell59.Name = "xrTableCell59";
            this.xrTableCell59.Text = "1st Payment";
            this.xrTableCell59.Weight = 1.153386197482817D;
            // 
            // xrTableCell60
            // 
            this.xrTableCell60.Multiline = true;
            this.xrTableCell60.Name = "xrTableCell60";
            this.xrTableCell60.Text = "Payment";
            this.xrTableCell60.Weight = 1.1533862070252836D;
            // 
            // xrTableCell61
            // 
            this.xrTableCell61.Multiline = true;
            this.xrTableCell61.Name = "xrTableCell61";
            this.xrTableCell61.StylePriority.UseTextAlignment = false;
            this.xrTableCell61.Text = "Amount";
            this.xrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell61.Weight = 1.1533851081469555D;
            // 
            // GroupFooter4
            // 
            this.GroupFooter4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable23,
            this.xrLine11});
            this.GroupFooter4.HeightF = 34.19669F;
            this.GroupFooter4.Name = "GroupFooter4";
            this.GroupFooter4.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand26});
            // 
            // xrTable23
            // 
            this.xrTable23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable23.LocationFloat = new DevExpress.Utils.PointFloat(514.1643F, 9.99999F);
            this.xrTable23.Name = "xrTable23";
            this.xrTable23.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow29});
            this.xrTable23.SizeF = new System.Drawing.SizeF(236.8348F, 19.09375F);
            this.xrTable23.StylePriority.UseBorderColor = false;
            // 
            // xrTableRow29
            // 
            this.xrTableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell120,
            this.xrTableCell121,
            this.xrTableCell122});
            this.xrTableRow29.Name = "xrTableRow29";
            this.xrTableRow29.Weight = 1D;
            // 
            // xrTableCell120
            // 
            this.xrTableCell120.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.xrTableCell120.Multiline = true;
            this.xrTableCell120.Name = "xrTableCell120";
            this.xrTableCell120.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell120.StylePriority.UseBackColor = false;
            this.xrTableCell120.Weight = 8.3826607195987535D;
            // 
            // xrTableCell121
            // 
            this.xrTableCell121.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell121.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell121.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell121.Multiline = true;
            this.xrTableCell121.Name = "xrTableCell121";
            this.xrTableCell121.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell121.StylePriority.UseBorderColor = false;
            this.xrTableCell121.StylePriority.UseFont = false;
            this.xrTableCell121.StylePriority.UseForeColor = false;
            this.xrTableCell121.StylePriority.UseTextAlignment = false;
            this.xrTableCell121.Text = "Credit Total :";
            this.xrTableCell121.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell121.Weight = 103.73068873710926D;
            // 
            // xrTableCell122
            // 
            this.xrTableCell122.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell122.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[cf_CreditSum]")});
            this.xrTableCell122.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell122.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell122.Multiline = true;
            this.xrTableCell122.Name = "xrTableCell122";
            this.xrTableCell122.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell122.StylePriority.UseBorderColor = false;
            this.xrTableCell122.StylePriority.UseFont = false;
            this.xrTableCell122.StylePriority.UseForeColor = false;
            this.xrTableCell122.StylePriority.UseTextAlignment = false;
            this.xrTableCell122.Text = "xrTableCell62";
            this.xrTableCell122.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell122.TextFormatString = "{0:N2}";
            this.xrTableCell122.Weight = 101.27973127430133D;
            // 
            // xrLine11
            // 
            this.xrLine11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrLine11.LocationFloat = new DevExpress.Utils.PointFloat(514.1643F, 29.09374F);
            this.xrLine11.Name = "xrLine11";
            this.xrLine11.SizeF = new System.Drawing.SizeF(237.8349F, 5.102949F);
            this.xrLine11.StylePriority.UseForeColor = false;
            // 
            // SubBand26
            // 
            this.SubBand26.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine12});
            this.SubBand26.HeightF = 23F;
            this.SubBand26.Name = "SubBand26";
            this.SubBand26.Visible = false;
            // 
            // xrLine12
            // 
            this.xrLine12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrLine12.LineWidth = 1.5F;
            this.xrLine12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine12.Name = "xrLine12";
            this.xrLine12.SizeF = new System.Drawing.SizeF(752.0002F, 23F);
            this.xrLine12.StylePriority.UseForeColor = false;
            // 
            // DetailReport1
            // 
            this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2,
            this.GroupHeader8,
            this.GroupFooter3});
            this.DetailReport1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[cf_CheckSum] <> 0")});
            this.DetailReport1.Level = 2;
            this.DetailReport1.Name = "DetailReport1";
            // 
            // Detail2
            // 
            this.Detail2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable9});
            this.Detail2.HeightF = 16F;
            this.Detail2.Name = "Detail2";
            // 
            // xrTable9
            // 
            this.xrTable9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrTable9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable9.BorderWidth = 0.5F;
            this.xrTable9.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTable9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable9.Name = "xrTable9";
            this.xrTable9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow14});
            this.xrTable9.SizeF = new System.Drawing.SizeF(752.0002F, 16F);
            this.xrTable9.StylePriority.UseBorderColor = false;
            this.xrTable9.StylePriority.UseBorderDashStyle = false;
            this.xrTable9.StylePriority.UseBorders = false;
            this.xrTable9.StylePriority.UseBorderWidth = false;
            this.xrTable9.StylePriority.UseFont = false;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell71,
            this.xrTableCell72,
            this.xrTableCell73,
            this.xrTableCell74,
            this.xrTableCell75,
            this.xrTableCell76});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 1D;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[VPM1_DueDate]")});
            this.xrTableCell71.Multiline = true;
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell71.Text = "xrLabel19";
            this.xrTableCell71.TextFormatString = "{0:dd-MMM-yy}";
            this.xrTableCell71.Weight = 112.51075467105005D;
            // 
            // xrTableCell72
            // 
            this.xrTableCell72.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[VPM1_CheckNum]")});
            this.xrTableCell72.Multiline = true;
            this.xrTableCell72.Name = "xrTableCell72";
            this.xrTableCell72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell72.StylePriority.UseTextAlignment = false;
            this.xrTableCell72.Text = "xrLabel20";
            this.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell72.Weight = 97.17397227786411D;
            // 
            // xrTableCell73
            // 
            this.xrTableCell73.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[ODSC_BankName]")});
            this.xrTableCell73.Multiline = true;
            this.xrTableCell73.Name = "xrTableCell73";
            this.xrTableCell73.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell73.Text = "xrLabel24";
            this.xrTableCell73.Weight = 122.54536162682651D;
            // 
            // xrTableCell74
            // 
            this.xrTableCell74.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[VPM1_Branch]")});
            this.xrTableCell74.Multiline = true;
            this.xrTableCell74.Name = "xrTableCell74";
            this.xrTableCell74.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell74.Text = "xrLabel21";
            this.xrTableCell74.Weight = 123.24315129777362D;
            // 
            // xrTableCell75
            // 
            this.xrTableCell75.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[VPM1_AcctNum]")});
            this.xrTableCell75.Multiline = true;
            this.xrTableCell75.Name = "xrTableCell75";
            this.xrTableCell75.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell75.Text = "xrLabel22";
            this.xrTableCell75.Weight = 171.26356382521755D;
            // 
            // xrTableCell76
            // 
            this.xrTableCell76.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[VPM1_CheckSum]")});
            this.xrTableCell76.Multiline = true;
            this.xrTableCell76.Name = "xrTableCell76";
            this.xrTableCell76.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell76.Text = "xrLabel23";
            this.xrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell76.TextFormatString = "{0:N2}";
            this.xrTableCell76.Weight = 104.26287926736667D;
            // 
            // GroupHeader8
            // 
            this.GroupHeader8.HeightF = 0F;
            this.GroupHeader8.Name = "GroupHeader8";
            this.GroupHeader8.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand12,
            this.SubBand16});
            // 
            // SubBand12
            // 
            this.SubBand12.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable15});
            this.SubBand12.HeightF = 24.41144F;
            this.SubBand12.Name = "SubBand12";
            // 
            // xrTable15
            // 
            this.xrTable15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable15.Name = "xrTable15";
            this.xrTable15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable15.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow21});
            this.xrTable15.SizeF = new System.Drawing.SizeF(752.0002F, 17.1875F);
            // 
            // xrTableRow21
            // 
            this.xrTableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell105,
            this.xrTableCell106,
            this.xrTableCell107});
            this.xrTableRow21.Name = "xrTableRow21";
            this.xrTableRow21.Weight = 1D;
            // 
            // xrTableCell105
            // 
            this.xrTableCell105.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.xrTableCell105.Multiline = true;
            this.xrTableCell105.Name = "xrTableCell105";
            this.xrTableCell105.StylePriority.UseBackColor = false;
            this.xrTableCell105.Weight = 0.068348040580749475D;
            // 
            // xrTableCell106
            // 
            this.xrTableCell106.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell106.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell106.Multiline = true;
            this.xrTableCell106.Name = "xrTableCell106";
            this.xrTableCell106.StylePriority.UseFont = false;
            this.xrTableCell106.StylePriority.UseForeColor = false;
            this.xrTableCell106.StylePriority.UseTextAlignment = false;
            this.xrTableCell106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell106.Weight = 0.076183255923368165D;
            // 
            // xrTableCell107
            // 
            this.xrTableCell107.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell107.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell107.Multiline = true;
            this.xrTableCell107.Name = "xrTableCell107";
            this.xrTableCell107.StylePriority.UseFont = false;
            this.xrTableCell107.StylePriority.UseForeColor = false;
            this.xrTableCell107.StylePriority.UseTextAlignment = false;
            this.xrTableCell107.Text = "Cheque";
            this.xrTableCell107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell107.Weight = 7.3754706166339972D;
            // 
            // SubBand16
            // 
            this.SubBand16.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable8});
            this.SubBand16.HeightF = 23F;
            this.SubBand16.Name = "SubBand16";
            // 
            // xrTable8
            // 
            this.xrTable8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.xrTable8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable8.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable8.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTable8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable8.Name = "xrTable8";
            this.xrTable8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow13});
            this.xrTable8.SizeF = new System.Drawing.SizeF(752.0002F, 23F);
            this.xrTable8.StylePriority.UseBackColor = false;
            this.xrTable8.StylePriority.UseBorderColor = false;
            this.xrTable8.StylePriority.UseBorders = false;
            this.xrTable8.StylePriority.UseFont = false;
            this.xrTable8.StylePriority.UseForeColor = false;
            this.xrTable8.StylePriority.UseTextAlignment = false;
            this.xrTable8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell65,
            this.xrTableCell66,
            this.xrTableCell67,
            this.xrTableCell68,
            this.xrTableCell69,
            this.xrTableCell70});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 1D;
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.Multiline = true;
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.Text = "Date";
            this.xrTableCell65.Weight = 1.1883783359759454D;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.Multiline = true;
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.Text = "Cheque";
            this.xrTableCell66.Weight = 1.0263868507787735D;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.Multiline = true;
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.Text = "Bank";
            this.xrTableCell67.Weight = 1.2943628636329372D;
            // 
            // xrTableCell68
            // 
            this.xrTableCell68.Multiline = true;
            this.xrTableCell68.Name = "xrTableCell68";
            this.xrTableCell68.Text = "Branch";
            this.xrTableCell68.Weight = 1.3017377294342838D;
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.Multiline = true;
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.Text = "Account\t";
            this.xrTableCell69.Weight = 1.808949362681624D;
            // 
            // xrTableCell70
            // 
            this.xrTableCell70.Multiline = true;
            this.xrTableCell70.Name = "xrTableCell70";
            this.xrTableCell70.StylePriority.UseTextAlignment = false;
            this.xrTableCell70.Text = "Amount";
            this.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell70.Weight = 1.1012622731099466D;
            // 
            // GroupFooter3
            // 
            this.GroupFooter3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine4,
            this.xrTable18});
            this.GroupFooter3.HeightF = 34.19669F;
            this.GroupFooter3.Name = "GroupFooter3";
            this.GroupFooter3.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand25});
            // 
            // xrLine4
            // 
            this.xrLine4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(513.1642F, 29.09374F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(237.8349F, 5.102949F);
            this.xrLine4.StylePriority.UseForeColor = false;
            // 
            // xrTable18
            // 
            this.xrTable18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable18.LocationFloat = new DevExpress.Utils.PointFloat(513.1642F, 9.99999F);
            this.xrTable18.Name = "xrTable18";
            this.xrTable18.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow24});
            this.xrTable18.SizeF = new System.Drawing.SizeF(236.8348F, 19.09375F);
            this.xrTable18.StylePriority.UseBorderColor = false;
            // 
            // xrTableRow24
            // 
            this.xrTableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell63,
            this.xrTableCell64,
            this.xrTableCell77});
            this.xrTableRow24.Name = "xrTableRow24";
            this.xrTableRow24.Weight = 1D;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.xrTableCell63.Multiline = true;
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell63.StylePriority.UseBackColor = false;
            this.xrTableCell63.Weight = 8.3826607195987535D;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell64.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell64.Multiline = true;
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell64.StylePriority.UseBorderColor = false;
            this.xrTableCell64.StylePriority.UseFont = false;
            this.xrTableCell64.StylePriority.UseForeColor = false;
            this.xrTableCell64.StylePriority.UseTextAlignment = false;
            this.xrTableCell64.Text = "Cheque Total :";
            this.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell64.Weight = 103.73068873710926D;
            // 
            // xrTableCell77
            // 
            this.xrTableCell77.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell77.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[cf_SubTotal]")});
            this.xrTableCell77.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell77.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell77.Multiline = true;
            this.xrTableCell77.Name = "xrTableCell77";
            this.xrTableCell77.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell77.StylePriority.UseBorderColor = false;
            this.xrTableCell77.StylePriority.UseFont = false;
            this.xrTableCell77.StylePriority.UseForeColor = false;
            this.xrTableCell77.StylePriority.UseTextAlignment = false;
            this.xrTableCell77.Text = "xrTableCell62";
            this.xrTableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell77.TextFormatString = "{0:N2}";
            this.xrTableCell77.Weight = 101.27973127430133D;
            // 
            // SubBand25
            // 
            this.SubBand25.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine9});
            this.SubBand25.HeightF = 23F;
            this.SubBand25.Name = "SubBand25";
            // 
            // xrLine9
            // 
            this.xrLine9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrLine9.LineWidth = 1.5F;
            this.xrLine9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine9.Name = "xrLine9";
            this.xrLine9.SizeF = new System.Drawing.SizeF(750.9992F, 23F);
            this.xrLine9.StylePriority.UseForeColor = false;
            // 
            // DetailReport2
            // 
            this.DetailReport2.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail3,
            this.GroupHeader9});
            this.DetailReport2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[cf_BankSum] <> 0")});
            this.DetailReport2.Level = 3;
            this.DetailReport2.Name = "DetailReport2";
            // 
            // Detail3
            // 
            this.Detail3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable11});
            this.Detail3.HeightF = 23F;
            this.Detail3.Name = "Detail3";
            // 
            // xrTable11
            // 
            this.xrTable11.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTable11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable11.Name = "xrTable11";
            this.xrTable11.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow16});
            this.xrTable11.SizeF = new System.Drawing.SizeF(751F, 23F);
            this.xrTable11.StylePriority.UseFont = false;
            this.xrTable11.StylePriority.UseTextAlignment = false;
            this.xrTable11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell85,
            this.xrTableCell89,
            this.xrTableCell90,
            this.xrTableCell91});
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.Weight = 1D;
            // 
            // xrTableCell85
            // 
            this.xrTableCell85.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OACT_AcctName]")});
            this.xrTableCell85.Multiline = true;
            this.xrTableCell85.Name = "xrTableCell85";
            this.xrTableCell85.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTableCell85.Text = "xrLabel25";
            this.xrTableCell85.Weight = 181.00002386910592D;
            // 
            // xrTableCell89
            // 
            this.xrTableCell89.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OVPM_TrsfrDate]")});
            this.xrTableCell89.Multiline = true;
            this.xrTableCell89.Name = "xrTableCell89";
            this.xrTableCell89.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTableCell89.Text = "xrLabel27";
            this.xrTableCell89.TextFormatString = "{0:d}";
            this.xrTableCell89.Weight = 179.00004552205093D;
            // 
            // xrTableCell90
            // 
            this.xrTableCell90.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OVPM_TrsfrRef]")});
            this.xrTableCell90.Multiline = true;
            this.xrTableCell90.Name = "xrTableCell90";
            this.xrTableCell90.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTableCell90.Text = "xrLabel26";
            this.xrTableCell90.Weight = 182.00006202818929D;
            // 
            // xrTableCell91
            // 
            this.xrTableCell91.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cf_BankSum]")});
            this.xrTableCell91.Multiline = true;
            this.xrTableCell91.Name = "xrTableCell91";
            this.xrTableCell91.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTableCell91.Text = "xrLabel28";
            this.xrTableCell91.Weight = 87.999876210048427D;
            // 
            // GroupHeader9
            // 
            this.GroupHeader9.HeightF = 23F;
            this.GroupHeader9.Name = "GroupHeader9";
            this.GroupHeader9.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand13,
            this.SubBand15});
            // 
            // SubBand13
            // 
            this.SubBand13.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable16});
            this.SubBand13.HeightF = 46.60924F;
            this.SubBand13.Name = "SubBand13";
            // 
            // xrTable16
            // 
            this.xrTable16.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23F);
            this.xrTable16.Name = "xrTable16";
            this.xrTable16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable16.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow22});
            this.xrTable16.SizeF = new System.Drawing.SizeF(751.9992F, 17.1875F);
            // 
            // xrTableRow22
            // 
            this.xrTableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell108,
            this.xrTableCell109,
            this.xrTableCell110});
            this.xrTableRow22.Name = "xrTableRow22";
            this.xrTableRow22.Weight = 1D;
            // 
            // xrTableCell108
            // 
            this.xrTableCell108.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.xrTableCell108.Multiline = true;
            this.xrTableCell108.Name = "xrTableCell108";
            this.xrTableCell108.StylePriority.UseBackColor = false;
            this.xrTableCell108.Weight = 0.068348040580749475D;
            // 
            // xrTableCell109
            // 
            this.xrTableCell109.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell109.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell109.Multiline = true;
            this.xrTableCell109.Name = "xrTableCell109";
            this.xrTableCell109.StylePriority.UseFont = false;
            this.xrTableCell109.StylePriority.UseForeColor = false;
            this.xrTableCell109.StylePriority.UseTextAlignment = false;
            this.xrTableCell109.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell109.Weight = 0.076183255923368165D;
            // 
            // xrTableCell110
            // 
            this.xrTableCell110.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell110.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell110.Multiline = true;
            this.xrTableCell110.Name = "xrTableCell110";
            this.xrTableCell110.StylePriority.UseFont = false;
            this.xrTableCell110.StylePriority.UseForeColor = false;
            this.xrTableCell110.StylePriority.UseTextAlignment = false;
            this.xrTableCell110.Text = "Bank Transfer";
            this.xrTableCell110.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell110.Weight = 7.37546085100889D;
            // 
            // SubBand15
            // 
            this.SubBand15.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable10});
            this.SubBand15.HeightF = 23F;
            this.SubBand15.Name = "SubBand15";
            // 
            // xrTable10
            // 
            this.xrTable10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.xrTable10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable10.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable10.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTable10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable10.Name = "xrTable10";
            this.xrTable10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow15});
            this.xrTable10.SizeF = new System.Drawing.SizeF(752.0002F, 23F);
            this.xrTable10.StylePriority.UseBackColor = false;
            this.xrTable10.StylePriority.UseBorderColor = false;
            this.xrTable10.StylePriority.UseBorders = false;
            this.xrTable10.StylePriority.UseFont = false;
            this.xrTable10.StylePriority.UseForeColor = false;
            this.xrTable10.StylePriority.UseTextAlignment = false;
            this.xrTable10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell78,
            this.xrTableCell79,
            this.xrTableCell80,
            this.xrTableCell81,
            this.xrTableCell84});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1D;
            // 
            // xrTableCell78
            // 
            this.xrTableCell78.Multiline = true;
            this.xrTableCell78.Name = "xrTableCell78";
            this.xrTableCell78.Text = "#";
            this.xrTableCell78.Weight = 0.36061192040177681D;
            // 
            // xrTableCell79
            // 
            this.xrTableCell79.Multiline = true;
            this.xrTableCell79.Name = "xrTableCell79";
            this.xrTableCell79.Text = "Accunt Name";
            this.xrTableCell79.Weight = 1.8541504628600789D;
            // 
            // xrTableCell80
            // 
            this.xrTableCell80.Multiline = true;
            this.xrTableCell80.Name = "xrTableCell80";
            this.xrTableCell80.Text = "Transfer Date";
            this.xrTableCell80.Weight = 2.2025258410268691D;
            // 
            // xrTableCell81
            // 
            this.xrTableCell81.Multiline = true;
            this.xrTableCell81.Name = "xrTableCell81";
            this.xrTableCell81.Text = "Reference";
            this.xrTableCell81.Weight = 2.2147641825668654D;
            // 
            // xrTableCell84
            // 
            this.xrTableCell84.Multiline = true;
            this.xrTableCell84.Name = "xrTableCell84";
            this.xrTableCell84.StylePriority.UseTextAlignment = false;
            this.xrTableCell84.Text = "Amount";
            this.xrTableCell84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell84.Weight = 1.0890267637284605D;
            // 
            // DetailReport3
            // 
            this.DetailReport3.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail4,
            this.GroupHeader10});
            this.DetailReport3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[cf_CashSum] <> 0\n")});
            this.DetailReport3.Level = 4;
            this.DetailReport3.Name = "DetailReport3";
            // 
            // Detail4
            // 
            this.Detail4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable13});
            this.Detail4.HeightF = 23F;
            this.Detail4.Name = "Detail4";
            // 
            // xrTable13
            // 
            this.xrTable13.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTable13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable13.Name = "xrTable13";
            this.xrTable13.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow19});
            this.xrTable13.SizeF = new System.Drawing.SizeF(752.0002F, 23F);
            this.xrTable13.StylePriority.UseFont = false;
            this.xrTable13.StylePriority.UseForeColor = false;
            this.xrTable13.StylePriority.UseTextAlignment = false;
            this.xrTable13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow19
            // 
            this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell99,
            this.xrTableCell100,
            this.xrTableCell101});
            this.xrTableRow19.Name = "xrTableRow19";
            this.xrTableRow19.Weight = 1D;
            // 
            // xrTableCell99
            // 
            this.xrTableCell99.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OVPM_CashAcct]")});
            this.xrTableCell99.Multiline = true;
            this.xrTableCell99.Name = "xrTableCell99";
            this.xrTableCell99.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTableCell99.Text = "xrLabel29";
            this.xrTableCell99.Weight = 181.00014593786517D;
            // 
            // xrTableCell100
            // 
            this.xrTableCell100.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OACT_AcctName]")});
            this.xrTableCell100.Multiline = true;
            this.xrTableCell100.Name = "xrTableCell100";
            this.xrTableCell100.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTableCell100.Text = "xrLabel30";
            this.xrTableCell100.Weight = 179.99989220910749D;
            // 
            // xrTableCell101
            // 
            this.xrTableCell101.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cf_CashSum]")});
            this.xrTableCell101.Multiline = true;
            this.xrTableCell101.Name = "xrTableCell101";
            this.xrTableCell101.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTableCell101.Text = "xrLabel31";
            this.xrTableCell101.Weight = 270.00009155273438D;
            // 
            // GroupHeader10
            // 
            this.GroupHeader10.HeightF = 0F;
            this.GroupHeader10.Name = "GroupHeader10";
            this.GroupHeader10.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand14,
            this.SubBand18});
            // 
            // SubBand14
            // 
            this.SubBand14.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable17});
            this.SubBand14.HeightF = 46.28513F;
            this.SubBand14.Name = "SubBand14";
            // 
            // xrTable17
            // 
            this.xrTable17.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23.00008F);
            this.xrTable17.Name = "xrTable17";
            this.xrTable17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable17.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow23});
            this.xrTable17.SizeF = new System.Drawing.SizeF(752.0001F, 17.1875F);
            // 
            // xrTableRow23
            // 
            this.xrTableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell82,
            this.xrTableCell83,
            this.xrTableCell111});
            this.xrTableRow23.Name = "xrTableRow23";
            this.xrTableRow23.Weight = 1D;
            // 
            // xrTableCell82
            // 
            this.xrTableCell82.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.xrTableCell82.Multiline = true;
            this.xrTableCell82.Name = "xrTableCell82";
            this.xrTableCell82.StylePriority.UseBackColor = false;
            this.xrTableCell82.Weight = 0.068348040580749475D;
            // 
            // xrTableCell83
            // 
            this.xrTableCell83.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell83.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell83.Multiline = true;
            this.xrTableCell83.Name = "xrTableCell83";
            this.xrTableCell83.StylePriority.UseFont = false;
            this.xrTableCell83.StylePriority.UseForeColor = false;
            this.xrTableCell83.StylePriority.UseTextAlignment = false;
            this.xrTableCell83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell83.Weight = 0.076183255923368165D;
            // 
            // xrTableCell111
            // 
            this.xrTableCell111.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell111.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell111.Multiline = true;
            this.xrTableCell111.Name = "xrTableCell111";
            this.xrTableCell111.StylePriority.UseFont = false;
            this.xrTableCell111.StylePriority.UseForeColor = false;
            this.xrTableCell111.StylePriority.UseTextAlignment = false;
            this.xrTableCell111.Text = "Cash";
            this.xrTableCell111.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell111.Weight = 6.1654693827232894D;
            // 
            // SubBand18
            // 
            this.SubBand18.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable12});
            this.SubBand18.HeightF = 23F;
            this.SubBand18.Name = "SubBand18";
            // 
            // xrTable12
            // 
            this.xrTable12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.xrTable12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable12.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable12.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTable12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable12.Name = "xrTable12";
            this.xrTable12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable12.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow18});
            this.xrTable12.SizeF = new System.Drawing.SizeF(752.0002F, 23F);
            this.xrTable12.StylePriority.UseBackColor = false;
            this.xrTable12.StylePriority.UseBorderColor = false;
            this.xrTable12.StylePriority.UseBorders = false;
            this.xrTable12.StylePriority.UseFont = false;
            this.xrTable12.StylePriority.UseForeColor = false;
            this.xrTable12.StylePriority.UseTextAlignment = false;
            this.xrTable12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow18
            // 
            this.xrTableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell93,
            this.xrTableCell94,
            this.xrTableCell98});
            this.xrTableRow18.Name = "xrTableRow18";
            this.xrTableRow18.Weight = 1D;
            // 
            // xrTableCell93
            // 
            this.xrTableCell93.Multiline = true;
            this.xrTableCell93.Name = "xrTableCell93";
            this.xrTableCell93.Text = "G/L Account";
            this.xrTableCell93.Weight = 2.1113234616270526D;
            // 
            // xrTableCell94
            // 
            this.xrTableCell94.Multiline = true;
            this.xrTableCell94.Name = "xrTableCell94";
            this.xrTableCell94.Text = "Account Name";
            this.xrTableCell94.Weight = 2.0996583937487414D;
            // 
            // xrTableCell98
            // 
            this.xrTableCell98.Multiline = true;
            this.xrTableCell98.Name = "xrTableCell98";
            this.xrTableCell98.StylePriority.UseTextAlignment = false;
            this.xrTableCell98.Text = "Amount";
            this.xrTableCell98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell98.Weight = 3.1494851096995844D;
            // 
            // DetailReport4
            // 
            this.DetailReport4.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail5,
            this.GroupHeader11,
            this.GroupFooter2});
            this.DetailReport4.Level = 0;
            this.DetailReport4.Name = "DetailReport4";
            // 
            // Detail5
            // 
            this.Detail5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4});
            this.Detail5.HeightF = 16.48958F;
            this.Detail5.Name = "Detail5";
            // 
            // xrTable4
            // 
            this.xrTable4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrTable4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable4.BorderWidth = 0.5F;
            this.xrTable4.Font = new DevExpress.Drawing.DXFont("calibri", 8F);
            this.xrTable4.ForeColor = System.Drawing.Color.Black;
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(1.000013F, 0F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9});
            this.xrTable4.SizeF = new System.Drawing.SizeF(750.9999F, 16F);
            this.xrTable4.StylePriority.UseBorderColor = false;
            this.xrTable4.StylePriority.UseBorderDashStyle = false;
            this.xrTable4.StylePriority.UseBorders = false;
            this.xrTable4.StylePriority.UseBorderWidth = false;
            this.xrTable4.StylePriority.UseFont = false;
            this.xrTable4.StylePriority.UseForeColor = false;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell46,
            this.xrTableCell40,
            this.xrTableCell41,
            this.xrTableCell42,
            this.xrTableCell43,
            this.xrTableCell44,
            this.xrTableCell45});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 12058624D;
            // 
            // xrTableCell46
            // 
            this.xrTableCell46.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")});
            this.xrTableCell46.Multiline = true;
            this.xrTableCell46.Name = "xrTableCell46";
            this.xrTableCell46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell46.Summary = xrSummary1;
            this.xrTableCell46.Text = "xrTableCell46";
            this.xrTableCell46.Weight = 33.941612916277904D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[VPM2_InvType_Name]")});
            this.xrTableCell40.Multiline = true;
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell40.Text = "xrLabel4";
            this.xrTableCell40.Weight = 180.64651530031631D;
            // 
            // xrTableCell41
            // 
            this.xrTableCell41.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[cf_DocumentNumber]")});
            this.xrTableCell41.Multiline = true;
            this.xrTableCell41.Name = "xrTableCell41";
            this.xrTableCell41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell41.StylePriority.UseTextAlignment = false;
            this.xrTableCell41.Text = "xrLabel5";
            this.xrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell41.Weight = 107.294052803135D;
            // 
            // xrTableCell42
            // 
            this.xrTableCell42.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[DocumentDate]")});
            this.xrTableCell42.Multiline = true;
            this.xrTableCell42.Name = "xrTableCell42";
            this.xrTableCell42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell42.Text = "xrLabel6";
            this.xrTableCell42.Weight = 107.29407099399729D;
            // 
            // xrTableCell43
            // 
            this.xrTableCell43.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[VPM2_InstId] + \' of \' + [AMG_TRD_UAE_RPT_O" +
                    "UTGIONG_PAYMENT_II].[TotalInstallments]")});
            this.xrTableCell43.Multiline = true;
            this.xrTableCell43.Name = "xrTableCell43";
            this.xrTableCell43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell43.StylePriority.UseTextAlignment = false;
            this.xrTableCell43.Text = "xrLabel7";
            this.xrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell43.Weight = 107.29407099399729D;
            // 
            // xrTableCell44
            // 
            this.xrTableCell44.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[NameAtCard]")});
            this.xrTableCell44.Multiline = true;
            this.xrTableCell44.Name = "xrTableCell44";
            this.xrTableCell44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell44.StylePriority.UseTextAlignment = false;
            this.xrTableCell44.Text = "xrLabel8";
            this.xrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell44.Weight = 107.29403987799637D;
            // 
            // xrTableCell45
            // 
            this.xrTableCell45.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[cf_AmountFlag2]")});
            this.xrTableCell45.Multiline = true;
            this.xrTableCell45.Name = "xrTableCell45";
            this.xrTableCell45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell45.StylePriority.UseTextAlignment = false;
            this.xrTableCell45.Text = "xrLabel11";
            this.xrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell45.TextFormatString = "{0:N2}";
            this.xrTableCell45.Weight = 107.29413931154544D;
            // 
            // GroupHeader11
            // 
            this.GroupHeader11.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.GroupHeader11.HeightF = 23F;
            this.GroupHeader11.Name = "GroupHeader11";
            this.GroupHeader11.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand19});
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8});
            this.xrTable3.SizeF = new System.Drawing.SizeF(751.9999F, 17.1875F);
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell37,
            this.xrTableCell47,
            this.xrTableCell38});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.xrTableCell37.Multiline = true;
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.StylePriority.UseBackColor = false;
            this.xrTableCell37.Weight = 0.042586464561620338D;
            // 
            // xrTableCell47
            // 
            this.xrTableCell47.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell47.Multiline = true;
            this.xrTableCell47.Name = "xrTableCell47";
            this.xrTableCell47.StylePriority.UseFont = false;
            this.xrTableCell47.StylePriority.UseForeColor = false;
            this.xrTableCell47.StylePriority.UseTextAlignment = false;
            this.xrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell47.Weight = 0.1019448319424973D;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell38.Multiline = true;
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.StylePriority.UseFont = false;
            this.xrTableCell38.StylePriority.UseForeColor = false;
            this.xrTableCell38.StylePriority.UseTextAlignment = false;
            this.xrTableCell38.Text = "Payments";
            this.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell38.Weight = 4.54104946664006D;
            // 
            // SubBand19
            // 
            this.SubBand19.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.SubBand19.HeightF = 23F;
            this.SubBand19.Name = "SubBand19";
            // 
            // xrTable2
            // 
            this.xrTable2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.xrTable2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTable2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0.9999886F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
            this.xrTable2.SizeF = new System.Drawing.SizeF(750.9999F, 23F);
            this.xrTable2.StylePriority.UseBackColor = false;
            this.xrTable2.StylePriority.UseBorderColor = false;
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseForeColor = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell39,
            this.xrTableCell31,
            this.xrTableCell32,
            this.xrTableCell33,
            this.xrTableCell34,
            this.xrTableCell35,
            this.xrTableCell36});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.Multiline = true;
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.Text = "#";
            this.xrTableCell39.Weight = 0.31634195115831171D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.Multiline = true;
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.Text = "Paid Doc.";
            this.xrTableCell31.Weight = 1.6836580488416883D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.Multiline = true;
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.Text = "Doc. #";
            this.xrTableCell32.Weight = 1D;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.Multiline = true;
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.Text = "Date";
            this.xrTableCell33.Weight = 1D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.Multiline = true;
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.Text = "Instalment ID";
            this.xrTableCell34.Weight = 1D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.Multiline = true;
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.Text = "Ref #";
            this.xrTableCell35.Weight = 1D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.Multiline = true;
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.StylePriority.UseTextAlignment = false;
            this.xrTableCell36.Text = "Amount";
            this.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell36.Weight = 1D;
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.HeightF = 0F;
            this.GroupFooter2.Name = "GroupFooter2";
            this.GroupFooter2.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand23,
            this.SubBand20,
            this.SubBand21,
            this.SubBand22,
            this.SubBand24});
            // 
            // SubBand23
            // 
            this.SubBand23.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine3,
            this.xrTable5});
            this.SubBand23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[cf_SubTotal] <> 0")});
            this.SubBand23.HeightF = 34.19661F;
            this.SubBand23.Name = "SubBand23";
            // 
            // xrLine3
            // 
            this.xrLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(515.165F, 29.09366F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(236.8349F, 5.102951F);
            this.xrLine3.StylePriority.UseForeColor = false;
            // 
            // xrTable5
            // 
            this.xrTable5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(515.1647F, 9.99999F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10});
            this.xrTable5.SizeF = new System.Drawing.SizeF(236.8351F, 19.09375F);
            this.xrTable5.StylePriority.UseBorderColor = false;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell48,
            this.xrTableCell49,
            this.xrTableCell62});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 1D;
            // 
            // xrTableCell48
            // 
            this.xrTableCell48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.xrTableCell48.Multiline = true;
            this.xrTableCell48.Name = "xrTableCell48";
            this.xrTableCell48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell48.StylePriority.UseBackColor = false;
            this.xrTableCell48.Weight = 8.3826607195987535D;
            // 
            // xrTableCell49
            // 
            this.xrTableCell49.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell49.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell49.Multiline = true;
            this.xrTableCell49.Name = "xrTableCell49";
            this.xrTableCell49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell49.StylePriority.UseBorderColor = false;
            this.xrTableCell49.StylePriority.UseFont = false;
            this.xrTableCell49.StylePriority.UseForeColor = false;
            this.xrTableCell49.StylePriority.UseTextAlignment = false;
            this.xrTableCell49.Text = "Document Amount Due :";
            this.xrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell49.Weight = 124.81968810746368D;
            // 
            // xrTableCell62
            // 
            this.xrTableCell62.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell62.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[cf_SubTotal]")});
            this.xrTableCell62.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell62.Multiline = true;
            this.xrTableCell62.Name = "xrTableCell62";
            this.xrTableCell62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell62.StylePriority.UseBorderColor = false;
            this.xrTableCell62.StylePriority.UseFont = false;
            this.xrTableCell62.StylePriority.UseForeColor = false;
            this.xrTableCell62.StylePriority.UseTextAlignment = false;
            this.xrTableCell62.Text = "xrTableCell62";
            this.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell62.TextFormatString = "{0:N2}";
            this.xrTableCell62.Weight = 80.190731903946912D;
            // 
            // SubBand20
            // 
            this.SubBand20.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine5,
            this.xrTable20});
            this.SubBand20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[cf_PaymentOnAccount] <> 0")});
            this.SubBand20.HeightF = 34.19661F;
            this.SubBand20.Name = "SubBand20";
            // 
            // xrLine5
            // 
            this.xrLine5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(515.1647F, 29.09366F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(236.8349F, 5.102951F);
            this.xrLine5.StylePriority.UseForeColor = false;
            // 
            // xrTable20
            // 
            this.xrTable20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable20.LocationFloat = new DevExpress.Utils.PointFloat(515.1647F, 9.99999F);
            this.xrTable20.Name = "xrTable20";
            this.xrTable20.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow26});
            this.xrTable20.SizeF = new System.Drawing.SizeF(236.8348F, 19.09375F);
            this.xrTable20.StylePriority.UseBorderColor = false;
            // 
            // xrTableRow26
            // 
            this.xrTableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell97,
            this.xrTableCell112,
            this.xrTableCell113});
            this.xrTableRow26.Name = "xrTableRow26";
            this.xrTableRow26.Weight = 1D;
            // 
            // xrTableCell97
            // 
            this.xrTableCell97.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.xrTableCell97.Multiline = true;
            this.xrTableCell97.Name = "xrTableCell97";
            this.xrTableCell97.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell97.StylePriority.UseBackColor = false;
            this.xrTableCell97.Weight = 8.3826607195987535D;
            // 
            // xrTableCell112
            // 
            this.xrTableCell112.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell112.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell112.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell112.Multiline = true;
            this.xrTableCell112.Name = "xrTableCell112";
            this.xrTableCell112.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell112.StylePriority.UseBorderColor = false;
            this.xrTableCell112.StylePriority.UseFont = false;
            this.xrTableCell112.StylePriority.UseForeColor = false;
            this.xrTableCell112.StylePriority.UseTextAlignment = false;
            this.xrTableCell112.Text = "Payment on Account :";
            this.xrTableCell112.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell112.Weight = 124.81969465916805D;
            // 
            // xrTableCell113
            // 
            this.xrTableCell113.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell113.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[cf_PaymentOnAccount] <> 0\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[cf_PaymentOnAccount]")});
            this.xrTableCell113.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell113.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell113.Multiline = true;
            this.xrTableCell113.Name = "xrTableCell113";
            this.xrTableCell113.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell113.StylePriority.UseBorderColor = false;
            this.xrTableCell113.StylePriority.UseFont = false;
            this.xrTableCell113.StylePriority.UseForeColor = false;
            this.xrTableCell113.StylePriority.UseTextAlignment = false;
            this.xrTableCell113.Text = "xrTableCell62";
            this.xrTableCell113.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell113.TextFormatString = "{0:N2}";
            this.xrTableCell113.Weight = 80.190725352242538D;
            // 
            // SubBand21
            // 
            this.SubBand21.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable21,
            this.xrLine6});
            this.SubBand21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[cf_WTSum] <> 0\n")});
            this.SubBand21.HeightF = 34.19661F;
            this.SubBand21.Name = "SubBand21";
            // 
            // xrTable21
            // 
            this.xrTable21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable21.LocationFloat = new DevExpress.Utils.PointFloat(515.1646F, 9.99999F);
            this.xrTable21.Name = "xrTable21";
            this.xrTable21.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow27});
            this.xrTable21.SizeF = new System.Drawing.SizeF(236.8349F, 19.09375F);
            this.xrTable21.StylePriority.UseBorderColor = false;
            // 
            // xrTableRow27
            // 
            this.xrTableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell114,
            this.xrTableCell115,
            this.xrTableCell116});
            this.xrTableRow27.Name = "xrTableRow27";
            this.xrTableRow27.Weight = 1D;
            // 
            // xrTableCell114
            // 
            this.xrTableCell114.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.xrTableCell114.Multiline = true;
            this.xrTableCell114.Name = "xrTableCell114";
            this.xrTableCell114.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell114.StylePriority.UseBackColor = false;
            this.xrTableCell114.Weight = 8.3826607195987535D;
            // 
            // xrTableCell115
            // 
            this.xrTableCell115.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell115.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell115.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell115.Multiline = true;
            this.xrTableCell115.Name = "xrTableCell115";
            this.xrTableCell115.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell115.StylePriority.UseBorderColor = false;
            this.xrTableCell115.StylePriority.UseFont = false;
            this.xrTableCell115.StylePriority.UseForeColor = false;
            this.xrTableCell115.StylePriority.UseTextAlignment = false;
            this.xrTableCell115.Text = "Withholding Tax :";
            this.xrTableCell115.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell115.Weight = 124.81960257658966D;
            // 
            // xrTableCell116
            // 
            this.xrTableCell116.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell116.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[cf_WTSum]")});
            this.xrTableCell116.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell116.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell116.Multiline = true;
            this.xrTableCell116.Name = "xrTableCell116";
            this.xrTableCell116.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell116.StylePriority.UseBorderColor = false;
            this.xrTableCell116.StylePriority.UseFont = false;
            this.xrTableCell116.StylePriority.UseForeColor = false;
            this.xrTableCell116.StylePriority.UseTextAlignment = false;
            this.xrTableCell116.Text = "xrTableCell62";
            this.xrTableCell116.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell116.TextFormatString = "{0:N2}";
            this.xrTableCell116.Weight = 80.190817434820929D;
            // 
            // xrLine6
            // 
            this.xrLine6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(515.1646F, 29.09366F);
            this.xrLine6.Name = "xrLine6";
            this.xrLine6.SizeF = new System.Drawing.SizeF(236.8349F, 5.102951F);
            this.xrLine6.StylePriority.UseForeColor = false;
            // 
            // SubBand22
            // 
            this.SubBand22.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine7,
            this.xrTable22});
            this.SubBand22.HeightF = 34.19661F;
            this.SubBand22.Name = "SubBand22";
            // 
            // xrLine7
            // 
            this.xrLine7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(515.1646F, 29.09366F);
            this.xrLine7.Name = "xrLine7";
            this.xrLine7.SizeF = new System.Drawing.SizeF(236.8349F, 5.102951F);
            this.xrLine7.StylePriority.UseForeColor = false;
            // 
            // xrTable22
            // 
            this.xrTable22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTable22.LocationFloat = new DevExpress.Utils.PointFloat(515.1642F, 9.99999F);
            this.xrTable22.Name = "xrTable22";
            this.xrTable22.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow28});
            this.xrTable22.SizeF = new System.Drawing.SizeF(236.8351F, 19.09375F);
            this.xrTable22.StylePriority.UseBorderColor = false;
            // 
            // xrTableRow28
            // 
            this.xrTableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell117,
            this.xrTableCell118,
            this.xrTableCell119});
            this.xrTableRow28.Name = "xrTableRow28";
            this.xrTableRow28.Weight = 1D;
            // 
            // xrTableCell117
            // 
            this.xrTableCell117.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.xrTableCell117.Multiline = true;
            this.xrTableCell117.Name = "xrTableCell117";
            this.xrTableCell117.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell117.StylePriority.UseBackColor = false;
            this.xrTableCell117.Weight = 8.3826607195987535D;
            // 
            // xrTableCell118
            // 
            this.xrTableCell118.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell118.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell118.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell118.Multiline = true;
            this.xrTableCell118.Name = "xrTableCell118";
            this.xrTableCell118.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell118.StylePriority.UseBorderColor = false;
            this.xrTableCell118.StylePriority.UseFont = false;
            this.xrTableCell118.StylePriority.UseForeColor = false;
            this.xrTableCell118.StylePriority.UseTextAlignment = false;
            this.xrTableCell118.Text = "Total Amount Due :";
            this.xrTableCell118.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell118.Weight = 124.81974310132904D;
            // 
            // xrTableCell119
            // 
            this.xrTableCell119.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell119.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II].[cf_Total]")});
            this.xrTableCell119.Font = new DevExpress.Drawing.DXFont("calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell119.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrTableCell119.Multiline = true;
            this.xrTableCell119.Name = "xrTableCell119";
            this.xrTableCell119.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell119.StylePriority.UseBorderColor = false;
            this.xrTableCell119.StylePriority.UseFont = false;
            this.xrTableCell119.StylePriority.UseForeColor = false;
            this.xrTableCell119.StylePriority.UseTextAlignment = false;
            this.xrTableCell119.Text = "xrTableCell62";
            this.xrTableCell119.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell119.TextFormatString = "{0:N2}";
            this.xrTableCell119.Weight = 80.19067691008155D;
            // 
            // SubBand24
            // 
            this.SubBand24.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine8});
            this.SubBand24.HeightF = 23F;
            this.SubBand24.Name = "SubBand24";
            // 
            // xrLine8
            // 
            this.xrLine8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.xrLine8.LineWidth = 1.5F;
            this.xrLine8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine8.Name = "xrLine8";
            this.xrLine8.SizeF = new System.Drawing.SizeF(751.9994F, 23F);
            this.xrLine8.StylePriority.UseForeColor = false;
            // 
            // cf_DocumentNumber
            // 
            this.cf_DocumentNumber.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_DocumentNumber.Expression = resources.GetString("cf_DocumentNumber.Expression");
            this.cf_DocumentNumber.Name = "cf_DocumentNumber";
            // 
            // cf_DocTotal
            // 
            this.cf_DocTotal.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_DocTotal.Expression = "Iif([OVPM_DocCurr] == [OADM_MainCurncy], [OVPM_DocTotal],\n    Iif([OVPM_DocCurr] " +
    "== [OADM_SysCurrncy], [OVPM_DocTotalSy],\n        [OVPM_DocTotalFC]))\n";
            this.cf_DocTotal.Name = "cf_DocTotal";
            // 
            // cf_WTSum
            // 
            this.cf_WTSum.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_WTSum.Expression = "Iif([OVPM_DocCurr] == [OADM_MainCurncy], [OVPM_WtSum],\n    Iif([OVPM_DocCurr] == " +
    "[OADM_SysCurrncy], [OVPM_WtSumsys],\n        [OVPM_WtSumfrgn]))\n";
            this.cf_WTSum.Name = "cf_WTSum";
            // 
            // cf_PaymentOnAccount
            // 
            this.cf_PaymentOnAccount.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_PaymentOnAccount.Expression = resources.GetString("cf_PaymentOnAccount.Expression");
            this.cf_PaymentOnAccount.Name = "cf_PaymentOnAccount";
            // 
            // cf_Total
            // 
            this.cf_Total.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.cf_Total.Expression = "[cf_SubTotal]";
            this.cf_Total.Name = "cf_Total";
            // 
            // SubBand27
            // 
            this.SubBand27.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine10});
            this.SubBand27.HeightF = 23F;
            this.SubBand27.Name = "SubBand27";
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("srDraftEntry", null, "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II.OVPM_DraftKey"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("srObjType", null, "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II.OVPM_ObjType"));
            this.xrSubreport1.ReportSource = new dxReports.Reports.Outgoing_Payments.Outgoing_Payment_Standar_Approval_Sub_Report();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(752.0002F, 62.3443F);
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(62.18679F, 74.60587F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // Outgoing_Payment_2
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.GroupHeader1,
            this.PageHeader,
            this.GroupFooter1,
            this.GroupHeader2,
            this.GroupHeader3,
            this.GroupHeader4,
            this.GroupHeader5,
            this.GroupHeader6,
            this.DetailReport,
            this.DetailReport1,
            this.DetailReport2,
            this.DetailReport3,
            this.DetailReport4});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.cf_Currency,
            this.cf_CheckCurrency,
            this.cf_Amount2,
            this.cf_SubTotal,
            this.cf_AmountFlag2,
            this.cf_CreditSum,
            this.cf_CheckSum,
            this.cf_BankSum,
            this.cf_CashSum,
            this.cf_TotalSum,
            this.cf_DdctSum,
            this.cf_Remarks,
            this.cf_DocumentNumber,
            this.cf_DocTotal,
            this.cf_WTSum,
            this.cf_PaymentOnAccount,
            this.cf_Total});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "AMG_TRD_UAE_RPT_OUTGIONG_PAYMENT_II";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(50F, 25F, 29.48718F, 71.99409F);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DocEntry, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.DocEntry});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.Parameters.Parameter DocEntry;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.CalculatedField cf_Currency;
        private DevExpress.XtraReports.UI.CalculatedField cf_CheckCurrency;
        private DevExpress.XtraReports.UI.CalculatedField cf_Amount2;
        private DevExpress.XtraReports.UI.CalculatedField cf_SubTotal;
        private DevExpress.XtraReports.UI.CalculatedField cf_AmountFlag2;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.CalculatedField cf_CreditSum;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.SubBand SubBand3;
        private DevExpress.XtraReports.UI.CalculatedField cf_CheckSum;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.SubBand SubBand4;
        private DevExpress.XtraReports.UI.CalculatedField cf_BankSum;
        private DevExpress.XtraReports.UI.CalculatedField cf_CashSum;
        private DevExpress.XtraReports.UI.CalculatedField cf_TotalSum;
        private DevExpress.XtraReports.UI.CalculatedField cf_DdctSum;
        private DevExpress.XtraReports.UI.CalculatedField cf_Remarks;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell17;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell21;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell25;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell15;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow17;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell86;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell87;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell88;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow60;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell234;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell235;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell236;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell18;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell19;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell22;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell23;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell26;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell27;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell30;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell29;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.SubBand SubBand6;
        private DevExpress.XtraReports.UI.SubBand SubBand5;
        private DevExpress.XtraReports.UI.SubBand SubBand7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell24;
        private DevExpress.XtraReports.UI.SubBand SubBand8;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.SubBand SubBand9;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader3;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader4;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader5;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader6;
        private DevExpress.XtraReports.UI.SubBand SubBand10;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRTable xrTable6;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell50;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell51;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell52;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell53;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell54;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell55;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader7;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport1;
        private DevExpress.XtraReports.UI.DetailBand Detail2;
        private DevExpress.XtraReports.UI.XRTable xrTable9;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow14;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell71;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell72;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell73;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell74;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell75;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell76;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader8;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport2;
        private DevExpress.XtraReports.UI.DetailBand Detail3;
        private DevExpress.XtraReports.UI.XRTable xrTable11;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow16;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell85;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell89;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell90;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell91;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader9;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport3;
        private DevExpress.XtraReports.UI.DetailBand Detail4;
        private DevExpress.XtraReports.UI.XRTable xrTable13;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow19;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell99;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell100;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell101;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader10;
        private DevExpress.XtraReports.UI.SubBand SubBand11;
        private DevExpress.XtraReports.UI.SubBand SubBand12;
        private DevExpress.XtraReports.UI.SubBand SubBand13;
        private DevExpress.XtraReports.UI.SubBand SubBand14;
        private DevExpress.XtraReports.UI.XRTable xrTable16;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow22;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell108;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell109;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell110;
        private DevExpress.XtraReports.UI.SubBand SubBand15;
        private DevExpress.XtraReports.UI.XRTable xrTable10;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow15;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell78;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell79;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell80;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell81;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell84;
        private DevExpress.XtraReports.UI.XRTable xrTable15;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow21;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell105;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell106;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell107;
        private DevExpress.XtraReports.UI.SubBand SubBand16;
        private DevExpress.XtraReports.UI.XRTable xrTable8;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell65;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell66;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell67;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell68;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell69;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell70;
        private DevExpress.XtraReports.UI.XRTable xrTable14;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow20;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell102;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell103;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell104;
        private DevExpress.XtraReports.UI.SubBand SubBand17;
        private DevExpress.XtraReports.UI.XRTable xrTable7;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell56;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell57;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell58;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell59;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell60;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell61;
        private DevExpress.XtraReports.UI.XRTable xrTable17;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow23;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell82;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell83;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell111;
        private DevExpress.XtraReports.UI.SubBand SubBand18;
        private DevExpress.XtraReports.UI.XRTable xrTable12;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow18;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell93;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell94;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell98;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport4;
        private DevExpress.XtraReports.UI.DetailBand Detail5;
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell46;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell40;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell41;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell42;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell43;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell44;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell45;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader11;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
        private DevExpress.XtraReports.UI.CalculatedField cf_DocumentNumber;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter3;
        private DevExpress.XtraReports.UI.XRLine xrLine4;
        private DevExpress.XtraReports.UI.XRTable xrTable18;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow24;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell63;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell64;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell77;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell37;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell47;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell38;
        private DevExpress.XtraReports.UI.SubBand SubBand19;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell39;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell31;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell32;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell33;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell34;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell35;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell36;
        private DevExpress.XtraReports.UI.CalculatedField cf_DocTotal;
        private DevExpress.XtraReports.UI.CalculatedField cf_WTSum;
        private DevExpress.XtraReports.UI.CalculatedField cf_PaymentOnAccount;
        private DevExpress.XtraReports.UI.SubBand SubBand20;
        private DevExpress.XtraReports.UI.XRLine xrLine5;
        private DevExpress.XtraReports.UI.XRTable xrTable20;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow26;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell97;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell112;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell113;
        private DevExpress.XtraReports.UI.SubBand SubBand21;
        private DevExpress.XtraReports.UI.XRTable xrTable21;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow27;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell114;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell115;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell116;
        private DevExpress.XtraReports.UI.XRLine xrLine6;
        private DevExpress.XtraReports.UI.SubBand SubBand23;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRTable xrTable5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell48;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell49;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell62;
        private DevExpress.XtraReports.UI.SubBand SubBand22;
        private DevExpress.XtraReports.UI.XRLine xrLine7;
        private DevExpress.XtraReports.UI.XRTable xrTable22;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow28;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell117;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell118;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell119;
        private DevExpress.XtraReports.UI.CalculatedField cf_Total;
        private DevExpress.XtraReports.UI.XRTable xrTable19;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow25;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell92;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell95;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell96;
        private DevExpress.XtraReports.UI.SubBand SubBand24;
        private DevExpress.XtraReports.UI.XRLine xrLine8;
        private DevExpress.XtraReports.UI.SubBand SubBand25;
        private DevExpress.XtraReports.UI.XRLine xrLine9;
        private DevExpress.XtraReports.UI.XRLine xrLine10;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter4;
        private DevExpress.XtraReports.UI.XRTable xrTable23;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow29;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell120;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell121;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell122;
        private DevExpress.XtraReports.UI.XRLine xrLine11;
        private DevExpress.XtraReports.UI.SubBand SubBand26;
        private DevExpress.XtraReports.UI.XRLine xrLine12;
        private DevExpress.XtraReports.UI.XRLine xrLine13;
        private DevExpress.XtraReports.UI.XRTable xrTable24;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow30;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell123;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell124;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell125;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTable xrTable25;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow31;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell126;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow32;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell127;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow33;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell128;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow34;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell129;
        private DevExpress.XtraReports.UI.XRTable xrTable26;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow35;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell130;
        private DevExpress.XtraReports.UI.XRShape xrShape3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell131;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell28;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.SubBand SubBand27;
    }
}
