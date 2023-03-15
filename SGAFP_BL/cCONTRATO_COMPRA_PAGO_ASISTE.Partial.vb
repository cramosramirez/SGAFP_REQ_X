Partial Public Class cCONTRATO_COMPRA_PAGO_ASISTE

    Public Function ObtenerPORC_PAGO_POR_PORC_ASISTENCIA(ByVal ID_CONTRATO_COMPRA As Decimal, ByVal ID_MODALIDAD_FORMACION As Decimal, ByVal PORC_ASISTENCIA As Decimal) As CONTRATO_COMPRA_PAGO_ASISTE
        Try
            Return mDb.ObtenerPORC_PAGO_POR_PORC_ASISTENCIA(ID_CONTRATO_COMPRA, ID_MODALIDAD_FORMACION, PORC_ASISTENCIA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function EliminarlistaCONTRATO_COMPRA_PAGO_ASISTE(ByVal ID_CONTRATO_COMPRA As Decimal) As Integer
        Try
            Return mDb.EliminarlistaCONTRATO_COMPRA_PAGO_ASISTE(ID_CONTRATO_COMPRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

End Class
