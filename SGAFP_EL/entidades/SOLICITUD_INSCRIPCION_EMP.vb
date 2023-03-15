''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SOLICITUD_INSCRIPCION_EMP
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLICITUD_INSCRIPCION_EMP en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/03/2023	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLICITUD_INSCRIPCION_EMP")> Public Class SOLICITUD_INSCRIPCION_EMP
    Inherits entidadBase
    Implements IEquatable(Of SOLICITUD_INSCRIPCION_EMP), IComparable(Of SOLICITUD_INSCRIPCION_EMP)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLIC_EMP As Decimal, aID_SOLICITUD As Decimal, aID_EMPRESA As Decimal)
        Me._ID_SOLIC_EMP = aID_SOLIC_EMP
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._ID_EMPRESA = aID_EMPRESA
    End Sub

    Public Function Equals1(ByVal other As SOLICITUD_INSCRIPCION_EMP) As Boolean Implements System.IEquatable(Of SOLICITUD_INSCRIPCION_EMP).Equals
        Return Me.ID_SOLIC_EMP = other.ID_SOLIC_EMP
    End Function

    Public Function CompareTo(ByVal other As SOLICITUD_INSCRIPCION_EMP) As Integer Implements System.IComparable(Of SOLICITUD_INSCRIPCION_EMP).CompareTo
        If Me.ID_SOLIC_EMP > other.ID_SOLIC_EMP Then Return 1
        If Me.ID_SOLIC_EMP < other.ID_SOLIC_EMP Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_SOLIC_EMP As Decimal
    <Column(Name:="Id solic emp", Storage:="ID_SOLIC_EMP", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_SOLIC_EMP() As Decimal
        Get
            Return _ID_SOLIC_EMP
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLIC_EMP = Value
            OnPropertyChanged("ID_SOLIC_EMP")
        End Set
    End Property 

    Private _ID_SOLICITUD As Decimal
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_SOLICITUD() As Decimal
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
        End Set
    End Property 

    Private _ID_SOLICITUDOld As Decimal
    Public Property ID_SOLICITUDOld() As Decimal
        Get
            Return _ID_SOLICITUDOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUDOld = Value
        End Set
    End Property 

    Private _fkID_SOLICITUD As SOLICITUD_INSCRIPCION_AF
    Public Property fkID_SOLICITUD() As SOLICITUD_INSCRIPCION_AF
        Get
            Return _fkID_SOLICITUD
        End Get
        Set(ByVal Value As SOLICITUD_INSCRIPCION_AF)
            _fkID_SOLICITUD = Value
        End Set
    End Property 

    Private _ID_EMPRESA As Decimal
    <Column(Name:="Id empresa", Storage:="ID_EMPRESA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_EMPRESA() As Decimal
        Get
            Return _ID_EMPRESA
        End Get
        Set(ByVal Value As Decimal)
            _ID_EMPRESA = Value
            OnPropertyChanged("ID_EMPRESA")
        End Set
    End Property 

    Private _ID_EMPRESAOld As Decimal
    Public Property ID_EMPRESAOld() As Decimal
        Get
            Return _ID_EMPRESAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_EMPRESAOld = Value
        End Set
    End Property 

    Private _fkID_EMPRESA As EMPRESA
    Public Property fkID_EMPRESA() As EMPRESA
        Get
            Return _fkID_EMPRESA
        End Get
        Set(ByVal Value As EMPRESA)
            _fkID_EMPRESA = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
