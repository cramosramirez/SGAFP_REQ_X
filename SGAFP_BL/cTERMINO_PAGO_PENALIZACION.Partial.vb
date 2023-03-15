Partial Public Class cTERMINO_PAGO_PENALIZACION

    Public Function ObtenerRANGO_PORC_PENA_PorDIAS(ByVal ID_TERMINO_PARAM As Decimal, ByVal DIAS_TRANSCURRIDOS As Integer, ByVal ID_TIPO_PENA As Decimal) As TERMINO_PAGO_PENALIZACION
        Try
            Return mDb.ObtenerRANGO_PORC_PENA_PorDIAS(ID_TERMINO_PARAM, DIAS_TRANSCURRIDOS, ID_TIPO_PENA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function EliminarlistaTERMINO_PAGO_PENALIZACION(ByVal ID_TERMINO_PARAM As Decimal) As Integer
        Try
            Return mDb.EliminarlistaTERMINO_PAGO_PENALIZACION(ID_TERMINO_PARAM)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
