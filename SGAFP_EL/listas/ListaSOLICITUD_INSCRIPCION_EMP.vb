''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSOLICITUD_INSCRIPCION_EMP
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLICITUD_INSCRIPCION_EMP',
''' es una representación en memoria de los registros de la tabla SOLICITUD_INSCRIPCION_EMP
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/03/2023	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLICITUD_INSCRIPCION_EMP
    Inherits listaBase(Of SOLICITUD_INSCRIPCION_EMP)
    Public Function BuscarPorId(ByVal ID_SOLIC_EMP As Decimal) As SOLICITUD_INSCRIPCION_EMP
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SOLICITUD_INSCRIPCION_EMP = Me(i)
            If s.ID_SOLIC_EMP = ID_SOLIC_EMP Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
