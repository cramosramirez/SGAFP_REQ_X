Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlEVALUACION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla EVALUACION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_EVALUACION_AF"), ToolboxData("<{0}:ddlEVALUACION_AF runat=server></{0}:ddlEVALUACION_AF>")> _
Public Class ddlEVALUACION_AF
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cEVALUACION_AF
        Dim Lista As New listaEVALUACION_AF

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_EVALUACION"
        Me.DataValueField = "ID_EVALUACION_AF"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla EVALUACION_AF.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ACCION_FORMATIVA .
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal)
        Dim miComponente As New cEVALUACION_AF
        Dim Lista As New listaEVALUACION_AF

        Lista = miComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_EVALUACION"
        Me.DataValueField = "ID_EVALUACION_AF"

        Me.DataBind()

    End Sub

End Class
