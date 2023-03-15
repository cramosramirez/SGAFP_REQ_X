''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.FORMA_PAGO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row FORMA_PAGO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/10/2022	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="FORMA_PAGO")> Public Class FORMA_PAGO
    Inherits entidadBase
    Implements IEquatable(Of FORMA_PAGO), IComparable(Of FORMA_PAGO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_FORMA_PAGO As Decimal, aNOMBRE_PAGO As String)
        Me._ID_FORMA_PAGO = aID_FORMA_PAGO
        Me._NOMBRE_PAGO = aNOMBRE_PAGO
    End Sub

    Public Function Equals1(ByVal other As FORMA_PAGO) As Boolean Implements System.IEquatable(Of FORMA_PAGO).Equals
        Return Me.ID_FORMA_PAGO = other.ID_FORMA_PAGO
    End Function

    Public Function CompareTo(ByVal other As FORMA_PAGO) As Integer Implements System.IComparable(Of FORMA_PAGO).CompareTo
        If Me.ID_FORMA_PAGO > other.ID_FORMA_PAGO Then Return 1
        If Me.ID_FORMA_PAGO < other.ID_FORMA_PAGO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_FORMA_PAGO As Decimal
    <Column(Name:="Id forma pago", Storage:="ID_FORMA_PAGO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_FORMA_PAGO() As Decimal
        Get
            Return _ID_FORMA_PAGO
        End Get
        Set(ByVal Value As Decimal)
            _ID_FORMA_PAGO = Value
            OnPropertyChanged("ID_FORMA_PAGO")
        End Set
    End Property 

    Private _NOMBRE_PAGO As String
    <Column(Name:="Nombre pago", Storage:="NOMBRE_PAGO", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_PAGO() As String
        Get
            Return _NOMBRE_PAGO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PAGO = Value
            OnPropertyChanged("NOMBRE_PAGO")
        End Set
    End Property 

    Private _NOMBRE_PAGOOld As String
    Public Property NOMBRE_PAGOOld() As String
        Get
            Return _NOMBRE_PAGOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PAGOOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
