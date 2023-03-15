''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCONTRATO_COMPRA_PAGO_ASISTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTRATO_COMPRA_PAGO_ASISTE',
''' es una representación en memoria de los registros de la tabla CONTRATO_COMPRA_PAGO_ASISTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/10/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTRATO_COMPRA_PAGO_ASISTE
    Inherits listaBase(Of CONTRATO_COMPRA_PAGO_ASISTE)
    Public Function BuscarPorId(ByVal ID_CONTRA_ASISTE As Decimal) As CONTRATO_COMPRA_PAGO_ASISTE
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CONTRATO_COMPRA_PAGO_ASISTE = Me(i)
            If s.ID_CONTRA_ASISTE = ID_CONTRA_ASISTE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
