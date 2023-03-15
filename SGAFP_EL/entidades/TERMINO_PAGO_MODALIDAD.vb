''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.TERMINO_PAGO_MODALIDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TERMINO_PAGO_MODALIDAD en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2022	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TERMINO_PAGO_MODALIDAD")> Public Class TERMINO_PAGO_MODALIDAD
    Inherits entidadBase
    Implements IEquatable(Of TERMINO_PAGO_MODALIDAD), IComparable(Of TERMINO_PAGO_MODALIDAD)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TERMINO_MODAL As Decimal, aID_TERMINO_PARAM As Decimal, aID_MODALIDAD_FORMACION As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_TERMINO_MODAL = aID_TERMINO_MODAL
        Me._ID_TERMINO_PARAM = aID_TERMINO_PARAM
        Me._ID_MODALIDAD_FORMACION = aID_MODALIDAD_FORMACION
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

    Public Function Equals1(ByVal other As TERMINO_PAGO_MODALIDAD) As Boolean Implements System.IEquatable(Of TERMINO_PAGO_MODALIDAD).Equals
        Return Me.ID_TERMINO_MODAL = other.ID_TERMINO_MODAL
    End Function

    Public Function CompareTo(ByVal other As TERMINO_PAGO_MODALIDAD) As Integer Implements System.IComparable(Of TERMINO_PAGO_MODALIDAD).CompareTo
        If Me.ID_TERMINO_MODAL > other.ID_TERMINO_MODAL Then Return 1
        If Me.ID_TERMINO_MODAL < other.ID_TERMINO_MODAL Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_TERMINO_MODAL As Decimal
    <Column(Name:="Id termino modal", Storage:="ID_TERMINO_MODAL", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_TERMINO_MODAL() As Decimal
        Get
            Return _ID_TERMINO_MODAL
        End Get
        Set(ByVal Value As Decimal)
            _ID_TERMINO_MODAL = Value
            OnPropertyChanged("ID_TERMINO_MODAL")
        End Set
    End Property 

    Private _ID_TERMINO_PARAM As Decimal
    <Column(Name:="Id termino param", Storage:="ID_TERMINO_PARAM", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_TERMINO_PARAM() As Decimal
        Get
            Return _ID_TERMINO_PARAM
        End Get
        Set(ByVal Value As Decimal)
            _ID_TERMINO_PARAM = Value
            OnPropertyChanged("ID_TERMINO_PARAM")
        End Set
    End Property 

    Private _ID_TERMINO_PARAMOld As Decimal
    Public Property ID_TERMINO_PARAMOld() As Decimal
        Get
            Return _ID_TERMINO_PARAMOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_TERMINO_PARAMOld = Value
        End Set
    End Property 

    Private _fkID_TERMINO_PARAM As TERMINO_PARAMETROS_PAGO
    Public Property fkID_TERMINO_PARAM() As TERMINO_PARAMETROS_PAGO
        Get
            Return _fkID_TERMINO_PARAM
        End Get
        Set(ByVal Value As TERMINO_PARAMETROS_PAGO)
            _fkID_TERMINO_PARAM = Value
        End Set
    End Property 

    Private _ID_MODALIDAD_FORMACION As Decimal
    <Column(Name:="Id modalidad formacion", Storage:="ID_MODALIDAD_FORMACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_MODALIDAD_FORMACION() As Decimal
        Get
            Return _ID_MODALIDAD_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_MODALIDAD_FORMACION = Value
            OnPropertyChanged("ID_MODALIDAD_FORMACION")
        End Set
    End Property 

    Private _ID_MODALIDAD_FORMACIONOld As Decimal
    Public Property ID_MODALIDAD_FORMACIONOld() As Decimal
        Get
            Return _ID_MODALIDAD_FORMACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_MODALIDAD_FORMACIONOld = Value
        End Set
    End Property 

    Private _fkID_MODALIDAD_FORMACION As MODALIDAD_DE_FORMACION
    Public Property fkID_MODALIDAD_FORMACION() As MODALIDAD_DE_FORMACION
        Get
            Return _fkID_MODALIDAD_FORMACION
        End Get
        Set(ByVal Value As MODALIDAD_DE_FORMACION)
            _fkID_MODALIDAD_FORMACION = Value
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
