﻿Partial Public Class SOLICITUD_CAPACITACION
    Private _GRUPO_SOLICITUD_SOLICITUD_CAPACITACION As listaGRUPO_SOLICITUD
    Public Property GRUPO_SOLICITUD_SOLICITUD_CAPACITACION() As listaGRUPO_SOLICITUD
        Get
            Return _GRUPO_SOLICITUD_SOLICITUD_CAPACITACION
        End Get
        Set(ByVal Value As listaGRUPO_SOLICITUD)
            _GRUPO_SOLICITUD_SOLICITUD_CAPACITACION = Value
            OnPropertyChanged("GRUPO_SOLICITUD_SOLICITUD_CAPACITACION")
        End Set
    End Property
End Class
