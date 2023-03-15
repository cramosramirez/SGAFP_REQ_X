Partial Public Class cTERMINO_PAGO_ASISTE
    Public Function ObtenerPORC_PAGO_POR_PORC_ASISTENCIA(ByVal ID_TERMINO_PARAM As Decimal, ByVal ID_MODALIDAD_FORMACION As Decimal, ByVal PORC_ASISTENCIA As Decimal) As TERMINO_PAGO_ASISTE
        Try
            Return mDb.ObtenerPORC_PAGO_POR_PORC_ASISTENCIA(ID_TERMINO_PARAM, ID_MODALIDAD_FORMACION, PORC_ASISTENCIA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function EliminarlistaTERMINO_PAGO_ASISTE(ByVal ID_TERMINO_PARAM As Decimal) As Integer
        Try
            Return mDb.EliminarlistaTERMINO_PAGO_ASISTE(ID_TERMINO_PARAM)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
