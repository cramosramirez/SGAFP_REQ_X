Partial Public Class cTERMINO_PAGO_MODALIDAD
    Public Function EliminarlistaTERMINO_PAGO_MODALIDAD(ByVal ID_TERMINO_PARAM As Decimal) As Integer
        Try
            Return mDb.EliminarlistaTERMINO_PAGO_MODALIDAD(ID_TERMINO_PARAM)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
