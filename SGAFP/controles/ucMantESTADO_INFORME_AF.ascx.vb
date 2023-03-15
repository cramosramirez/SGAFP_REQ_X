Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantESTADO_INFORME_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla ESTADO_INFORME_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/07/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantESTADO_INFORME_AF
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ESTADO_INFORME_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = True
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucListaESTADO_INFORME_AF1.Visible = True
        Me.UcVistaDetalleESTADO_INFORME_AF1.Visible = False
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ESTADO_INFORME_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaESTADO_INFORME_AF1.Visible = False
        Me.UcVistaDetalleESTADO_INFORME_AF1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ESTADO_INFORME_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Return Me.CargarESTADO_INFORME_AF()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarESTADO_INFORME_AF() As Integer
        If Me.ucListaESTADO_INFORME_AF1.CargarDatos() <> 1 Then Return -1
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
        Me.UcVistaDetalleESTADO_INFORME_AF1.LimpiarControles()
        Me.ucVistaDetalleESTADO_INFORME_AF1.ID_ESTADO_INFORME = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetalleESTADO_INFORME_AF1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaESTADO_INFORME_AF1_Editando(ByVal ID_ESTADO_INFORME As Decimal) Handles ucListaESTADO_INFORME_AF1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetalleESTADO_INFORME_AF1.ID_ESTADO_INFORME = ID_ESTADO_INFORME
    End Sub

    Private Sub ucVistaDetalleESTADO_INFORME_AF1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleESTADO_INFORME_AF1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

End Class
