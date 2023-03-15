''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaASISTENCIA_AF_HORARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ASISTENCIA_AF_HORARIO',
''' es una representación en memoria de los registros de la tabla ASISTENCIA_AF_HORARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/09/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaASISTENCIA_AF_HORARIO
    Inherits listaBase(Of ASISTENCIA_AF_HORARIO)
    Public Function BuscarPorId(ByVal ID_ASISTENCIA_AF As Decimal, ByVal ID_ASISTENCIA_AF_HORARIO As Decimal) As ASISTENCIA_AF_HORARIO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ASISTENCIA_AF_HORARIO = Me(i)
            If s.ID_ASISTENCIA_AF = ID_ASISTENCIA_AF _
            And s.ID_ASISTENCIA_AF_HORARIO = ID_ASISTENCIA_AF_HORARIO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
