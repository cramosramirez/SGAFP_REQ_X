Partial Public Class cCONTRATO_COMPRA_MODALIDAD

    Public Function EliminarlistaCONTRATO_COMPRA_MODALIDAD(ByVal ID_CONTRATO_COMPRA As Decimal) As Integer
        Try
            Return mDb.EliminarlistaCONTRATO_COMPRA_MODALIDAD(ID_CONTRATO_COMPRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
