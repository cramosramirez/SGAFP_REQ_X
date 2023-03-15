Imports Microsoft.VisualBasic
Imports SGAFP.BL
Imports SGAFP.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Public Class cCONTRATO_COMPRA_PAGO_ASISTEcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal nombreSesion_uclistaCONTRATO_COMPRA_PAGO_ASISTE As String) As listaCONTRATO_COMPRA_PAGO_ASISTE
        Try
            Dim lista As listaCONTRATO_COMPRA_PAGO_ASISTE
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_uclistaCONTRATO_COMPRA_PAGO_ASISTE) Is Nothing Then Return New listaCONTRATO_COMPRA_PAGO_ASISTE
            lista = TryCast(_SESION(nombreSesion_uclistaCONTRATO_COMPRA_PAGO_ASISTE), listaCONTRATO_COMPRA_PAGO_ASISTE)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_CONTRA_ASISTE As Decimal, _
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaCONTRATO_COMPRA_PAGO_ASISTE = _SESION(REFERENCIA)

            If ID_CONTRA_ASISTE > 0 AndAlso mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_CONTRA_ASISTE = ID_CONTRA_ASISTE Then
                        mDetalle.RemoveAt(i)
                    End If
                Next
            End If
            _SESION(REFERENCIA) = mDetalle
            Return 1
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function Actualizar(ByVal ID_CONTRA_ASISTE As Decimal, ByVal ID_CONTRATO_COMPRA As Decimal, _
                            ByVal ID_MODALIDAD_FORMACION As Decimal, ByVal PORC_ASISTE_INI As Decimal, ByVal PORC_ASISTE_FIN As Decimal, ByVal PORC_PAGO_COSTO_PARTI As Decimal, _
                            ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaCONTRATO_COMPRA_PAGO_ASISTE = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_CONTRA_ASISTE = ID_CONTRA_ASISTE Then
                        mDetalle(i).ID_CONTRATO_COMPRA = ID_CONTRATO_COMPRA
                        mDetalle(i).ID_MODALIDAD_FORMACION = ID_MODALIDAD_FORMACION
                        mDetalle(i).PORC_ASISTE_INI = PORC_ASISTE_INI
                        mDetalle(i).PORC_ASISTE_FIN = PORC_ASISTE_FIN
                        mDetalle(i).PORC_PAGO_COSTO_PARTI = Math.Round(PORC_PAGO_COSTO_PARTI, 2)
                        mDetalle(i).REFERENCIA = REFERENCIA
                    End If
                Next
            End If

            _SESION(REFERENCIA) = mDetalle
            Return 1

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
