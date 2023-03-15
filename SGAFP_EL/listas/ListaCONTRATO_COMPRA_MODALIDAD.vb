''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCONTRATO_COMPRA_MODALIDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTRATO_COMPRA_MODALIDAD',
''' es una representación en memoria de los registros de la tabla CONTRATO_COMPRA_MODALIDAD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	22/10/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTRATO_COMPRA_MODALIDAD
    Inherits listaBase(Of CONTRATO_COMPRA_MODALIDAD)
    Public Function BuscarPorId(ByVal ID_CONTRA_MODAL As Decimal) As CONTRATO_COMPRA_MODALIDAD
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CONTRATO_COMPRA_MODALIDAD = Me(i)
            If s.ID_CONTRA_MODAL = ID_CONTRA_MODAL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
