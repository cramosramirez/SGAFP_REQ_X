''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cTERMINO_PARAMETROS_PAGO
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla TERMINO_PARAMETROS_PAGO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cTERMINO_PARAMETROS_PAGO
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbTERMINO_PARAMETROS_PAGO()
    Private mEntidad as New TERMINO_PARAMETROS_PAGO
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaTERMINO_PARAMETROS_PAGO
        Try
            Dim mListaTERMINO_PARAMETROS_PAGO As New ListaTERMINO_PARAMETROS_PAGO
            mListaTERMINO_PARAMETROS_PAGO = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaTERMINO_PARAMETROS_PAGO Is Nothing And recuperarForaneas Then
                For Each lEntidad As TERMINO_PARAMETROS_PAGO in  mListaTERMINO_PARAMETROS_PAGO
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaTERMINO_PARAMETROS_PAGO
            If Not mListaTERMINO_PARAMETROS_PAGO Is Nothing Then
                For Each lEntidad As TERMINO_PARAMETROS_PAGO in  mListaTERMINO_PARAMETROS_PAGO
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaTERMINO_PARAMETROS_PAGO
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
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerTERMINO_PARAMETROS_PAGO(ByRef aEntidad As TERMINO_PARAMETROS_PAGO, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(aEntidad)
                Catch ex As Exception
                End Try
            End If
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla TERMINO_PARAMETROS_PAGO.
    ''' </summary>
    ''' <param name="ID_TERMINO_PARAM"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerTERMINO_PARAMETROS_PAGO(ByVal ID_TERMINO_PARAM As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As TERMINO_PARAMETROS_PAGO
        Try
            Dim lEntidad As New TERMINO_PARAMETROS_PAGO
            lEntidad.ID_TERMINO_PARAM = ID_TERMINO_PARAM
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(lEntidad)
                Catch ex As Exception
                End Try
            End If
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
    ''' Función que recupera un registro y lo setea en la Entidad que recibe de
    ''' parámetro, ademas de permitir agregar en la Entidad las Foraneas.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <param name="aUNIDAD_ORGANIZATIVA">Recuperar registro foraneo de la Entidad UNIDAD_ORGANIZATIVA.</param>
    ''' <param name="aCENTRO_RESPONSABILIDAD">Recuperar registro foraneo de la Entidad CENTRO_RESPONSABILIDAD.</param>
    ''' <param name="aREFERENTE">Recuperar registro foraneo de la Entidad REFERENTE.</param>
    ''' <param name="aFORMA_PAGO">Recuperar registro foraneo de la Entidad FORMA_PAGO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerTERMINO_PARAMETROS_PAGOConForaneas(ByVal aEntidad As TERMINO_PARAMETROS_PAGO, Optional ByVal aUNIDAD_ORGANIZATIVA As Boolean = False, Optional ByVal aCENTRO_RESPONSABILIDAD As Boolean = False, Optional ByVal aREFERENTE As Boolean = False, Optional ByVal aFORMA_PAGO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aUNIDAD_ORGANIZATIVA, aCENTRO_RESPONSABILIDAD, aREFERENTE, aFORMA_PAGO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla TERMINO_PARAMETROS_PAGO que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_TERMINO_PARAM"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarTERMINO_PARAMETROS_PAGO(ByVal ID_TERMINO_PARAM As Decimal) As Integer
        Try
            mEntidad.ID_TERMINO_PARAM = ID_TERMINO_PARAM
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla TERMINO_PARAMETROS_PAGO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarTERMINO_PARAMETROS_PAGO(ByVal aEntidad As TERMINO_PARAMETROS_PAGO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarTERMINO_PARAMETROS_PAGO(ByVal ID_TERMINO_PARAM As Decimal, ByVal DESCRIPCION As String, ByVal TDR As String, ByVal ID_UNIDAD_ORGANIZATIVA As Decimal, ByVal ID_CENTRO_RESPONSABILIDAD As Decimal, ByVal ID_REFERENTE As Decimal, ByVal ID_FORMA_PAGO As Decimal, ByVal PORC_ASISTENCIA_MIN As Decimal, ByVal BASE_PARTI As Decimal, ByVal ACTIVO As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New TERMINO_PARAMETROS_PAGO
            lEntidad.ID_TERMINO_PARAM = ID_TERMINO_PARAM
            lEntidad.DESCRIPCION = DESCRIPCION
            lEntidad.TDR = TDR
            lEntidad.ID_UNIDAD_ORGANIZATIVA = ID_UNIDAD_ORGANIZATIVA
            lEntidad.ID_CENTRO_RESPONSABILIDAD = ID_CENTRO_RESPONSABILIDAD
            lEntidad.ID_REFERENTE = ID_REFERENTE
            lEntidad.ID_FORMA_PAGO = ID_FORMA_PAGO
            lEntidad.PORC_ASISTENCIA_MIN = PORC_ASISTENCIA_MIN
            lEntidad.BASE_PARTI = BASE_PARTI
            lEntidad.ACTIVO = ACTIVO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarTERMINO_PARAMETROS_PAGO(lEntidad)
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
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarTERMINO_PARAMETROS_PAGO(ByVal aEntidad As TERMINO_PARAMETROS_PAGO) As Integer
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
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarTERMINO_PARAMETROS_PAGO(ByVal aEntidad As TERMINO_PARAMETROS_PAGO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarTERMINO_PARAMETROS_PAGO(ByVal ID_TERMINO_PARAM As Decimal, ByVal DESCRIPCION As String, ByVal TDR As String, ByVal ID_UNIDAD_ORGANIZATIVA As Decimal, ByVal ID_CENTRO_RESPONSABILIDAD As Decimal, ByVal ID_REFERENTE As Decimal, ByVal ID_FORMA_PAGO As Decimal, ByVal PORC_ASISTENCIA_MIN As Decimal, ByVal BASE_PARTI As Decimal, ByVal ACTIVO As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New TERMINO_PARAMETROS_PAGO
            lEntidad.ID_TERMINO_PARAM = ID_TERMINO_PARAM
            lEntidad.DESCRIPCION = DESCRIPCION
            lEntidad.TDR = TDR
            lEntidad.ID_UNIDAD_ORGANIZATIVA = ID_UNIDAD_ORGANIZATIVA
            lEntidad.ID_CENTRO_RESPONSABILIDAD = ID_CENTRO_RESPONSABILIDAD
            lEntidad.ID_REFERENTE = ID_REFERENTE
            lEntidad.ID_FORMA_PAGO = ID_FORMA_PAGO
            lEntidad.PORC_ASISTENCIA_MIN = PORC_ASISTENCIA_MIN
            lEntidad.BASE_PARTI = BASE_PARTI
            lEntidad.ACTIVO = ACTIVO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarTERMINO_PARAMETROS_PAGO(lEntidad)
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
    ''' 	[GenApp]	12/11/2022	Created
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
    ''' 	[GenApp]	12/11/2022	Created
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
    ''' la Tabla UNIDAD_ORGANIZATIVA .
    ''' </summary>
    ''' <param name="ID_UNIDAD_ORGANIZATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorUNIDAD_ORGANIZATIVA(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaTERMINO_PARAMETROS_PAGO
        Try
            Dim mListaTERMINO_PARAMETROS_PAGO As New ListaTERMINO_PARAMETROS_PAGO
            mListaTERMINO_PARAMETROS_PAGO = mDb.ObtenerListaPorUNIDAD_ORGANIZATIVA(ID_UNIDAD_ORGANIZATIVA, asColumnaOrden, asTipoOrden)
            If Not mListaTERMINO_PARAMETROS_PAGO Is Nothing And recuperarForaneas Then
                For Each lEntidad As TERMINO_PARAMETROS_PAGO in  mListaTERMINO_PARAMETROS_PAGO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaTERMINO_PARAMETROS_PAGO
            If Not mListaTERMINO_PARAMETROS_PAGO Is Nothing Then
                For Each lEntidad As TERMINO_PARAMETROS_PAGO in  mListaTERMINO_PARAMETROS_PAGO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaTERMINO_PARAMETROS_PAGO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CENTRO_RESPONSABILIDAD .
    ''' </summary>
    ''' <param name="ID_CENTRO_RESPONSABILIDAD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCENTRO_RESPONSABILIDAD(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaTERMINO_PARAMETROS_PAGO
        Try
            Dim mListaTERMINO_PARAMETROS_PAGO As New ListaTERMINO_PARAMETROS_PAGO
            mListaTERMINO_PARAMETROS_PAGO = mDb.ObtenerListaPorCENTRO_RESPONSABILIDAD(ID_CENTRO_RESPONSABILIDAD, asColumnaOrden, asTipoOrden)
            If Not mListaTERMINO_PARAMETROS_PAGO Is Nothing And recuperarForaneas Then
                For Each lEntidad As TERMINO_PARAMETROS_PAGO in  mListaTERMINO_PARAMETROS_PAGO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaTERMINO_PARAMETROS_PAGO
            If Not mListaTERMINO_PARAMETROS_PAGO Is Nothing Then
                For Each lEntidad As TERMINO_PARAMETROS_PAGO in  mListaTERMINO_PARAMETROS_PAGO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaTERMINO_PARAMETROS_PAGO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla REFERENTE .
    ''' </summary>
    ''' <param name="ID_REFERENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorREFERENTE(ByVal ID_REFERENTE As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaTERMINO_PARAMETROS_PAGO
        Try
            Dim mListaTERMINO_PARAMETROS_PAGO As New ListaTERMINO_PARAMETROS_PAGO
            mListaTERMINO_PARAMETROS_PAGO = mDb.ObtenerListaPorREFERENTE(ID_REFERENTE, asColumnaOrden, asTipoOrden)
            If Not mListaTERMINO_PARAMETROS_PAGO Is Nothing And recuperarForaneas Then
                For Each lEntidad As TERMINO_PARAMETROS_PAGO in  mListaTERMINO_PARAMETROS_PAGO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaTERMINO_PARAMETROS_PAGO
            If Not mListaTERMINO_PARAMETROS_PAGO Is Nothing Then
                For Each lEntidad As TERMINO_PARAMETROS_PAGO in  mListaTERMINO_PARAMETROS_PAGO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaTERMINO_PARAMETROS_PAGO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla FORMA_PAGO .
    ''' </summary>
    ''' <param name="ID_FORMA_PAGO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorFORMA_PAGO(ByVal ID_FORMA_PAGO As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaTERMINO_PARAMETROS_PAGO
        Try
            Dim mListaTERMINO_PARAMETROS_PAGO As New ListaTERMINO_PARAMETROS_PAGO
            mListaTERMINO_PARAMETROS_PAGO = mDb.ObtenerListaPorFORMA_PAGO(ID_FORMA_PAGO, asColumnaOrden, asTipoOrden)
            If Not mListaTERMINO_PARAMETROS_PAGO Is Nothing And recuperarForaneas Then
                For Each lEntidad As TERMINO_PARAMETROS_PAGO in  mListaTERMINO_PARAMETROS_PAGO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaTERMINO_PARAMETROS_PAGO
            If Not mListaTERMINO_PARAMETROS_PAGO Is Nothing Then
                For Each lEntidad As TERMINO_PARAMETROS_PAGO in  mListaTERMINO_PARAMETROS_PAGO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaTERMINO_PARAMETROS_PAGO
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
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As TERMINO_PARAMETROS_PAGO )
        aEntidad.fkID_UNIDAD_ORGANIZATIVA = (New cUNIDAD_ORGANIZATIVA).ObtenerUNIDAD_ORGANIZATIVA(aEntidad.ID_UNIDAD_ORGANIZATIVA)
        aEntidad.fkID_CENTRO_RESPONSABILIDAD = (New cCENTRO_RESPONSABILIDAD).ObtenerCENTRO_RESPONSABILIDAD(aEntidad.ID_CENTRO_RESPONSABILIDAD)
        aEntidad.fkID_REFERENTE = (New cREFERENTE).ObtenerREFERENTE(aEntidad.ID_REFERENTE)
        aEntidad.fkID_FORMA_PAGO = (New cFORMA_PAGO).ObtenerFORMA_PAGO(aEntidad.ID_FORMA_PAGO)
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
    ''' 	[GenApp]	12/11/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As TERMINO_PARAMETROS_PAGO )
    End Sub

#End Region

End Class
