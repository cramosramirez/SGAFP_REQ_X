''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.EMPRESA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row EMPRESA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/03/2023	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="EMPRESA")> Public Class EMPRESA
    Inherits entidadBase
    Implements IEquatable(Of EMPRESA), IComparable(Of EMPRESA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_EMPRESA As Decimal, aNOMBRE As String)
        Me._ID_EMPRESA = aID_EMPRESA
        Me._NOMBRE = aNOMBRE
    End Sub

    Public Function Equals1(ByVal other As EMPRESA) As Boolean Implements System.IEquatable(Of EMPRESA).Equals
        Return Me.ID_EMPRESA = other.ID_EMPRESA
    End Function

    Public Function CompareTo(ByVal other As EMPRESA) As Integer Implements System.IComparable(Of EMPRESA).CompareTo
        If Me.ID_EMPRESA > other.ID_EMPRESA Then Return 1
        If Me.ID_EMPRESA < other.ID_EMPRESA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_EMPRESA As Decimal
    <Column(Name:="Id empresa", Storage:="ID_EMPRESA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_EMPRESA() As Decimal
        Get
            Return _ID_EMPRESA
        End Get
        Set(ByVal Value As Decimal)
            _ID_EMPRESA = Value
            OnPropertyChanged("ID_EMPRESA")
        End Set
    End Property 

    Private _NOMBRE As String
    <Column(Name:="Nombre", Storage:="NOMBRE", DbType:="VARCHAR2(300) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 300)> _
    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal Value As String)
            _NOMBRE = Value
            OnPropertyChanged("NOMBRE")
        End Set
    End Property 

    Private _NOMBREOld As String
    Public Property NOMBREOld() As String
        Get
            Return _NOMBREOld
        End Get
        Set(ByVal Value As String)
            _NOMBREOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
