''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaTERMINO_PAGO_ASISTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TERMINO_PAGO_ASISTE',
''' es una representación en memoria de los registros de la tabla TERMINO_PAGO_ASISTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTERMINO_PAGO_ASISTE
    Inherits listaBase(Of TERMINO_PAGO_ASISTE)
    Public Function BuscarPorId(ByVal ID_TERMINO_ASISTE As Decimal) As TERMINO_PAGO_ASISTE
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As TERMINO_PAGO_ASISTE = Me(i)
            If s.ID_TERMINO_ASISTE = ID_TERMINO_ASISTE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
