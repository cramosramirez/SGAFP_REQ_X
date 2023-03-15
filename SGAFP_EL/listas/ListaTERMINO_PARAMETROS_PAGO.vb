''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaTERMINO_PARAMETROS_PAGO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TERMINO_PARAMETROS_PAGO',
''' es una representación en memoria de los registros de la tabla TERMINO_PARAMETROS_PAGO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTERMINO_PARAMETROS_PAGO
    Inherits listaBase(Of TERMINO_PARAMETROS_PAGO)
    Public Function BuscarPorId(ByVal ID_TERMINO_PARAM As Decimal) As TERMINO_PARAMETROS_PAGO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As TERMINO_PARAMETROS_PAGO = Me(i)
            If s.ID_TERMINO_PARAM = ID_TERMINO_PARAM Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
