''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CONTRATO_COMPRA_PAGO_ASISTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CONTRATO_COMPRA_PAGO_ASISTE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/10/2022	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CONTRATO_COMPRA_PAGO_ASISTE")> Public Class CONTRATO_COMPRA_PAGO_ASISTE
    Inherits entidadBase
    Implements IEquatable(Of CONTRATO_COMPRA_PAGO_ASISTE), IComparable(Of CONTRATO_COMPRA_PAGO_ASISTE)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CONTRA_ASISTE As Decimal, aID_CONTRATO_COMPRA As Decimal, aID_MODALIDAD_FORMACION As Decimal, aPORC_ASISTE_INI As Decimal, aPORC_ASISTE_FIN As Decimal, aPORC_PAGO_COSTO_PARTI As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_CONTRA_ASISTE = aID_CONTRA_ASISTE
        Me._ID_CONTRATO_COMPRA = aID_CONTRATO_COMPRA
        Me._ID_MODALIDAD_FORMACION = aID_MODALIDAD_FORMACION
        Me._PORC_ASISTE_INI = aPORC_ASISTE_INI
        Me._PORC_ASISTE_FIN = aPORC_ASISTE_FIN
        Me._PORC_PAGO_COSTO_PARTI = aPORC_PAGO_COSTO_PARTI
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

    Public Function Equals1(ByVal other As CONTRATO_COMPRA_PAGO_ASISTE) As Boolean Implements System.IEquatable(Of CONTRATO_COMPRA_PAGO_ASISTE).Equals
        Return Me.ID_CONTRA_ASISTE = other.ID_CONTRA_ASISTE
    End Function

    Public Function CompareTo(ByVal other As CONTRATO_COMPRA_PAGO_ASISTE) As Integer Implements System.IComparable(Of CONTRATO_COMPRA_PAGO_ASISTE).CompareTo
        If Me.ID_CONTRA_ASISTE > other.ID_CONTRA_ASISTE Then Return 1
        If Me.ID_CONTRA_ASISTE < other.ID_CONTRA_ASISTE Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_CONTRA_ASISTE As Decimal
    <Column(Name:="Id contra asiste", Storage:="ID_CONTRA_ASISTE", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CONTRA_ASISTE() As Decimal
        Get
            Return _ID_CONTRA_ASISTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRA_ASISTE = Value
            OnPropertyChanged("ID_CONTRA_ASISTE")
        End Set
    End Property 

    Private _ID_CONTRATO_COMPRA As Decimal
    <Column(Name:="Id contrato compra", Storage:="ID_CONTRATO_COMPRA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CONTRATO_COMPRA() As Decimal
        Get
            Return _ID_CONTRATO_COMPRA
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATO_COMPRA = Value
            OnPropertyChanged("ID_CONTRATO_COMPRA")
        End Set
    End Property 

    Private _ID_CONTRATO_COMPRAOld As Decimal
    Public Property ID_CONTRATO_COMPRAOld() As Decimal
        Get
            Return _ID_CONTRATO_COMPRAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATO_COMPRAOld = Value
        End Set
    End Property 

    Private _fkID_CONTRATO_COMPRA As CONTRATO_COMPRA
    Public Property fkID_CONTRATO_COMPRA() As CONTRATO_COMPRA
        Get
            Return _fkID_CONTRATO_COMPRA
        End Get
        Set(ByVal Value As CONTRATO_COMPRA)
            _fkID_CONTRATO_COMPRA = Value
        End Set
    End Property 

    Private _ID_MODALIDAD_FORMACION As Decimal
    <Column(Name:="Id modalidad formacion", Storage:="ID_MODALIDAD_FORMACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
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

    Private _PORC_ASISTE_INI As Decimal
    <Column(Name:="Porc asiste ini", Storage:="PORC_ASISTE_INI", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_ASISTE_INI() As Decimal
        Get
            Return _PORC_ASISTE_INI
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTE_INI = Value
            OnPropertyChanged("PORC_ASISTE_INI")
        End Set
    End Property 

    Private _PORC_ASISTE_INIOld As Decimal
    Public Property PORC_ASISTE_INIOld() As Decimal
        Get
            Return _PORC_ASISTE_INIOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTE_INIOld = Value
        End Set
    End Property 

    Private _PORC_ASISTE_FIN As Decimal
    <Column(Name:="Porc asiste fin", Storage:="PORC_ASISTE_FIN", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_ASISTE_FIN() As Decimal
        Get
            Return _PORC_ASISTE_FIN
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTE_FIN = Value
            OnPropertyChanged("PORC_ASISTE_FIN")
        End Set
    End Property 

    Private _PORC_ASISTE_FINOld As Decimal
    Public Property PORC_ASISTE_FINOld() As Decimal
        Get
            Return _PORC_ASISTE_FINOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTE_FINOld = Value
        End Set
    End Property 

    Private _PORC_PAGO_COSTO_PARTI As Decimal
    <Column(Name:="Porc pago costo parti", Storage:="PORC_PAGO_COSTO_PARTI", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_PAGO_COSTO_PARTI() As Decimal
        Get
            Return _PORC_PAGO_COSTO_PARTI
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PAGO_COSTO_PARTI = Value
            OnPropertyChanged("PORC_PAGO_COSTO_PARTI")
        End Set
    End Property 

    Private _PORC_PAGO_COSTO_PARTIOld As Decimal
    Public Property PORC_PAGO_COSTO_PARTIOld() As Decimal
        Get
            Return _PORC_PAGO_COSTO_PARTIOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PAGO_COSTO_PARTIOld = Value
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
