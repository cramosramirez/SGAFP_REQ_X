''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaTERMINO_PAGO_PENALIZACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TERMINO_PAGO_PENALIZACION',
''' es una representación en memoria de los registros de la tabla TERMINO_PAGO_PENALIZACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTERMINO_PAGO_PENALIZACION
    Inherits listaBase(Of TERMINO_PAGO_PENALIZACION)
    Public Function BuscarPorId(ByVal ID_TERMINO_PENA As Decimal) As TERMINO_PAGO_PENALIZACION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As TERMINO_PAGO_PENALIZACION = Me(i)
            If s.ID_TERMINO_PENA = ID_TERMINO_PENA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
