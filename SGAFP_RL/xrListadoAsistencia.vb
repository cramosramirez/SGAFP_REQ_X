Imports System.Collections.Generic
Imports System.Data

Public Class xrListadoAsistencia
    Inherits DevExpress.XtraReports.UI.XtraReport

    Dim IdAccionFormativa As Decimal

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents pageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Private WithEvents xrlPrograma As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine3 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Private WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Private WithEvents listadoAsistenciaTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.ListadoAsistenciaTableAdapter
    Private WithEvents dS_DL1 As SGAFP.DL.DS_DL
    Private WithEvents PARTICIPANTE As DevExpress.XtraReports.UI.CalculatedField
    Private WithEvents formattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents xrSubReporteListaAsistencia1 As xrSubReporteListaAsistencia
    Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents xrLine2 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLine4 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents codigoNombreCurso As DevExpress.XtraReports.UI.CalculatedField
    Private WithEvents xrLabel11 As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xrListadoAsistencia))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.listadoAsistenciaTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.ListadoAsistenciaTableAdapter()
        Me.dS_DL1 = New SGAFP.DL.DS_DL()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.pageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrlPrograma = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PARTICIPANTE = New DevExpress.XtraReports.UI.CalculatedField()
        Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.xrSubReporteListaAsistencia1 = New SGAFP.RL.xrSubReporteListaAsistencia()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.codigoNombreCurso = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me.dS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrSubReporteListaAsistencia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'listadoAsistenciaTableAdapter1
        '
        Me.listadoAsistenciaTableAdapter1.ClearBeforeFill = True
        '
        'dS_DL1
        '
        Me.dS_DL1.DataSetName = "DS_DL"
        Me.dS_DL1.EnforceConstraints = False
        Me.dS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.White
        Me.Title.BorderColor = System.Drawing.SystemColors.ControlText
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 24.0!)
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.White
        Me.FieldCaption.BorderColor = System.Drawing.SystemColors.ControlText
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.FieldCaption.BorderWidth = 1
        Me.FieldCaption.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Black
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.White
        Me.PageInfo.BorderColor = System.Drawing.SystemColors.ControlText
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1
        Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.White
        Me.DataField.BorderColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1
        Me.DataField.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.DataField.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'pageHeaderBand1
        '
        Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox1, Me.xrLabel4, Me.xrlPrograma, Me.xrLine3, Me.xrLine1})
        Me.pageHeaderBand1.HeightF = 59.0!
        Me.pageHeaderBand1.Name = "pageHeaderBand1"
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Image = CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image)
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(2.87501!, 5.000014!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(145.875!, 45.99999!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrLabel4
        '
        Me.xrLabel4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(151.7501!, 30.20836!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(597.3063!, 19.20834!)
        Me.xrLabel4.StyleName = "Title"
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.StylePriority.UseTextAlignment = False
        Me.xrLabel4.Text = "CONTROL DE ASISTENCIA DE LOS(AS) PARTICIPANTES POR CURSO"
        Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrlPrograma
        '
        Me.xrlPrograma.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrlPrograma.LocationFloat = New DevExpress.Utils.PointFloat(151.75!, 2.000014!)
        Me.xrlPrograma.Name = "xrlPrograma"
        Me.xrlPrograma.SizeF = New System.Drawing.SizeF(597.3063!, 19.20834!)
        Me.xrlPrograma.StyleName = "Title"
        Me.xrlPrograma.StylePriority.UseFont = False
        Me.xrlPrograma.StylePriority.UseTextAlignment = False
        Me.xrlPrograma.Text = "PROGRAMA"
        Me.xrlPrograma.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLine3
        '
        Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(5.999883!, 0.0!)
        Me.xrLine3.Name = "xrLine3"
        Me.xrLine3.SizeF = New System.Drawing.SizeF(877.9999!, 2.0!)
        '
        'xrLine1
        '
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(2.87501!, 57.0!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(877.9999!, 2.0!)
        '
        'xrLabel1
        '
        Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(2.87501!, 4.916668!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(156.875!, 17.25!)
        Me.xrLabel1.StyleName = "FieldCaption"
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.Text = "NOMBRE DEL PROVEEDOR:"
        '
        'xrLabel2
        '
        Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(459.0722!, 4.916668!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(147.4278!, 17.25!)
        Me.xrLabel2.StyleName = "FieldCaption"
        Me.xrLabel2.StylePriority.UseFont = False
        Me.xrLabel2.Text = "CENTRO DE FORMACIÓN:"
        '
        'xrLabel3
        '
        Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(2.87501!, 22.16667!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(47.43105!, 17.24999!)
        Me.xrLabel3.StyleName = "FieldCaption"
        Me.xrLabel3.StylePriority.UseFont = False
        Me.xrLabel3.Text = "CURSO:"
        '
        'xrLabel5
        '
        Me.xrLabel5.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(459.0722!, 22.16667!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(83.72119!, 17.24999!)
        Me.xrLabel5.StyleName = "FieldCaption"
        Me.xrLabel5.StylePriority.UseFont = False
        Me.xrLabel5.Text = "HORARIO:"
        '
        'xrLabel6
        '
        Me.xrLabel6.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(2.87501!, 56.08333!)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(106.6634!, 17.25!)
        Me.xrLabel6.StyleName = "FieldCaption"
        Me.xrLabel6.StylePriority.UseFont = False
        Me.xrLabel6.Text = "FECHA DE INICIO:"
        '
        'xrLabel7
        '
        Me.xrLabel7.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(198.75!, 56.08333!)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.SizeF = New System.Drawing.SizeF(151.9888!, 17.25!)
        Me.xrLabel7.StyleName = "FieldCaption"
        Me.xrLabel7.StylePriority.UseFont = False
        Me.xrLabel7.Text = "FECHA DE FINALIZACION:"
        '
        'xrLabel13
        '
        Me.xrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoAsistencia.NOMBRE_PROVEEDOR")})
        Me.xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(159.75!, 4.916668!)
        Me.xrLabel13.Name = "xrLabel13"
        Me.xrLabel13.SizeF = New System.Drawing.SizeF(291.6874!, 17.25!)
        Me.xrLabel13.StyleName = "DataField"
        Me.xrLabel13.Text = "xrLabel13"
        '
        'xrLabel14
        '
        Me.xrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoAsistencia.NOMBRE_SITIO")})
        Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(606.5!, 4.916668!)
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.SizeF = New System.Drawing.SizeF(265.1361!, 17.25!)
        Me.xrLabel14.StyleName = "DataField"
        Me.xrLabel14.Text = "xrLabel14"
        '
        'xrLabel17
        '
        Me.xrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoAsistencia.HORARIO")})
        Me.xrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(542.7935!, 22.16667!)
        Me.xrLabel17.Name = "xrLabel17"
        Me.xrLabel17.SizeF = New System.Drawing.SizeF(258.7211!, 17.25!)
        Me.xrLabel17.StyleName = "DataField"
        Me.xrLabel17.Text = "xrLabel17"
        '
        'xrLabel18
        '
        Me.xrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoAsistencia.FECHA_INICIO_REAL", "{0:dd/MM/yyyy}")})
        Me.xrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(109.5384!, 56.08333!)
        Me.xrLabel18.Name = "xrLabel18"
        Me.xrLabel18.SizeF = New System.Drawing.SizeF(80.21157!, 17.25!)
        Me.xrLabel18.StyleName = "DataField"
        Me.xrLabel18.Text = "xrLabel18"
        '
        'xrLabel19
        '
        Me.xrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoAsistencia.FECHA_FIN_REAL", "{0:dd/MM/yyyy}")})
        Me.xrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(350.7388!, 56.08333!)
        Me.xrLabel19.Name = "xrLabel19"
        Me.xrLabel19.SizeF = New System.Drawing.SizeF(163.3221!, 17.25!)
        Me.xrLabel19.StyleName = "DataField"
        Me.xrLabel19.Text = "xrLabel19"
        '
        'pageFooterBand1
        '
        Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel10, Me.xrLine4, Me.xrPageInfo1, Me.xrPageInfo2, Me.xrLine2, Me.xrLabel9})
        Me.pageFooterBand1.HeightF = 116.0!
        Me.pageFooterBand1.Name = "pageFooterBand1"
        '
        'xrLabel10
        '
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(511.5304!, 53.0!)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(271.5113!, 36.0!)
        Me.xrLabel10.StylePriority.UseTextAlignment = False
        Me.xrLabel10.Text = "Nombre y Firma de el(la) Coordinador(a) del Centro de Formación"
        Me.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLine4
        '
        Me.xrLine4.LocationFloat = New DevExpress.Utils.PointFloat(489.0147!, 39.0!)
        Me.xrLine4.Name = "xrLine4"
        Me.xrLine4.SizeF = New System.Drawing.SizeF(312.5!, 12.5!)
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.Format = "{0:dddd, dd' de 'MMMM' de 'yyyy'  Hora: 'hh:mm tt}"
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(5.999883!, 89.0!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.xrPageInfo1.StyleName = "PageInfo"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Format = "Pagina {0} de {1}"
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(576.9998!, 89.0!)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(306.9999!, 23.00002!)
        Me.xrPageInfo2.StyleName = "PageInfo"
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrLine2
        '
        Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 39.0!)
        Me.xrLine2.Name = "xrLine2"
        Me.xrLine2.SizeF = New System.Drawing.SizeF(312.5!, 12.5!)
        '
        'xrLabel9
        '
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(70.13143!, 53.0!)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(229.5418!, 17.99998!)
        Me.xrLabel9.Text = "Nombre y Firma de el(la) Instructor(a)"
        '
        'reportHeaderBand1
        '
        Me.reportHeaderBand1.HeightF = 25.0!
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        '
        'topMarginBand1
        '
        Me.topMarginBand1.HeightF = 33.0!
        Me.topMarginBand1.Name = "topMarginBand1"
        '
        'bottomMarginBand1
        '
        Me.bottomMarginBand1.HeightF = 56.0!
        Me.bottomMarginBand1.Name = "bottomMarginBand1"
        '
        'PARTICIPANTE
        '
        Me.PARTICIPANTE.DataMember = "ListadoAsistencia"
        Me.PARTICIPANTE.DataSource = Me.dS_DL1
        Me.PARTICIPANTE.Expression = "[NOMBRES]"
        Me.PARTICIPANTE.Name = "PARTICIPANTE"
        '
        'formattingRule1
        '
        Me.formattingRule1.Name = "formattingRule1"
        '
        'xrLabel8
        '
        Me.xrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoAsistencia.PERIODO")})
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(526.4245!, 56.08333!)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.SizeF = New System.Drawing.SizeF(357.5753!, 17.25!)
        Me.xrLabel8.StyleName = "DataField"
        Me.xrLabel8.Text = "xrLabel8"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel11, Me.xrLabel8, Me.xrLabel18, Me.xrLabel17, Me.xrLabel14, Me.xrLabel13, Me.xrLabel7, Me.xrLabel6, Me.xrLabel5, Me.xrLabel3, Me.xrLabel2, Me.xrLabel1, Me.xrLabel19, Me.xrSubreport1})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ID_PERIODO", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 191.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'xrLabel11
        '
        Me.xrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoAsistencia.codigoNombreCurso")})
        Me.xrLabel11.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(50.30606!, 22.16667!)
        Me.xrLabel11.Name = "xrLabel11"
        Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel11.SizeF = New System.Drawing.SizeF(401.1313!, 22.99999!)
        Me.xrLabel11.StylePriority.UseFont = False
        Me.xrLabel11.Text = "xrLabel11"
        '
        'xrSubreport1
        '
        Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(2.87501!, 73.33333!)
        Me.xrSubreport1.Name = "xrSubreport1"
        Me.xrSubreport1.ReportSource = Me.xrSubReporteListaAsistencia1
        Me.xrSubreport1.SizeF = New System.Drawing.SizeF(887.125!, 117.6667!)
        '
        'GroupFooter1
        '
        Me.GroupFooter1.HeightF = 0.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'codigoNombreCurso
        '
        Me.codigoNombreCurso.DataMember = "ListadoAsistencia"
        Me.codigoNombreCurso.DataSource = Me.dS_DL1
        Me.codigoNombreCurso.Expression = "Concat([CODIGO_GRUPO], Concat('-',[NOMBRE_ACCION_FORMATIVA]))"
        Me.codigoNombreCurso.Name = "codigoNombreCurso"
        '
        'xrListadoAsistencia
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.pageHeaderBand1, Me.pageFooterBand1, Me.reportHeaderBand1, Me.topMarginBand1, Me.bottomMarginBand1, Me.GroupHeader1, Me.GroupFooter1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.PARTICIPANTE, Me.codigoNombreCurso})
        Me.DataAdapter = Me.listadoAsistenciaTableAdapter1
        Me.DataMember = "ListadoAsistencia"
        Me.DataSource = Me.dS_DL1
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.formattingRule1})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 33, 56)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ScriptsSource = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "11.1"
        Me.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart
        CType(Me.dS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrSubReporteListaAsistencia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand

#End Region

    Public Sub CargarDatosPorAccionFormativa(ByVal ID_ACCION_FORMATIVA As Decimal)
        Dim lPrograma As PROGRAMA_FORMACION = (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION((New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(ID_ACCION_FORMATIVA).ID_PROGRAMA_FORMACION)
        Dim lTerminos As listaTERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If lTerminos IsNot Nothing AndAlso lTerminos.Count > 0 Then
            Dim lSolicitud As SOLICITUD_CAPACITACION = (New cSOLICITUD_CAPACITACION).ObtenerSOLICITUD_CAPACITACION(lTerminos(0).ID_SOLICITUD)
            If lSolicitud IsNot Nothing Then
                Dim lProyecto As PROYECTO_FORMACION = (New cPROYECTO_FORMACION).ObtenerPROYECTO_FORMACION(lSolicitud.ID_PROYECTO_FORMACION)
                xrlPrograma.Text = "PROGRAMA: " + lProyecto.NOMBRE_PROYECTO_FORMACION
            Else
                xrlPrograma.Text = "PROGRAMA DE CAPACITACIÓN"
            End If
        Else
            xrlPrograma.Text = "PROGRAMA: " + lPrograma.NOMBRE_PROGRAMA_FORMACION
        End If

        Me.dS_DL1.Clear()
        Me.listadoAsistenciaTableAdapter1.FillByAccionIniciada(Me.dS_DL1.ListadoAsistencia, ID_ACCION_FORMATIVA)


        Dim fechaInicioPeriodo, fechaFinPeriodo, fechaAnterior As DateTime
        Dim band As Boolean = False
        Dim numeroDias As Integer = 0

        Dim periodos As New ArrayList
        Dim periodo(3) As Object
        Dim numperiodo As Integer = 0

        Dim dv As DataView = Me.dS_DL1.ListadoAsistencia.DefaultView
        dv.Sort = "FECHA asc, APELLIDOS asc, NOMBRES asc"

        For Each fila As DataRowView In dv
            If numeroDias = 5 Then
                numeroDias = 0
                band = False
                periodo(0) += fechaFinPeriodo.ToString("dd/MM/yyyy")
                periodo(2) = fechaFinPeriodo
                periodo(3) = numperiodo
                periodos.Add(periodo.Clone)
                numperiodo += 1
            End If

            If Not band And numeroDias = 0 Then
                If periodos.Count = 0 Then
                    fechaInicioPeriodo = fila("FECHA")
                    fechaFinPeriodo = fechaInicioPeriodo
                    periodo(0) = "PERIODO DEL: " + fechaInicioPeriodo.ToString("dd/MM/yyyy") + " AL: "
                    periodo(1) = fechaInicioPeriodo
                    periodo(2) = fechaFinPeriodo
                    periodo(3) = numperiodo
                Else
                    fechaFinPeriodo = fechaInicioPeriodo
                    periodo(0) = "PERIODO DEL: " + fechaInicioPeriodo.ToString("dd/MM/yyyy") + " AL: "
                    periodo(1) = fechaInicioPeriodo
                    periodo(2) = fechaFinPeriodo
                    periodo(3) = numperiodo
                End If
                band = True
            End If

            If fila("FECHA") <> fechaInicioPeriodo Then
                fechaAnterior = fechaInicioPeriodo
                fechaFinPeriodo = fechaInicioPeriodo
                fechaInicioPeriodo = fila("FECHA")
                numeroDias += 1
            End If

        Next
        If numeroDias < 5 Then
            If fechaInicioPeriodo > fechaFinPeriodo Then
                periodo(0) += fechaInicioPeriodo.ToString("dd/MM/yyyy")
                periodo(2) = fechaInicioPeriodo
                periodo(3) = numperiodo
                periodos.Add(periodo)
            Else
                periodo(0) += fechaFinPeriodo.ToString("dd/MM/yyyy")
                periodo(2) = fechaFinPeriodo
                periodo(3) = numperiodo
                periodos.Add(periodo)
            End If

        Else
            periodo(0) += fechaAnterior.ToString("dd/MM/yyyy")
            periodo(2) = fechaAnterior
            periodo(3) = numperiodo
            periodos.Add(periodo)

            Dim periodo1(3) As Object

            periodo1(0) = "PERIODO DEL: " + fechaInicioPeriodo.ToString("dd/MM/yyyy") + " AL: " + fechaInicioPeriodo.ToString("dd/MM/yyyy")
            periodo1(1) = fechaInicioPeriodo
            periodo1(2) = fechaInicioPeriodo
            numperiodo += 1
            periodo1(3) = numperiodo
            periodos.Add(periodo1)
        End If


        For Each fila As SGAFP.DL.DS_DL.ListadoAsistenciaRow In Me.dS_DL1.ListadoAsistencia.Rows
            For Each datos As Object In periodos
                If fila.FECHA >= datos(1) And fila.FECHA <= datos(2) Then
                    fila.PERIODO = datos(0)
                    fila.FECHA_INICIAL = datos(1)
                    fila.FECHA_FINAL = datos(2)
                    fila.ID_PERIODO = datos(3)
                    Exit For
                End If
            Next
        Next

        Dim dv1 As DataView = Me.dS_DL1.ListadoAsistencia.DefaultView
        dv1.Sort = "FECHA asc, APELLIDOS asc, NOMBRES asc"

        Dim ds As New DataSet
        ds.Tables.Add(dv1.ToTable())
        Me.DataSource = ds

    End Sub

    Private Sub xrSubReporteListaAsistencia1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubReporteListaAsistencia1.BeforePrint
        Dim detail As xrSubReporteListaAsistencia = TryCast(xrSubreport1.ReportSource, xrSubReporteListaAsistencia)
        If detail IsNot Nothing Then
            If Not GetCurrentColumnValue("PERIODO") Is DBNull.Value Then
                Dim fechaInicial, fechaFinal As DateTime
                Dim idAccionFormativa As Decimal
                fechaInicial = GetCurrentColumnValue("FECHA_INICIAL")
                fechaFinal = GetCurrentColumnValue("FECHA_FINAL")
                idAccionFormativa = GetCurrentColumnValue("ID_ACCION_FORMATIVA")
                detail.CargarDatos(idAccionFormativa, fechaInicial, fechaFinal)
                detail.FillDataSource()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub xrListadoAsistencia_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Dim detail As xrSubReporteListaAsistencia = TryCast(xrSubreport1.ReportSource, xrSubReporteListaAsistencia)
        If detail IsNot Nothing Then
            detail.FillDataSource()
        End If
    End Sub

End Class