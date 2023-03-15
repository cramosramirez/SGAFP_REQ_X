Imports Microsoft.VisualBasic
Imports SGAFP.BL
Imports SGAFP.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Public Class cTERMINO_PAGO_ASISTEcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal nombreSesion_uclistaTERMINO_PAGO_ASISTE As String) As listaTERMINO_PAGO_ASISTE
        Try
            Dim lista As listaTERMINO_PAGO_ASISTE
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_uclistaTERMINO_PAGO_ASISTE) Is Nothing Then Return New listaTERMINO_PAGO_ASISTE
            lista = TryCast(_SESION(nombreSesion_uclistaTERMINO_PAGO_ASISTE), listaTERMINO_PAGO_ASISTE)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_TERMINO_ASISTE As Decimal, _
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaTERMINO_PAGO_ASISTE = _SESION(REFERENCIA)

            If ID_TERMINO_ASISTE > 0 AndAlso mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_TERMINO_ASISTE = ID_TERMINO_ASISTE Then
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
    Public Function Actualizar(ByVal ID_TERMINO_ASISTE As Decimal, ByVal ID_TERMINO_PARAM As Decimal, _
                            ByVal ID_MODALIDAD_FORMACION As Decimal, ByVal PORC_ASISTE_INI As Decimal, ByVal PORC_ASISTE_FIN As Decimal, ByVal PORC_PAGO_COSTO_PARTI As Decimal, _
                            ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaTERMINO_PAGO_ASISTE = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_TERMINO_ASISTE = ID_TERMINO_ASISTE Then
                        mDetalle(i).ID_TERMINO_PARAM = ID_TERMINO_PARAM
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
