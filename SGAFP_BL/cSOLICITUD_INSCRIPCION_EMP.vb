''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cSOLICITUD_INSCRIPCION_EMP
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SOLICITUD_INSCRIPCION_EMP
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/03/2023	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSOLICITUD_INSCRIPCION_EMP
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSOLICITUD_INSCRIPCION_EMP()
    Private mEntidad as New SOLICITUD_INSCRIPCION_EMP
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_EMP
        Try
            Dim mListaSOLICITUD_INSCRIPCION_EMP As New ListaSOLICITUD_INSCRIPCION_EMP
            mListaSOLICITUD_INSCRIPCION_EMP = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_EMP Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_EMP in  mListaSOLICITUD_INSCRIPCION_EMP
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_EMP
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSOLICITUD_INSCRIPCION_EMP(ByRef aEntidad As SOLICITUD_INSCRIPCION_EMP, ByVal Optional recuperarForaneas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(aEntidad)
                Catch ex As Exception
                End Try
            End If
            Return liRet
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SOLICITUD_INSCRIPCION_EMP.
    ''' </summary>
    ''' <param name="ID_SOLIC_EMP"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSOLICITUD_INSCRIPCION_EMP(ByVal ID_SOLIC_EMP As Decimal, ByVal Optional recuperarForaneas As Boolean = False) As SOLICITUD_INSCRIPCION_EMP
        Try
            Dim lEntidad As New SOLICITUD_INSCRIPCION_EMP
            lEntidad.ID_SOLIC_EMP = ID_SOLIC_EMP
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(lEntidad)
                Catch ex As Exception
                End Try
            End If
            If liRet = 1 Then Return lEntidad
            Return Nothing
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera un registro y lo setea en la Entidad que recibe de
    ''' parámetro, ademas de permitir agregar en la Entidad las Foraneas.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <param name="aSOLICITUD_INSCRIPCION_AF">Recuperar registro foraneo de la Entidad SOLICITUD_INSCRIPCION_AF.</param>
    ''' <param name="aEMPRESA">Recuperar registro foraneo de la Entidad EMPRESA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSOLICITUD_INSCRIPCION_EMPConForaneas(ByVal aEntidad As SOLICITUD_INSCRIPCION_EMP, Optional ByVal aSOLICITUD_INSCRIPCION_AF As Boolean = False, Optional ByVal aEMPRESA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aSOLICITUD_INSCRIPCION_AF, aEMPRESA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_INSCRIPCION_EMP que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SOLIC_EMP"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLICITUD_INSCRIPCION_EMP(ByVal ID_SOLIC_EMP As Decimal) As Integer
        Try
            mEntidad.ID_SOLIC_EMP = ID_SOLIC_EMP
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_INSCRIPCION_EMP que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLICITUD_INSCRIPCION_EMP(ByVal aEntidad As SOLICITUD_INSCRIPCION_EMP, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro que recibe como parámetro.
    ''' </summary>
    ''' <remarks>Se reciben los parametros uno a uno para la entidad 
    ''' y son asignados a una entidad y se ejecuta el Metodo Actualizar
    ''' o Agregar mandando la entidad de parametro.</remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLICITUD_INSCRIPCION_EMP(ByVal ID_SOLIC_EMP As Decimal, ByVal ID_SOLICITUD As Decimal, ByVal ID_EMPRESA As Decimal) As Integer
        Try
            Dim lEntidad As New SOLICITUD_INSCRIPCION_EMP
            lEntidad.ID_SOLIC_EMP = ID_SOLIC_EMP
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_EMPRESA = ID_EMPRESA
            Return Me.ActualizarSOLICITUD_INSCRIPCION_EMP(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_INSCRIPCION_EMP(ByVal aEntidad As SOLICITUD_INSCRIPCION_EMP) As Integer
        Try
            Return mDb.Actualizar(aEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_INSCRIPCION_EMP(ByVal aEntidad As SOLICITUD_INSCRIPCION_EMP, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_INSCRIPCION_EMP(ByVal ID_SOLIC_EMP As Decimal, ByVal ID_SOLICITUD As Decimal, ByVal ID_EMPRESA As Decimal) As Integer
        Try
            Dim lEntidad As New SOLICITUD_INSCRIPCION_EMP
            lEntidad.ID_SOLIC_EMP = ID_SOLIC_EMP
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_EMPRESA = ID_EMPRESA
            Return Me.ActualizarSOLICITUD_INSCRIPCION_EMP(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre devuelve todos los registros de la Entidad.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorId(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorID(asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, False)> _
    Public Function ObtenerDataSetPorId(ByRef ds As DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer
        Try
            Return mDb.ObtenerDataSetPorID(ds, asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SOLICITUD_INSCRIPCION_AF .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_EMP
        Try
            Dim mListaSOLICITUD_INSCRIPCION_EMP As New ListaSOLICITUD_INSCRIPCION_EMP
            mListaSOLICITUD_INSCRIPCION_EMP = mDb.ObtenerListaPorSOLICITUD_INSCRIPCION_AF(ID_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_EMP Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_EMP in  mListaSOLICITUD_INSCRIPCION_EMP
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_EMP
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla EMPRESA .
    ''' </summary>
    ''' <param name="ID_EMPRESA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorEMPRESA(ByVal ID_EMPRESA As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_EMP
        Try
            Dim mListaSOLICITUD_INSCRIPCION_EMP As New ListaSOLICITUD_INSCRIPCION_EMP
            mListaSOLICITUD_INSCRIPCION_EMP = mDb.ObtenerListaPorEMPRESA(ID_EMPRESA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_EMP Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_EMP in  mListaSOLICITUD_INSCRIPCION_EMP
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_EMP
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera y Asigna los valores de la Tabla Foranea en la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SOLICITUD_INSCRIPCION_EMP )
        aEntidad.fkID_SOLICITUD = (New cSOLICITUD_INSCRIPCION_AF).ObtenerSOLICITUD_INSCRIPCION_AF(aEntidad.ID_SOLICITUD)
        aEntidad.fkID_EMPRESA = (New cEMPRESA).ObtenerEMPRESA(aEntidad.ID_EMPRESA)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera y Asigna los valores de las Tablas Hijas de la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/03/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SOLICITUD_INSCRIPCION_EMP )
    End Sub

#End Region

End Class
