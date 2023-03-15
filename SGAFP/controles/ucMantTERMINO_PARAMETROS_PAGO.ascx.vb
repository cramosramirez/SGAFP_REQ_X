Imports SGAFP.BL
Imports SGAFP.EL

Partial Class controles_ucMantTERMINO_PARAMETROS_PAGO
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CONTRATO_COMPRA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/10/2021	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = True
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucListaTERMINO_PARAMETROS_PAGO1.Visible = True
        Me.ucVistaDetalleTERMINO_PARAMETROS_PAGO1.Visible = False
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CONTRATO_COMPRA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/10/2021	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaTERMINO_PARAMETROS_PAGO1.Visible = False
        Me.ucVistaDetalleTERMINO_PARAMETROS_PAGO1.Visible = True
    End Sub
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
        Try
            Return Me.CargarTERMINO_PARAMETROS_PAGO()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarTERMINO_PARAMETROS_PAGO() As Integer
        If Me.ucListaTERMINO_PARAMETROS_PAGO1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.InicializarLista()
        End If
    End Sub

    Private Sub UcBarraNavegacion1_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Agregar
        Me.InicializarDetalle()
        Me.ucVistaDetalleTERMINO_PARAMETROS_PAGO1.LimpiarControles()
        Me.ucVistaDetalleTERMINO_PARAMETROS_PAGO1.ID_TERMINO_PARAM = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.ucVistaDetalleTERMINO_PARAMETROS_PAGO1.Actualizar()
        If sError <> "" Then
            AsignarMensaje(sError, False, True)
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaTERMINO_PARAMETROS_PAGO1_Editando(ByVal ID_TERMINO_PARAM As Decimal) Handles ucListaTERMINO_PARAMETROS_PAGO1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetalleTERMINO_PARAMETROS_PAGO1.ID_TERMINO_PARAM = ID_TERMINO_PARAM
    End Sub

    Private Sub ucVistaDetalleTERMINO_PARAMETROS_PAGO1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetalleTERMINO_PARAMETROS_PAGO1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub
End Class
