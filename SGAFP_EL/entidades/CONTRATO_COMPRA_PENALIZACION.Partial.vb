﻿Partial Public Class CONTRATO_COMPRA_PENALIZACION

    Private _REFERENCIA As String
    Public Property REFERENCIA() As String
        Get
            Return _REFERENCIA
        End Get
        Set(ByVal Value As String)
            _REFERENCIA = Value
            OnPropertyChanged("REFERENCIA")
        End Set
    End Property
End Class
