Imports SGAFP.BL
Imports SGAFP.EL
Imports DevExpress.Web.ASPxGridView

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaCONTRATO_COMPRA_PAGO_ASISTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla CONTRATO_COMPRA_PAGO_ASISTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/10/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaCONTRATO_COMPRA_PAGO_ASISTE
    Inherits ucListaBase

    Private mComponente As New cCONTRATO_COMPRA_PAGO_ASISTE
    Public Event Seleccionado(ByVal ID_CONTRA_ASISTE As Decimal)
    Public Event Editando(ByVal ID_CONTRA_ASISTE As Decimal)
    Public Event Eliminando(ByVal ID_CONTRA_ASISTE As Decimal)

#Region "Propiedades"

    Public Property REFERENCIA() As String
        Get
            Return Me.ViewState("REFERENCIA")
        End Get
        Set(ByVal value As String)
            Me.ViewState("REFERENCIA") = value
        End Set
    End Property

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.dxgvLista.SettingsPager.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.SettingsPager.Visible = Value
        End Set
    End Property

    Public Property PermitirPaginacion() As Boolean
        Get
            If Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.ASPxGridView.GridViewPagerMode.ShowPager Then
                Return True
            End If
            Return False
        End Get
        Set(ByVal Value As Boolean)
            If Value Then
                Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.ASPxGridView.GridViewPagerMode.ShowPager
            Else
                Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.ASPxGridView.GridViewPagerMode.ShowAllRecords
            End If
        End Set
    End Property

    Private _PermitirEditar As Boolean = True
    Public Property PermitirEditar() As Boolean
        Get
            Return _PermitirEditar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEditar = Value
            If Not Me.ViewState("PermitirEditar") Is Nothing Then Me.ViewState.Remove("PermitirEditar")
            Me.ViewState.Add("PermitirEditar", Value)
        End Set
    End Property

    Private _PermitirSeleccionar As Boolean = False
    Public Property PermitirSeleccionar() As Boolean
        Get
            Return _PermitirSeleccionar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirSeleccionar = Value
            If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me.ViewState.Remove("PermitirSeleccionar")
            Me.ViewState.Add("PermitirSeleccionar", Value)
        End Set
    End Property

    Public Property PermitirEliminar() As Boolean
        Get
            Return Me.dxgvLista.Columns("Eliminar").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("Eliminar").Visible = Value
        End Set
    End Property

    Public Property PermitirAgrupar() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowGroupPanel
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Settings.ShowGroupPanel = Value
        End Set
    End Property

    Public Property PermitirFilaDeFiltro() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowFilterRow
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Settings.ShowFilterRow = value
        End Set
    End Property

    Public Property PermitirFiltroEnEncabezado() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowHeaderFilterButton
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Settings.ShowHeaderFilterButton = value
        End Set
    End Property

    Public Property PermitirEditarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEdicionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEdicionInline") = value
            Me.dxgvLista.Columns("Edicion").Visible = value
            Me.dxgvLista.SettingsEditing.Mode = GridViewEditingMode.Inline
        End Set
    End Property

    Public Property PermitirEliminarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEliminacionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEliminacionInline") = value
        End Set
    End Property

    Public Property PermitirAgregarInline() As Boolean
        Get
            Return Me.ViewState("PermitirAgregarInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirAgregarInline") = value
        End Set
    End Property

    Public Property PermitirRowHotTrack() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.EnableRowHotTrack
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.SettingsBehavior.EnableRowHotTrack = value
        End Set
    End Property

    Public Property PermitirFocoEnFilas() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.AllowFocusedRow
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.SettingsBehavior.AllowFocusedRow = value
        End Set
    End Property

    Public Property PermitirSeleccionParaCombo() As Boolean
        Get
            Return Me.ViewState("PermitirSeleccionParaCombo")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirSeleccionParaCombo") = value
        End Set
    End Property

    Public Property NombreComboCliente() As String
        Get
            Return Me.ViewState("NombreComboCliente")
        End Get
        Set(ByVal value As String)
            Me.ViewState("NombreComboCliente") = value
        End Set
    End Property

    Private _TextoSeleccionar As String = "Seleccionar"
    Public Property TextoSeleccionar() As String
        Get
            Return _TextoSeleccionar
        End Get
        Set(ByVal Value As String)
            _TextoSeleccionar = Value
            If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me.ViewState.Remove("TextoSeleccionar")
            Me.ViewState.Add("TextoSeleccionar", Value)
        End Set
    End Property

    Private _ComandoSeleccionar As String = "Select"
    Public Property ComandoSeleccionar() As String
        Get
            Return _ComandoSeleccionar
        End Get
        Set(ByVal Value As String)
            _ComandoSeleccionar = Value
            If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me.ViewState.Remove("ComandoSeleccionar")
            Me.ViewState.Add("ComandoSeleccionar", Value)
        End Set
    End Property

    Public Property TextoHeaderSeleccionar() As String
        Get
            Return Me.dxgvLista.Columns("Seleccionar").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("Seleccionar").Caption = Value
        End Set
    End Property

    Public Property NombreGridCliente() As String
        Get
            Return dxgvLista.ClientInstanceName
        End Get
        Set(ByVal value As String)
            dxgvLista.ClientInstanceName = value
        End Set
    End Property

    Public Property VerID_CONTRA_ASISTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CONTRA_ASISTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CONTRA_ASISTE").Visible = Value
        End Set
    End Property

    Public Property VerID_CONTRATO_COMPRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CONTRATO_COMPRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CONTRATO_COMPRA").Visible = Value
        End Set
    End Property

    Public Property VerID_MODALIDAD_FORMACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_MODALIDAD_FORMACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_MODALIDAD_FORMACION").Visible = Value
        End Set
    End Property

    Public Property VerPORC_ASISTE_INI() As Boolean
        Get
            Return Me.dxgvLista.Columns("PORC_ASISTE_INI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PORC_ASISTE_INI").Visible = Value
        End Set
    End Property

    Public Property VerPORC_ASISTE_FIN() As Boolean
        Get
            Return Me.dxgvLista.Columns("PORC_ASISTE_FIN").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PORC_ASISTE_FIN").Visible = Value
        End Set
    End Property

    Public Property VerPORC_PAGO_COSTO_PARTI() As Boolean
        Get
            Return Me.dxgvLista.Columns("PORC_PAGO_COSTO_PARTI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PORC_PAGO_COSTO_PARTI").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_CREA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_CREA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_CREA").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_ACT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_ACT").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_ACT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_ACT").Visible = Value
        End Set
    End Property

    Public Property HeaderID_CONTRA_ASISTE() As String
        Get
            Return Me.dxgvLista.Columns("ID_CONTRA_ASISTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CONTRA_ASISTE").Caption = Value
        End Set
    End Property

    Public Property HeaderID_CONTRATO_COMPRA() As String
        Get
            Return Me.dxgvLista.Columns("ID_CONTRATO_COMPRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CONTRATO_COMPRA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_MODALIDAD_FORMACION() As String
        Get
            Return Me.dxgvLista.Columns("ID_MODALIDAD_FORMACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_MODALIDAD_FORMACION").Caption = Value
        End Set
    End Property

    Public Property HeaderPORC_ASISTE_INI() As String
        Get
            Return Me.dxgvLista.Columns("PORC_ASISTE_INI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PORC_ASISTE_INI").Caption = Value
        End Set
    End Property

    Public Property HeaderPORC_ASISTE_FIN() As String
        Get
            Return Me.dxgvLista.Columns("PORC_ASISTE_FIN").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PORC_ASISTE_FIN").Caption = Value
        End Set
    End Property

    Public Property HeaderPORC_PAGO_COSTO_PARTI() As String
        Get
            Return Me.dxgvLista.Columns("PORC_PAGO_COSTO_PARTI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PORC_PAGO_COSTO_PARTI").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREA() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_CREA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_CREA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_CREA").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_ACT() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_ACT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_ACT").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_ACT() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_ACT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_ACT").Caption = Value
        End Set
    End Property

