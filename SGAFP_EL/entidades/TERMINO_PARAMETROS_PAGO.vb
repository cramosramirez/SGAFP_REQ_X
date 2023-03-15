''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.TERMINO_PARAMETROS_PAGO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TERMINO_PARAMETROS_PAGO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2022	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TERMINO_PARAMETROS_PAGO")> Public Class TERMINO_PARAMETROS_PAGO
    Inherits entidadBase
    Implements IEquatable(Of TERMINO_PARAMETROS_PAGO), IComparable(Of TERMINO_PARAMETROS_PAGO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TERMINO_PARAM As Decimal, aDESCRIPCION As String, aTDR As String, aID_UNIDAD_ORGANIZATIVA As Decimal, aID_CENTRO_RESPONSABILIDAD As Decimal, aID_REFERENTE As Decimal, aID_FORMA_PAGO As Decimal, aPORC_ASISTENCIA_MIN As Decimal, aBASE_PARTI As Decimal, aACTIVO As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_TERMINO_PARAM = aID_TERMINO_PARAM
        Me._DESCRIPCION = aDESCRIPCION
        Me._TDR = aTDR
        Me._ID_UNIDAD_ORGANIZATIVA = aID_UNIDAD_ORGANIZATIVA
        Me._ID_CENTRO_RESPONSABILIDAD = aID_CENTRO_RESPONSABILIDAD
        Me._ID_REFERENTE = aID_REFERENTE
        Me._ID_FORMA_PAGO = aID_FORMA_PAGO
        Me._PORC_ASISTENCIA_MIN = aPORC_ASISTENCIA_MIN
        Me._BASE_PARTI = aBASE_PARTI
        Me._ACTIVO = aACTIVO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

    Public Function Equals1(ByVal other As TERMINO_PARAMETROS_PAGO) As Boolean Implements System.IEquatable(Of TERMINO_PARAMETROS_PAGO).Equals
        Return Me.ID_TERMINO_PARAM = other.ID_TERMINO_PARAM
    End Function

    Public Function CompareTo(ByVal other As TERMINO_PARAMETROS_PAGO) As Integer Implements System.IComparable(Of TERMINO_PARAMETROS_PAGO).CompareTo
        If Me.ID_TERMINO_PARAM > other.ID_TERMINO_PARAM Then Return 1
        If Me.ID_TERMINO_PARAM < other.ID_TERMINO_PARAM Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_TERMINO_PARAM As Decimal
    <Column(Name:="Id termino param", Storage:="ID_TERMINO_PARAM", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_TERMINO_PARAM() As Decimal
        Get
            Return _ID_TERMINO_PARAM
        End Get
        Set(ByVal Value As Decimal)
            _ID_TERMINO_PARAM = Value
            OnPropertyChanged("ID_TERMINO_PARAM")
        End Set
    End Property 

    Private _DESCRIPCION As String
    <Column(Name:="Descripcion", Storage:="DESCRIPCION", DbType:="VARCHAR2(1000) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1000)> _
    Public Property DESCRIPCION() As String
        Get
            Return _DESCRIPCION
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION = Value
            OnPropertyChanged("DESCRIPCION")
        End Set
    End Property 

    Private _DESCRIPCIONOld As String
    Public Property DESCRIPCIONOld() As String
        Get
            Return _DESCRIPCIONOld
        End Get
        Set(ByVal Value As String)
            _DESCRIPCIONOld = Value
        End Set
    End Property 

    Private _TDR As String
    <Column(Name:="Tdr", Storage:="TDR", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property TDR() As String
        Get
            Return _TDR
        End Get
        Set(ByVal Value As String)
            _TDR = Value
            OnPropertyChanged("TDR")
        End Set
    End Property 

    Private _TDROld As String
    Public Property TDROld() As String
        Get
            Return _TDROld
        End Get
        Set(ByVal Value As String)
            _TDROld = Value
        End Set
    End Property 

    Private _ID_UNIDAD_ORGANIZATIVA As Decimal
    <Column(Name:="Id unidad organizativa", Storage:="ID_UNIDAD_ORGANIZATIVA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_UNIDAD_ORGANIZATIVA() As Decimal
        Get
            Return _ID_UNIDAD_ORGANIZATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_UNIDAD_ORGANIZATIVA = Value
            OnPropertyChanged("ID_UNIDAD_ORGANIZATIVA")
        End Set
    End Property 

    Private _ID_UNIDAD_ORGANIZATIVAOld As Decimal
    Public Property ID_UNIDAD_ORGANIZATIVAOld() As Decimal
        Get
            Return _ID_UNIDAD_ORGANIZATIVAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_UNIDAD_ORGANIZATIVAOld = Value
        End Set
    End Property 

    Private _fkID_UNIDAD_ORGANIZATIVA As UNIDAD_ORGANIZATIVA
    Public Property fkID_UNIDAD_ORGANIZATIVA() As UNIDAD_ORGANIZATIVA
        Get
            Return _fkID_UNIDAD_ORGANIZATIVA
        End Get
        Set(ByVal Value As UNIDAD_ORGANIZATIVA)
            _fkID_UNIDAD_ORGANIZATIVA = Value
        End Set
    End Property 

    Private _ID_CENTRO_RESPONSABILIDAD As Decimal
    <Column(Name:="Id centro responsabilidad", Storage:="ID_CENTRO_RESPONSABILIDAD", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CENTRO_RESPONSABILIDAD() As Decimal
        Get
            Return _ID_CENTRO_RESPONSABILIDAD
        End Get
        Set(ByVal Value As Decimal)
            _ID_CENTRO_RESPONSABILIDAD = Value
            OnPropertyChanged("ID_CENTRO_RESPONSABILIDAD")
        End Set
    End Property 

    Private _ID_CENTRO_RESPONSABILIDADOld As Decimal
    Public Property ID_CENTRO_RESPONSABILIDADOld() As Decimal
        Get
            Return _ID_CENTRO_RESPONSABILIDADOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_CENTRO_RESPONSABILIDADOld = Value
        End Set
    End Property 

    Private _fkID_CENTRO_RESPONSABILIDAD As CENTRO_RESPONSABILIDAD
    Public Property fkID_CENTRO_RESPONSABILIDAD() As CENTRO_RESPONSABILIDAD
        Get
            Return _fkID_CENTRO_RESPONSABILIDAD
        End Get
        Set(ByVal Value As CENTRO_RESPONSABILIDAD)
            _fkID_CENTRO_RESPONSABILIDAD = Value
        End Set
    End Property 

    Private _ID_REFERENTE As Decimal
    <Column(Name:="Id referente", Storage:="ID_REFERENTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_REFERENTE() As Decimal
        Get
            Return _ID_REFERENTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_REFERENTE = Value
            OnPropertyChanged("ID_REFERENTE")
        End Set
    End Property 

    Private _ID_REFERENTEOld As Decimal
    Public Property ID_REFERENTEOld() As Decimal
        Get
            Return _ID_REFERENTEOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_REFERENTEOld = Value
        End Set
    End Property 

    Private _fkID_REFERENTE As REFERENTE
    Public Property fkID_REFERENTE() As REFERENTE
        Get
            Return _fkID_REFERENTE
        End Get
        Set(ByVal Value As REFERENTE)
            _fkID_REFERENTE = Value
        End Set
    End Property 

    Private _ID_FORMA_PAGO As Decimal
    <Column(Name:="Id forma pago", Storage:="ID_FORMA_PAGO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_FORMA_PAGO() As Decimal
        Get
            Return _ID_FORMA_PAGO
        End Get
        Set(ByVal Value As Decimal)
            _ID_FORMA_PAGO = Value
            OnPropertyChanged("ID_FORMA_PAGO")
        End Set
    End Property 

    Private _ID_FORMA_PAGOOld As Decimal
    Public Property ID_FORMA_PAGOOld() As Decimal
        Get
            Return _ID_FORMA_PAGOOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_FORMA_PAGOOld = Value
        End Set
    End Property 

    Private _fkID_FORMA_PAGO As FORMA_PAGO
    Public Property fkID_FORMA_PAGO() As FORMA_PAGO
        Get
            Return _fkID_FORMA_PAGO
        End Get
        Set(ByVal Value As FORMA_PAGO)
            _fkID_FORMA_PAGO = Value
        End Set
    End Property 

    Private _PORC_ASISTENCIA_MIN As Decimal
    <Column(Name:="Porc asistencia min", Storage:="PORC_ASISTENCIA_MIN", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_ASISTENCIA_MIN() As Decimal
        Get
            Return _PORC_ASISTENCIA_MIN
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTENCIA_MIN = Value
            OnPropertyChanged("PORC_ASISTENCIA_MIN")
        End Set
    End Property 

    Private _PORC_ASISTENCIA_MINOld As Decimal
    Public Property PORC_ASISTENCIA_MINOld() As Decimal
        Get
            Return _PORC_ASISTENCIA_MINOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTENCIA_MINOld = Value
        End Set
    End Property 

    Private _BASE_PARTI As Decimal
    <Column(Name:="Base parti", Storage:="BASE_PARTI", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property BASE_PARTI() As Decimal
        Get
            Return _BASE_PARTI
        End Get
        Set(ByVal Value As Decimal)
            _BASE_PARTI = Value
            OnPropertyChanged("BASE_PARTI")
        End Set
    End Property 

    Private _BASE_PARTIOld As Decimal
    Public Property BASE_PARTIOld() As Decimal
        Get
            Return _BASE_PARTIOld
        End Get
        Set(ByVal Value As Decimal)
            _BASE_PARTIOld = Value
        End Set
    End Property 

    Private _ACTIVO As Decimal
    <Column(Name:="Activo", Storage:="ACTIVO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=2, Scale:=0)> _
    Public Property ACTIVO() As Decimal
        Get
            Return _ACTIVO
        End Get
        Set(ByVal Value As Decimal)
            _ACTIVO = Value
            OnPropertyChanged("ACTIVO")
        End Set
    End Property 

    Private _ACTIVOOld As Decimal
    Public Property ACTIVOOld() As Decimal
        Get
            Return _ACTIVOOld
        End Get
        Set(ByVal Value As Decimal)
            _ACTIVOOld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property USUARIO_CREA() As String
        Get
            Return _USUARIO_CREA
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREA = Value
            OnPropertyChanged("USUARIO_CREA")
        End Set
    End Property 

    Private _USUARIO_CREAOld As String
    Public Property USUARIO_CREAOld() As String
        Get
            Return _USUARIO_CREAOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREAOld = Value
        End Set
    End Property 

    Private _FECHA_CREA As DateTime
    <Column(Name:="Fecha crea", Storage:="FECHA_CREA", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CREA() As DateTime
        Get
            Return _FECHA_CREA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREA = Value
            OnPropertyChanged("FECHA_CREA")
        End Set
    End Property 

    Private _FECHA_CREAOld As DateTime
    Public Property FECHA_CREAOld() As DateTime
        Get
            Return _FECHA_CREAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREAOld = Value
        End Set
    End Property 

    Private _USUARIO_ACT As String
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property USUARIO_ACT() As String
        Get
            Return _USUARIO_ACT
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACT = Value
            OnPropertyChanged("USUARIO_ACT")
        End Set
    End Property 

    Private _USUARIO_ACTOld As String
    Public Property USUARIO_ACTOld() As String
        Get
            Return _USUARIO_ACTOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACTOld = Value
        End Set
    End Property 

    Private _FECHA_ACT As DateTime
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_ACT() As DateTime
        Get
            Return _FECHA_ACT
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACT = Value
            OnPropertyChanged("FECHA_ACT")
        End Set
    End Property 

    Private _FECHA_ACTOld As DateTime
    Public Property FECHA_ACTOld() As DateTime
        Get
            Return _FECHA_ACTOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACTOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
