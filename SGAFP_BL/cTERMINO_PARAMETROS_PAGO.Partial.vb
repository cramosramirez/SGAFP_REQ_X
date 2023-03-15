Imports SGAFP.EL.Enumeradores

Partial Public Class cTERMINO_PARAMETROS_PAGO


    Public Function ObtenerListaTERMINO_PARAMETROS_PAGO_Por_ACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As listaTERMINO_PARAMETROS_PAGO
        Dim lista As New listaTERMINO_PARAMETROS_PAGO
        Dim ds As DataSet

        Try
            'Obtener toda la información del TDR relacionada a la solicitud mediante el ID_ACCION_FORMATIVA
            ds = mDb.ObtenerDatos_SOLICITUD_Y_TDR(ID_ACCION_FORMATIVA)

            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                'Aplicar orden de ejecución para criterios de resolución
                Dim tdr As String = ds.Tables(0).Rows(0)("TDR").ToString
                Dim idUnidadOrg As Decimal = Convert.ToDecimal(ds.Tables(0).Rows(0)("ID_UNIDAD_ORGANIZATIVA").ToString)
                Dim idCentroResp As Decimal = Convert.ToDecimal(ds.Tables(0).Rows(0)("ID_CENTRO_RESPONSABILIDAD").ToString)
                Dim idReferente As Decimal = Convert.ToDecimal(ds.Tables(0).Rows(0)("ID_REFERENTE").ToString)
                Dim idModalidad As Decimal = Convert.ToDecimal(ds.Tables(0).Rows(0)("ID_MODALIDAD_FORMACION").ToString)

                For i As Integer = 1 To 5
                    Select Case i
                        Case OrdenEjecucionResolucionTDRPago.TDR_MODALIDAD
                            lista = mDb.ObtenerListaPorCriterios(tdr, -1, -1, -1, idModalidad)
                        Case OrdenEjecucionResolucionTDRPago.UNIDADORGANIZATIVA_CENTRORESPONSALIDAD_REFERENTE_MODALIDAD
                            lista = mDb.ObtenerListaPorCriterios("", idUnidadOrg, idCentroResp, idReferente, idModalidad)
                        Case OrdenEjecucionResolucionTDRPago.UNIDADORGANIZATIVA_CENTRORESPONSALIDAD_MODALIDAD
                            lista = mDb.ObtenerListaPorCriterios("", idUnidadOrg, idCentroResp, -1, idModalidad)
                        Case OrdenEjecucionResolucionTDRPago.UNIDADORGANIZATIVA_MODALIDAD
                            lista = mDb.ObtenerListaPorCriterios("", idUnidadOrg, -1, -1, idModalidad)
                        Case OrdenEjecucionResolucionTDRPago.MODALIDAD
                            lista = mDb.ObtenerListaPorCriterios("", -1, -1, -1, idModalidad)
                    End Select
                    If lista IsNot Nothing AndAlso lista.Count > 0 Then
                        Exit For
                    End If
                Next
            Else
                lista = Nothing
            End If

            Return lista

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function



    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal TDR As String, _
                                             ByVal ID_UNIDAD_ORGANIZATIVA As Decimal, _
                                             ByVal ID_CENTRO_RESPONSABILIDAD As Decimal, _
                                             ByVal ID_REFERENTE As Decimal, _
                                             ByVal ID_MODALIDAD_FORMACION As Decimal, _
                                             Optional ByVal asColumnaOrden As String = "ID_TERMINO_PARAM", _
                                             Optional ByVal asTipoOrden As String = "DESC") As listaTERMINO_PARAMETROS_PAGO
        Try
            Return mDb.ObtenerListaPorCriterios(TDR, ID_UNIDAD_ORGANIZATIVA, ID_CENTRO_RESPONSABILIDAD, ID_REFERENTE, ID_MODALIDAD_FORMACION, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
