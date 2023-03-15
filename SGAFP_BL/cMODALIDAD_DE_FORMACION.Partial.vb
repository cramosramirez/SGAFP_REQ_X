Partial Public Class cMODALIDAD_DE_FORMACION

    Public Function ObtenerListaPorCONTRATO_COMPRA(ByVal ID_CONTRATO_COMPRA As Decimal, _
                                            Optional ByVal asColumnaOrden As String = "ID_MODALIDAD_FORMACION", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaMODALIDAD_DE_FORMACION
        Try
            Return mDb.ObtenerListaPorCONTRATO_COMPRA(ID_CONTRATO_COMPRA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
