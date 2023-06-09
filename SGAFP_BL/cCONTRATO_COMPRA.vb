''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cCONTRATO_COMPRA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla CONTRATO_COMPRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/06/2016	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cCONTRATO_COMPRA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbCONTRATO_COMPRA()
    Private mEntidad as New CONTRATO_COMPRA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/06/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_COMPRA
        Try
            Dim mListaCONTRATO_COMPRA As New ListaCONTRATO_COMPRA
            mListaCONTRATO_COMPRA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not recuperarHijas Then Return mListaCONTRATO_COMPRA
            If Not mListaCONTRATO_COMPRA Is Nothing Then
                For Each lEntidad As CONTRATO_COMPRA in  mListaCONTRATO_COMPRA
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_COMPRA
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
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	30/06/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCONTRATO_COMPRA(ByRef aEntidad As CONTRATO_COMPRA, ByVal Optional recuperarHijas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
            If Not recuperarHijas Then Return liRet
            If liRet > 0 Then
                Try
                    Me.RecuperarHijas(aEntidad)
                Catch ex as Exception
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla CONTRATO_COMPRA.
    ''' </summary>
    ''' <param name="ID_CONTRATO_COMPRA"></param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/06/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerCONTRATO_COMPRA(ByVal ID_CONTRATO_COMPRA As Decimal, ByVal Optional recuperarHijas As Boolean = False) As CONTRATO_COMPRA
        Try
            Dim lEntidad As New CONTRATO_COMPRA
            lEntidad.ID_CONTRATO_COMPRA = ID_CONTRATO_COMPRA
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If Not recuperarHijas Then
                If liRet = 1 Then Return lEntidad
                Return Nothing
            End If
            If liRet > 0 Then
                Try
                    Me.RecuperarHijas(lEntidad)
                Catch ex as Exception
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
    ''' Función que Elimina un Registro de la Tabla CONTRATO_COMPRA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_CONTRATO_COMPRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/06/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTRATO_COMPRA(ByVal ID_CONTRATO_COMPRA As Decimal) As Integer
        Try
            mEntidad.ID_CONTRATO_COMPRA = ID_CONTRATO_COMPRA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTRATO_COMPRA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/06/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTRATO_COMPRA(ByVal aEntidad As CONTRATO_COMPRA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	30/06/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCONTRATO_COMPRA(ByVal ID_CONTRATO_COMPRA As Decimal, ByVal NO_CONTRATO_COMPRA As String, ByVal FECHA_INGRESO As DateTime, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal FECHA_INI_EJEC As DateTime, ByVal FECHA_FIN_EJEC As DateTime, ByVal PORC_ASISTENCIA_MIN As Decimal, ByVal PAGO_POR_PARTICIPACION As Decimal, ByVal BASE_PARTI As Decimal, ByVal ULTFECHA_CALENDARIZA As DateTime, ByVal ID_UNIDAD_ORGANIZATIVA As Decimal, ByVal ID_FORMA_PAGO As Decimal) As Integer
        Try
            Dim lEntidad As New CONTRATO_COMPRA
            lEntidad.ID_CONTRATO_COMPRA = ID_CONTRATO_COMPRA
            lEntidad.NO_CONTRATO_COMPRA = NO_CONTRATO_COMPRA
            lEntidad.FECHA_INGRESO = FECHA_INGRESO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.FECHA_INI_EJEC = FECHA_INI_EJEC
            lEntidad.FECHA_FIN_EJEC = FECHA_FIN_EJEC
            lEntidad.PORC_ASISTENCIA_MIN = PORC_ASISTENCIA_MIN
            lEntidad.PAGO_POR_PARTICIPACION = PAGO_POR_PARTICIPACION
            lEntidad.BASE_PARTI = BASE_PARTI
            lEntidad.ULTFECHA_CALENDARIZA = ULTFECHA_CALENDARIZA
            lEntidad.ID_UNIDAD_ORGANIZATIVA = ID_UNIDAD_ORGANIZATIVA
            lEntidad.ID_FORMA_PAGO = ID_FORMA_PAGO
            Return Me.ActualizarCONTRATO_COMPRA(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	30/06/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTRATO_COMPRA(ByVal aEntidad As CONTRATO_COMPRA) As Integer
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
    ''' 	[GenApp]	30/06/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTRATO_COMPRA(ByVal aEntidad As CONTRATO_COMPRA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	30/06/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTRATO_COMPRA(ByVal ID_CONTRATO_COMPRA As Decimal, ByVal NO_CONTRATO_COMPRA As String, ByVal FECHA_INGRESO As DateTime, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal FECHA_INI_EJEC As DateTime, ByVal FECHA_FIN_EJEC As DateTime, ByVal PORC_ASISTENCIA_MIN As Decimal, ByVal PAGO_POR_PARTICIPACION As Decimal, ByVal BASE_PARTI As Decimal, ByVal ULTFECHA_CALENDARIZA As DateTime, ByVal ID_UNIDAD_ORGANIZATIVA As Decimal, ByVal ID_FORMA_PAGO As Decimal) As Integer
        Try
            Dim lEntidad As New CONTRATO_COMPRA
            lEntidad.ID_CONTRATO_COMPRA = ID_CONTRATO_COMPRA
            lEntidad.NO_CONTRATO_COMPRA = NO_CONTRATO_COMPRA
            lEntidad.FECHA_INGRESO = FECHA_INGRESO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.FECHA_INI_EJEC = FECHA_INI_EJEC
            lEntidad.FECHA_FIN_EJEC = FECHA_FIN_EJEC
            lEntidad.PORC_ASISTENCIA_MIN = PORC_ASISTENCIA_MIN
            lEntidad.PAGO_POR_PARTICIPACION = PAGO_POR_PARTICIPACION
            lEntidad.BASE_PARTI = BASE_PARTI
            lEntidad.ULTFECHA_CALENDARIZA = ULTFECHA_CALENDARIZA
            lEntidad.ID_UNIDAD_ORGANIZATIVA = ID_UNIDAD_ORGANIZATIVA
            lEntidad.ID_FORMA_PAGO = ID_FORMA_PAGO
            Return Me.ActualizarCONTRATO_COMPRA(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	30/06/2016	Created
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
    ''' 	[GenApp]	30/06/2016	Created
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
    ''' Función que Recupera y Asigna los valores de las Tablas Hijas de la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/06/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As CONTRATO_COMPRA )
    End Sub

#End Region

End Class