#End Region


    Public Function CargarDatosCache(ByVal nombreSesion As String) As Integer
        Me.REFERENCIA = nombreSesion
        Me.odsCONTRATO_COMPRA_PAGO_ASISTEcache.SelectParameters("nombreSesion_ucListaCONTRATO_COMPRA_PAGO_ASISTE").DefaultValue = nombreSesion
        Me.odsCONTRATO_COMPRA_PAGO_ASISTEcache.DataBind()
        Me.dxgvLista.DataSourceID = "odsCONTRATO_COMPRA_PAGO_ASISTEcache"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_COMPRA_PAGO_ASISTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsLista.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsLista.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsLista.DataBind()
        Me.dxgvLista.DataSourceID = "odsLista"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_COMPRA_PAGO_ASISTE
    ''' filtrado por la tabla CONTRATO_COMPRA
    ''' </summary>
    ''' <param name="ID_CONTRATO_COMPRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCONTRATO_COMPRA(ByVal ID_CONTRATO_COMPRA As Decimal) As Integer
        Me.odsListaPorCONTRATO_COMPRA.SelectParameters("ID_CONTRATO_COMPRA").DefaultValue = ID_CONTRATO_COMPRA.ToString()
        Me.odsListaPorCONTRATO_COMPRA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCONTRATO_COMPRA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCONTRATO_COMPRA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCONTRATO_COMPRA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCONTRATO_COMPRA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_COMPRA_PAGO_ASISTE
    ''' filtrado por la tabla MODALIDAD_DE_FORMACION
    ''' </summary>
    ''' <param name="ID_MODALIDAD_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMODALIDAD_DE_FORMACION(ByVal ID_MODALIDAD_FORMACION As Decimal) As Integer
        Me.odsListaPorMODALIDAD_DE_FORMACION.SelectParameters("ID_MODALIDAD_FORMACION").DefaultValue = ID_MODALIDAD_FORMACION.ToString()
        Me.odsListaPorMODALIDAD_DE_FORMACION.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorMODALIDAD_DE_FORMACION.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorMODALIDAD_DE_FORMACION.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorMODALIDAD_DE_FORMACION.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorMODALIDAD_DE_FORMACION"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub


    Protected Sub dxgvLista_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewClientJSPropertiesEventArgs) Handles dxgvLista.CustomJSProperties
        If Me.PermitirSeleccionParaCombo Then
            Dim grid As DevExpress.Web.ASPxGridView.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView.ASPxGridView)
            Dim keyNames(grid.VisibleRowCount - 1) As Object
            Dim keyValues(grid.VisibleRowCount - 1) As Object
            For i As Integer = 0 To grid.VisibleRowCount - 1
                keyValues(i) = grid.GetRowValues(i, "ID_CONTRA_ASISTE")
                keyNames(i) = grid.GetRowValues(i, "ID_CONTRATO_COMPRA")
            Next i
            e.Properties("cpKeyValues") = keyValues
            e.Properties("cpKeyNames") = keyNames
            e.Properties("cpNombreComboCliente") = Me.NombreComboCliente
        End If
    End Sub

    Protected Sub dxgvLista_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles dxgvLista.Init
        If Me.PermitirEditarInline Then
            Me.dxgvLista.Columns("Edicion").Visible = True
        Else
            Me.dxgvLista.Columns("Edicion").Visible = False
        End If
        If Me.PermitirEliminar Then
            Me.dxgvLista.Columns("Eliminar").Visible = True
        Else
            Me.dxgvLista.Columns("Eliminar").Visible = False
        End If
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
        dxgvLista.ForceDataRowType(GetType(listaCONTRATO_COMPRA_PAGO_ASISTE))
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" And ComandoSeleccionar <> "Check" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            RaiseEvent Seleccionado(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "Eliminar" Then
            Dim b As New cCONTRATO_COMPRA_PAGO_ASISTEcache

            b.Eliminar(e.KeyValue, Me.REFERENCIA)
            Me.dxgvLista.DataBind()
            Me.CargarDatosCache(Me.REFERENCIA)
            RaiseEvent Eliminando(e.KeyValue)
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaCONTRATO_COMPRA_PAGO_ASISTE
        Dim mLista As New listaCONTRATO_COMPRA_PAGO_ASISTE
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_CONTRA_ASISTE")
            Dim lEntidad As New CONTRATO_COMPRA_PAGO_ASISTE
            lEntidad.ID_CONTRA_ASISTE = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As CONTRATO_COMPRA_PAGO_ASISTE = CType(Me.dxgvLista.GetRow(e.VisibleIndex), CONTRATO_COMPRA_PAGO_ASISTE)
            If lEntidad IsNot Nothing Then
                Dim c As New cCONTRATO_COMPRA_PAGO_ASISTEcache
                c.Eliminar(lEntidad.ID_CONTRA_ASISTE, lEntidad.REFERENCIA)
            End If
            dxgvLista.DataBind()
        End If
    End Sub

    Protected Sub dxgvLista_InitNewRow(sender As Object, e As DevExpress.Web.Data.ASPxDataInitNewRowEventArgs) Handles dxgvLista.InitNewRow
        e.NewValues("REFERENCIA") = Me.REFERENCIA
    End Sub

    Protected Sub dxgvLista_RowInserting(sender As Object, e As DevExpress.Web.Data.ASPxDataInsertingEventArgs) Handles dxgvLista.RowInserting
        e.NewValues("REFERENCIA") = Me.REFERENCIA
    End Sub

    Protected Sub dxgvLista_RowUpdating(sender As Object, e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles dxgvLista.RowUpdating
        e.NewValues("REFERENCIA") = Me.REFERENCIA
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "MODALIDAD_FORMACION" Then
            Dim lEntidad As MODALIDAD_DE_FORMACION = (New cMODALIDAD_DE_FORMACION).ObtenerMODALIDAD_DE_FORMACION(e.GetListSourceFieldValue("ID_MODALIDAD_FORMACION"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.MODALIDAD_FORMACION
            End If
        End If
    End Sub
End Class
