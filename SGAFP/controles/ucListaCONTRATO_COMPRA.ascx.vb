Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaCONTRATO_COMPRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla CONTRATO_COMPRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/10/2021	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaCONTRATO_COMPRA
    Inherits ucListaBase
 
    Private mComponente As New cCONTRATO_COMPRA
    Public Event Seleccionado(ByVal ID_CONTRATO_COMPRA As Decimal) 
    Public Event Editando(ByVal ID_CONTRATO_COMPRA As Decimal) 

#Region"Propiedades"

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

    Public Property VerID_CONTRATO_COMPRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CONTRATO_COMPRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CONTRATO_COMPRA").Visible = Value
        End Set
    End Property

    Public Property VerNO_CONTRATO_COMPRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_CONTRATO_COMPRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_CONTRATO_COMPRA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_INGRESO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_INGRESO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_INGRESO").Visible = Value
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

    Public Property VerFECHA_INI_EJEC() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_INI_EJEC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_INI_EJEC").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_FIN_EJEC() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_FIN_EJEC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_FIN_EJEC").Visible = Value
        End Set
    End Property

    Public Property VerPORC_ASISTENCIA_MIN() As Boolean
        Get
            Return Me.dxgvLista.Columns("PORC_ASISTENCIA_MIN").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PORC_ASISTENCIA_MIN").Visible = Value
        End Set
    End Property

    Public Property VerPAGO_POR_PARTICIPACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("PAGO_POR_PARTICIPACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PAGO_POR_PARTICIPACION").Visible = Value
        End Set
    End Property

    Public Property VerBASE_PARTI() As Boolean
        Get
            Return Me.dxgvLista.Columns("BASE_PARTI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("BASE_PARTI").Visible = Value
        End Set
    End Property

    Public Property VerULTFECHA_CALENDARIZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ULTFECHA_CALENDARIZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ULTFECHA_CALENDARIZA").Visible = Value
        End Set
    End Property

    Public Property VerID_UNIDAD_ORGANIZATIVA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_UNIDAD_ORGANIZATIVA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_UNIDAD_ORGANIZATIVA").Visible = Value
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

    Public Property HeaderNO_CONTRATO_COMPRA() As String
        Get
            Return Me.dxgvLista.Columns("NO_CONTRATO_COMPRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_CONTRATO_COMPRA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_INGRESO() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_INGRESO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_INGRESO").Caption = Value
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

    Public Property HeaderFECHA_INI_EJEC() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_INI_EJEC").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_INI_EJEC").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_FIN_EJEC() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_FIN_EJEC").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_FIN_EJEC").Caption = Value
        End Set
    End Property

    Public Property HeaderPORC_ASISTENCIA_MIN() As String
        Get
            Return Me.dxgvLista.Columns("PORC_ASISTENCIA_MIN").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PORC_ASISTENCIA_MIN").Caption = Value
        End Set
    End Property

    Public Property HeaderPAGO_POR_PARTICIPACION() As String
        Get
            Return Me.dxgvLista.Columns("PAGO_POR_PARTICIPACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PAGO_POR_PARTICIPACION").Caption = Value
        End Set
    End Property

    Public Property HeaderBASE_PARTI() As String
        Get
            Return Me.dxgvLista.Columns("BASE_PARTI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("BASE_PARTI").Caption = Value
        End Set
    End Property

    Public Property HeaderULTFECHA_CALENDARIZA() As String
        Get
            Return Me.dxgvLista.Columns("ULTFECHA_CALENDARIZA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ULTFECHA_CALENDARIZA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_UNIDAD_ORGANIZATIVA() As String
        Get
            Return Me.dxgvLista.Columns("ID_UNIDAD_ORGANIZATIVA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_UNIDAD_ORGANIZATIVA").Caption = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_COMPRA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/10/2021	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarHijas").DefaultValue = "False"
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
    ''' Función que Carga la información de los registros de la tabla CONTRATO_COMPRA
    ''' filtrado por la tabla UNIDAD_ORGANIZATIVA
    ''' </summary>
    ''' <param name="ID_UNIDAD_ORGANIZATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/10/2021	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorUNIDAD_ORGANIZATIVA(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal) As Integer
        Me.odsListaPorUNIDAD_ORGANIZATIVA.SelectParameters("ID_UNIDAD_ORGANIZATIVA").DefaultValue = ID_UNIDAD_ORGANIZATIVA.ToString()
        Me.odsListaPorUNIDAD_ORGANIZATIVA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorUNIDAD_ORGANIZATIVA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorUNIDAD_ORGANIZATIVA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorUNIDAD_ORGANIZATIVA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorUNIDAD_ORGANIZATIVA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorUNIDAD_ORGANIZATIVA"
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
                keyValues(i) = grid.GetRowValues(i, "ID_CONTRATO_COMPRA")
                keyNames(i) = grid.GetRowValues(i, "NO_CONTRATO_COMPRA")
            Next i
            e.Properties("cpKeyValues") = keyValues
            e.Properties("cpKeyNames") = keyNames
            e.Properties("cpNombreComboCliente") = Me.NombreComboCliente
        End If
    End Sub

    Protected Sub dxgvLista_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles dxgvLista.Init
        If Me.PermitirSeleccionar And Me.ComandoSeleccionar = "Check" Then
            Me.dxgvLista.Columns("Seleccionar").Visible = True
            CType(Me.dxgvLista.Columns("Seleccionar"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).ShowSelectCheckbox = True
        End If
        If Me.PermitirEditarInline Or Me.PermitirAgregarInline Or Me.PermitirEliminarInline Then
            Me.dxgvLista.Columns("Edicion").Visible = True
            'CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).ShowNewButton = Me.PermitirAgregarInline
            'CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).ShowEditButton = Me.PermitirEditarInline
            'CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).ShowDeleteButton = Me.PermitirEliminarInline
        End If
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
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
    End Sub

    Public Function DevolverSeleccionados() As listaCONTRATO_COMPRA
        Dim mLista As New listaCONTRATO_COMPRA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_CONTRATO_COMPRA")
            Dim lEntidad As New CONTRATO_COMPRA
            lEntidad.ID_CONTRATO_COMPRA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As CONTRATO_COMPRA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), CONTRATO_COMPRA)

            If Me.mComponente.EliminarCONTRATO_COMPRA(lEntidad.ID_CONTRATO_COMPRA) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "UNIDAD_ORGANIZATIVA" Then
            Dim lEntidad As UNIDAD_ORGANIZATIVA = (New cUNIDAD_ORGANIZATIVA).ObtenerUNIDAD_ORGANIZATIVA(e.GetListSourceFieldValue("ID_UNIDAD_ORGANIZATIVA"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE_UNIDAD
            End If
        ElseIf e.Column.FieldName = "NOMBRE_USUARIO_CREA" Then
            Dim lEntidad As USUARIO = (New cUSUARIO).ObtenerUSUARIO(e.GetListSourceFieldValue("USUARIO_CREA"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE
            End If
        ElseIf e.Column.FieldName = "MODALIDAD" Then
            Dim lEntidadModa As MODALIDAD_DE_FORMACION
            Dim strModalidades As New StringBuilder
            Dim idContratoCompra As Decimal = e.GetListSourceFieldValue("ID_CONTRATO_COMPRA")
            Dim lista As listaCONTRATO_COMPRA_MODALIDAD = (New cCONTRATO_COMPRA_MODALIDAD).ObtenerListaPorCONTRATO_COMPRA(idContratoCompra)
            If lista IsNot Nothing AndAlso lista.Count > 0 Then
                For i As Integer = 0 To lista.Count - 1
                    lEntidadModa = (New cMODALIDAD_DE_FORMACION).ObtenerMODALIDAD_DE_FORMACION(lista(i).ID_MODALIDAD_FORMACION)
                    If lEntidadModa IsNot Nothing Then
                        If strModalidades.ToString = "" Then
                            strModalidades.Append(lEntidadModa.MODALIDAD_FORMACION)
                        Else
                            strModalidades.Append(" / ")
                            strModalidades.Append(lEntidadModa.MODALIDAD_FORMACION)
                        End If
                    End If
                Next
            End If
            e.Value = strModalidades.ToString
        ElseIf e.Column.FieldName = "FORMA_PAGO" Then
            Dim lEntidad As FORMA_PAGO = (New cFORMA_PAGO).ObtenerFORMA_PAGO(e.GetListSourceFieldValue("ID_FORMA_PAGO"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE_PAGO
            End If
        ElseIf e.Column.FieldName = "NUM_BASE_PARTI" Then
            Dim base As Decimal = e.GetListSourceFieldValue("BASE_PARTI")
            If base <= 0 Then
                e.Value = ""
            Else
                e.Value = base.ToString
            End If
        End If
    End Sub
End Class
