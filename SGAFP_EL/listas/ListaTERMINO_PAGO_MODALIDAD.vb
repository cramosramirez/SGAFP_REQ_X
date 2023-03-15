''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaTERMINO_PAGO_MODALIDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TERMINO_PAGO_MODALIDAD',
''' es una representación en memoria de los registros de la tabla TERMINO_PAGO_MODALIDAD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTERMINO_PAGO_MODALIDAD
    Inherits listaBase(Of TERMINO_PAGO_MODALIDAD)
    Public Function BuscarPorId(ByVal ID_TERMINO_MODAL As Decimal) As TERMINO_PAGO_MODALIDAD
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As TERMINO_PAGO_MODALIDAD = Me(i)
            If s.ID_TERMINO_MODAL = ID_TERMINO_MODAL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
