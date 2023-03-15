''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaEMPRESA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'EMPRESA',
''' es una representación en memoria de los registros de la tabla EMPRESA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/03/2023	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaEMPRESA
    Inherits listaBase(Of EMPRESA)
    Public Function BuscarPorId(ByVal ID_EMPRESA As Decimal) As EMPRESA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As EMPRESA = Me(i)
            If s.ID_EMPRESA = ID_EMPRESA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
