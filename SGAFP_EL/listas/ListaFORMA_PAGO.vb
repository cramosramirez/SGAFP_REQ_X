''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaFORMA_PAGO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'FORMA_PAGO',
''' es una representación en memoria de los registros de la tabla FORMA_PAGO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/10/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaFORMA_PAGO
    Inherits listaBase(Of FORMA_PAGO)
    Public Function BuscarPorId(ByVal ID_FORMA_PAGO As Decimal) As FORMA_PAGO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As FORMA_PAGO = Me(i)
            If s.ID_FORMA_PAGO = ID_FORMA_PAGO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
