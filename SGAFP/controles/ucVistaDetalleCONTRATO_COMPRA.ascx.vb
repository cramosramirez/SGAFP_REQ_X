Imports SGAFP.BL
Imports SGAFP.EL
Imports DevExpress.Web.ASPxEditors


Partial Class controles_ucVistaDetalleCONTRATO_COMPRA
    Inherits ucBase

#Region "Propiedades"

    Private Property esNuevo As Boolean
        Get
            If Me.ViewState("esNuevo") IsNot Nothing Then
                Return CBool(Me.ViewState("esNuevo"))
            Else
                Return False
            End If
        End Get
        Set(value As Boolean)
            Me.ViewState("esNuevo") = value
        End Set
    End Property
    Public Property ID_CONTRATO_COMPRA() As Decimal
        Get
            If Me.ViewState("ID_CONTRATO_COMPRA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_CONTRATO_COMPRA"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Decimal)
            Me.ViewState("ID_CONTRATO_COMPRA") = Value
            Me.lblREFERENCIA.Text = Guid.NewGuid.ToString
            Me.lblREFERENCIA_PAGO_ASISTE.Text = Guid.NewGuid.ToString
            Me.CargarModalidades()
            Me.TabSolicitud.ActiveTabIndex = 0
            If Value > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property LISTA_CONTRATO_COMPRA_PENALIZACION As ListaCONTRATO_COMPRA_PENALIZACION
        Set(value As ListaCONTRATO_COMPRA_PENALIZACION)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), ListaCONTRATO_COMPRA_PENALIZACION) Else Return New ListaCONTRATO_COMPRA_PENALIZACION
        End Get
    End Property

    Public Property LISTA_CONTRATO_COMPRA_PAGO_ASISTE As listaCONTRATO_COMPRA_PAGO_ASISTE
        Set(value As listaCONTRATO_COMPRA_PAGO_ASISTE)
            Session(Me.lblREFERENCIA_PAGO_ASISTE.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA_PAGO_ASISTE.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA_PAGO_ASISTE.Text), listaCONTRATO_COMPRA_PAGO_ASISTE) Else Return New listaCONTRATO_COMPRA_PAGO_ASISTE
        End Get
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cCONTRATO_COMPRA
    Private mEntidad As CONTRATO_COMPRA
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property
#End Region

    Public Sub LimpiarSesion()
        If lblREFERENCIA.Text <> "" Then
            If Session(lblREFERENCIA.Text) IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text)
            End If
        End If
        If lblREFERENCIA_PAGO_ASISTE.Text <> "" Then
            If Session(lblREFERENCIA_PAGO_ASISTE.Text) IsNot Nothing Then
                Session.Remove(lblREFERENCIA_PAGO_ASISTE.Text)
            End If
        End If
    End Sub

    Public Sub CargarDetallePenalizaciones()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaCONTRATO_COMPRA_PENALIZACION1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
    End Sub

    Public Sub CargarDetallePagoAsiste()
        If Me.lblREFERENCIA_PAGO_ASISTE.Text <> "" Then
            Me.ucListaCONTRATO_COMPRA_PAGO_ASISTE1.CargarDatosCache(Me.lblREFERENCIA_PAGO_ASISTE.Text)
        End If
    End Sub

    Private Sub CargarDatos()
        Dim sError As New String("")
        Dim listaPenalizaciones As ListaCONTRATO_COMPRA_PENALIZACION
        Dim listaPagoAsiste As listaCONTRATO_COMPRA_PAGO_ASISTE

        Me.esNuevo = False
        mEntidad = New CONTRATO_COMPRA
        mEntidad = mComponente.ObtenerCONTRATO_COMPRA(ID_CONTRATO_COMPRA)
        If mEntidad Is Nothing Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CONTRATO_COMPRA.Text = mEntidad.ID_CONTRATO_COMPRA.ToString()
        Me.txtNO_CONTRATO_COMPRA.Text = mEntidad.NO_CONTRATO_COMPRA
        Me.dteFECHA_INGRESO.Date = mEntidad.FECHA_INGRESO
        Me.cbxUNIDAD_ORGANIZATIVA.Value = Convert.ToInt32(mEntidad.ID_UNIDAD_ORGANIZATIVA)
        Me.dteFECHA_INI_EJEC.Date = mEntidad.FECHA_INI_EJEC
        Me.dteFECHA_FIN_EJEC.Date = mEntidad.FECHA_FIN_EJEC
        Me.spePORC_ASISTENCIA_MIN.Value = IIf(mEntidad.PORC_ASISTENCIA_MIN = 0, Nothing, mEntidad.PORC_ASISTENCIA_MIN)
        Me.cbxFORMA_PAGO.Value = CInt(mEntidad.ID_FORMA_PAGO)
        Me.speBASE_PARTI.Value = IIf(mEntidad.BASE_PARTI = -1, Nothing, mEntidad.BASE_PARTI)

        'Penalizaciones
        listaPenalizaciones = (New cCONTRATO_COMPRA_PENALIZACION).ObtenerListaPorCONTRATO_COMPRA(mEntidad.ID_CONTRATO_COMPRA)
        If listaPenalizaciones IsNot Nothing AndAlso listaPenalizaciones.Count > 0 Then
            For i As Integer = 0 To listaPenalizaciones.Count - 1
                listaPenalizaciones(i).REFERENCIA = Me.lblREFERENCIA.Text
            Next
            Me.LISTA_CONTRATO_COMPRA_PENALIZACION = listaPenalizaciones
        Else
            Me.LISTA_CONTRATO_COMPRA_PENALIZACION = New ListaCONTRATO_COMPRA_PENALIZACION
        End If
        Me.CargarDetallePenalizaciones()

        'Parametros de pago por asistencia
        listaPagoAsiste = (New cCONTRATO_COMPRA_PAGO_ASISTE).ObtenerListaPorCONTRATO_COMPRA(mEntidad.ID_CONTRATO_COMPRA)
        If listaPagoAsiste IsNot Nothing AndAlso listaPagoAsiste.Count > 0 Then
            For i As Integer = 0 To listaPagoAsiste.Count - 1
                listaPagoAsiste(i).REFERENCIA = Me.lblREFERENCIA_PAGO_ASISTE.Text
            Next
            Me.LISTA_CONTRATO_COMPRA_PAGO_ASISTE = listaPagoAsiste
        Else
            Me.LISTA_CONTRATO_COMPRA_PAGO_ASISTE = New listaCONTRATO_COMPRA_PAGO_ASISTE
        End If
        Me.CargarDetallePagoAsiste()
        Me.MarcarModalidades()
        Me.ConfigurarFormaPagoSeleccionada()
    End Sub

    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_CONTRATO_COMPRA.ClientEnabled = False
        Me.txtNO_CONTRATO_COMPRA.ClientEnabled = edicion
        Me.cbxUNIDAD_ORGANIZATIVA.ClientEnabled = edicion
        Me.dteFECHA_INGRESO.ClientEnabled = edicion
        Me.dteFECHA_INI_EJEC.ClientEnabled = edicion
        Me.dteFECHA_FIN_EJEC.ClientEnabled = edicion
        Me.btnCargarPlantilla.ClientEnabled = edicion
        Me.btnAgregar.ClientEnabled = edicion
        Me.btnBorrarRangos.ClientEnabled = edicion
        If Me.cbxFORMA_PAGO.Value IsNot Nothing AndAlso CInt(Me.cbxFORMA_PAGO.Value) = FormaPagoContratacion.PorPorcentajeAsistenciaDiferenciado Then
            Me.lstMODALIDADES.Enabled = False
        Else
            Me.lstMODALIDADES.Enabled = edicion And Not esNuevo
        End If
        If Me.cbxFORMA_PAGO.Value IsNot Nothing AndAlso CInt(Me.cbxFORMA_PAGO.Value) <> FormaPagoContratacion.PorCursoIndeCapacitados Then
            Me.speBASE_PARTI.ClientEnabled = edicion
        Else
            Me.speBASE_PARTI.ClientEnabled = False
        End If

        Me.btnAgregarRgoPagoAsiste.ClientEnabled = edicion
        Me.btnLimpiarRgoPagoAsiste.ClientEnabled = edicion
    End Sub

    Private Sub Nuevo()
        Me.esNuevo = True
        Me.TabSolicitud.TabPages(1).ClientEnabled = False
        Me.txtID_CONTRATO_COMPRA.Text = ""
        Me.txtNO_CONTRATO_COMPRA.Text = ""
        Me.cbxUNIDAD_ORGANIZATIVA.Value = Nothing
        Me.dteFECHA_INGRESO.Value = Nothing
        Me.dteFECHA_INI_EJEC.Value = Nothing
        Me.dteFECHA_FIN_EJEC.Value = Nothing
        Me.spePORC_ASISTENCIA_MIN.Text = ""
        Me.cbxFORMA_PAGO.Value = Nothing
        Me.speBASE_PARTI.Value = Nothing
        Me.LISTA_CONTRATO_COMPRA_PENALIZACION = New ListaCONTRATO_COMPRA_PENALIZACION
        Me.CargarDetallePenalizaciones()
        Me.LISTA_CONTRATO_COMPRA_PAGO_ASISTE = New listaCONTRATO_COMPRA_PAGO_ASISTE
        Me.CargarDetallePagoAsiste()
        Me.ConfigurarFormaPagoSeleccionada()
    End Sub

    Protected Sub btnBorrarRangos_Click(sender As Object, e As EventArgs) Handles btnBorrarRangos.Click
        Me.LISTA_CONTRATO_COMPRA_PENALIZACION = New ListaCONTRATO_COMPRA_PENALIZACION
        Me.CargarDetallePenalizaciones()
    End Sub

    Protected Sub btnLimpiarRgoPagoAsiste_Click(sender As Object, e As EventArgs) Handles btnLimpiarRgoPagoAsiste.Click
        Me.LISTA_CONTRATO_COMPRA_PAGO_ASISTE = New listaCONTRATO_COMPRA_PAGO_ASISTE
        Me.CargarDetallePagoAsiste()
        Me.SeleccionarModalidades()
    End Sub

    Private Sub MarcarModalidades()
        Dim lst As listaCONTRATO_COMPRA_MODALIDAD
        Dim item As ListEditItem

        lst = (New cCONTRATO_COMPRA_MODALIDAD).ObtenerListaPorCONTRATO_COMPRA(Me.ID_CONTRATO_COMPRA)
        If lst IsNot Nothing AndAlso lst.Count > 0 Then
            For i As Integer = 0 To lst.Count - 1
                item = Me.lstMODALIDADES.Items.FindByValue(CInt(lst(i).ID_MODALIDAD_FORMACION))
                If item IsNot Nothing Then
                    item.Selected = True
                End If
            Next
        End If
    End Sub

    Public Function Actualizar() As String
        Dim sError As New StringBuilder
        Dim bContratoCompra As New cCONTRATO_COMPRA
        Dim bContratoCompraPena As New cCONTRATO_COMPRA_PENALIZACION
        Dim bContratoCompraPagoAsiste As New cCONTRATO_COMPRA_PAGO_ASISTE
        Dim bContratoCompraModalidad As New cCONTRATO_COMPRA_MODALIDAD
        Dim listaPena As ListaCONTRATO_COMPRA_PENALIZACION
        Dim listaPagoAsiste As listaCONTRATO_COMPRA_PAGO_ASISTE
        Dim idContratoCompra As Integer = 0
        Dim lista As listaCONTRATO_COMPRA
        Dim bFormaPagoAnteriores As Boolean = False

        listaPena = Me.LISTA_CONTRATO_COMPRA_PENALIZACION
        listaPagoAsiste = Me.LISTA_CONTRATO_COMPRA_PAGO_ASISTE
        If Not Me.esNuevo Then
            mEntidad = bContratoCompra.ObtenerCONTRATO_COMPRA(ID_CONTRATO_COMPRA)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = Now
            idContratoCompra = ID_CONTRATO_COMPRA
        Else
            mEntidad = New CONTRATO_COMPRA
            mEntidad.ID_CONTRATO_COMPRA = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = Now
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = Now
        End If

        If Me.txtNO_CONTRATO_COMPRA.Text.Trim = "" Then
            sError.AppendLine("* Ingrese el No. de oferta de compra")
        End If
        If Me.cbxUNIDAD_ORGANIZATIVA.Value Is Nothing Then
            sError.AppendLine("* Seleccione la unidad organizativa que administra la oferta")
        End If
        If Me.dteFECHA_INGRESO.Value = #12:00:00 AM# Then
            sError.AppendLine("* Digite la fecha de ingreso la oferta")
        End If
        If Me.dteFECHA_INI_EJEC.Value = #12:00:00 AM# Then
            sError.AppendLine("* Ingrese la fecha de inicio de ejecución de la oferta")
        End If
        If Me.dteFECHA_FIN_EJEC.Value = #12:00:00 AM# Then
            sError.AppendLine("* Ingrese la fecha de finalización de ejecución de la oferta")
        End If
        If Me.cbxFORMA_PAGO.Value Is Nothing Then
            sError.AppendLine("* Seleccione una forma de pago")
        Else
            If (Me.spePORC_ASISTENCIA_MIN.Value Is Nothing OrElse Not IsNumeric(Me.spePORC_ASISTENCIA_MIN.Text)) Then
                sError.AppendLine("* Ingrese el porcentaje mínimo de asistencia")
            End If
            If CInt(Me.cbxFORMA_PAGO.Value) <> FormaPagoContratacion.PorCursoIndeCapacitados AndAlso _
                Me.speBASE_PARTI.Text.Trim = "" Then
                sError.AppendLine("* Ingrese numero de participantes (base pago)")
            End If
        End If
        If Me.dteFECHA_INI_EJEC.Date > Me.dteFECHA_INI_EJEC.Value Then
            sError.AppendLine("* La fecha inicial no puede ser mayor que la fecha final de ejecucion")
        End If
        If listaPena Is Nothing OrElse listaPena.Count = 0 Then
            sError.AppendLine("* Ingrese el detalle de las penalizaciones que aplican a la ejecucion de la oferta")
        End If
        If CDec(Me.cbxFORMA_PAGO.Value) = FormaPagoContratacion.PorPorcentajeAsistenciaDiferenciado AndAlso (listaPagoAsiste Is Nothing OrElse listaPagoAsiste.Count = 0) Then
            sError.AppendLine("* Ingrese los parámetros de pago por asistencia")
        End If
        lista = mComponente.ObtenerListaPorNO_CONTRATO_COMPRA(Me.txtNO_CONTRATO_COMPRA.Text.Trim)
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            If Me.esNuevo OrElse (mEntidad.ID_CONTRATO_COMPRA <> lista(0).ID_CONTRATO_COMPRA) Then
                sError.AppendLine("* Ya existe una oferta de compra No. " + Me.txtNO_CONTRATO_COMPRA.Text.Trim + " registrada en el sistema")
                Return -1
            End If
        End If
        If sError.ToString <> "" Then
            Return sError.ToString
        End If

        mEntidad.NO_CONTRATO_COMPRA = Me.txtNO_CONTRATO_COMPRA.Text.Trim.ToUpper
        mEntidad.ID_UNIDAD_ORGANIZATIVA = Convert.ToDecimal(Me.cbxUNIDAD_ORGANIZATIVA.Value)
        mEntidad.FECHA_INGRESO = Me.dteFECHA_INGRESO.Date
        mEntidad.FECHA_INI_EJEC = Me.dteFECHA_INI_EJEC.Date
        mEntidad.FECHA_FIN_EJEC = Me.dteFECHA_FIN_EJEC.Date
        mEntidad.ID_FORMA_PAGO = CDec(Me.cbxFORMA_PAGO.Value)
        mEntidad.PORC_ASISTENCIA_MIN = Convert.ToDecimal(Me.spePORC_ASISTENCIA_MIN.Value)
        mEntidad.PAGO_POR_PARTICIPACION = Convert.ToDecimal(cbxFORMA_PAGO.Value)

        Select Case CInt(Me.cbxFORMA_PAGO.Value)
            Case FormaPagoContratacion.PorCursoIndeCapacitados
                mEntidad.BASE_PARTI = -1
            Case FormaPagoContratacion.PorCapacitadosConBase
                mEntidad.BASE_PARTI = IIf(speBASE_PARTI.Value = Nothing, 20, CDec(speBASE_PARTI.Value))
            Case FormaPagoContratacion.PorParticipantesInscritos
                mEntidad.BASE_PARTI = IIf(speBASE_PARTI.Value = Nothing, 20, CDec(speBASE_PARTI.Value))
            Case FormaPagoContratacion.PorPorcentajeAsistenciaDiferenciado
                mEntidad.BASE_PARTI = IIf(speBASE_PARTI.Value = Nothing, 20, CDec(speBASE_PARTI.Value))
        End Select

        'Guardar datos de la oferta
        If mComponente.ActualizarCONTRATO_COMPRA(mEntidad, TipoConcurrencia.Pesimistica) <> 1 Then
            Return "Fallo al guardar Oferta de Compra: " + mComponente.sError
        End If

        'Asignar ID_CONTRATO_COMPRA si es nuevo
        If esNuevo Then idContratoCompra = mEntidad.ID_CONTRATO_COMPRA

        'Guardar datos de las penalizaciones
        bContratoCompraPena.EliminarlistaCONTRATO_COMPRA_PENALIZACION(Me.ID_CONTRATO_COMPRA)
        If listaPena IsNot Nothing AndAlso listaPena.Count > 0 Then
            For i As Integer = 0 To listaPena.Count - 1
                Dim lEntidadPena As New CONTRATO_COMPRA_PENALIZACION
                lEntidadPena.ID_CONTRA_PENA = 0
                lEntidadPena.ID_CONTRATO_COMPRA = idContratoCompra
                lEntidadPena.ID_TIPO_PENA = listaPena(i).ID_TIPO_PENA
                lEntidadPena.RANGO_INI = listaPena(i).RANGO_INI
                lEntidadPena.RANGO_FIN = listaPena(i).RANGO_FIN
                lEntidadPena.PORC_PENA = listaPena(i).PORC_PENA
                lEntidadPena.USUARIO_CREA = Me.ObtenerUsuario
                lEntidadPena.FECHA_CREA = Now
                lEntidadPena.USUARIO_ACT = Me.ObtenerUsuario
                lEntidadPena.FECHA_ACT = Now

                bContratoCompraPena.ActualizarCONTRATO_COMPRA_PENALIZACION(lEntidadPena, TipoConcurrencia.Pesimistica)
            Next
        End If
        'Guardar datos de pago por asistencia
        bContratoCompraPagoAsiste.EliminarlistaCONTRATO_COMPRA_PAGO_ASISTE(Me.ID_CONTRATO_COMPRA)
        If Me.cbxFORMA_PAGO.Value = FormaPagoContratacion.PorPorcentajeAsistenciaDiferenciado AndAlso listaPagoAsiste IsNot Nothing AndAlso listaPagoAsiste.Count > 0 Then
            For i As Integer = 0 To listaPagoAsiste.Count - 1
                Dim lEntidadPago As New CONTRATO_COMPRA_PAGO_ASISTE
                lEntidadPago.ID_CONTRA_ASISTE = 0
                lEntidadPago.ID_CONTRATO_COMPRA = idContratoCompra
                lEntidadPago.ID_MODALIDAD_FORMACION = listaPagoAsiste(i).ID_MODALIDAD_FORMACION
                lEntidadPago.PORC_ASISTE_INI = listaPagoAsiste(i).PORC_ASISTE_INI
                lEntidadPago.PORC_ASISTE_FIN = listaPagoAsiste(i).PORC_ASISTE_FIN
                lEntidadPago.PORC_PAGO_COSTO_PARTI = listaPagoAsiste(i).PORC_PAGO_COSTO_PARTI
                lEntidadPago.USUARIO_CREA = Me.ObtenerUsuario
                lEntidadPago.FECHA_CREA = Now
                lEntidadPago.USUARIO_ACT = Me.ObtenerUsuario
                lEntidadPago.FECHA_ACT = Now

                bContratoCompraPagoAsiste.ActualizarCONTRATO_COMPRA_PAGO_ASISTE(lEntidadPago, TipoConcurrencia.Pesimistica)
            Next
        End If

        'Guardar modalidades
        bContratoCompraModalidad.EliminarlistaCONTRATO_COMPRA_MODALIDAD(Me.ID_CONTRATO_COMPRA)
        If Me.lstMODALIDADES.SelectedItems.Count > 0 Then
            Dim lContratoModalidad As CONTRATO_COMPRA_MODALIDAD
            For Each item As ListEditItem In Me.lstMODALIDADES.Items
                If item.Selected Then
                    lContratoModalidad = New CONTRATO_COMPRA_MODALIDAD
                    lContratoModalidad.ID_CONTRA_MODAL = 0
                    lContratoModalidad.ID_CONTRATO_COMPRA = idContratoCompra
                    lContratoModalidad.ID_MODALIDAD_FORMACION = CDec(item.Value)
                    lContratoModalidad.USUARIO_CREA = Me.ObtenerUsuario
                    lContratoModalidad.FECHA_CREA = Now
                    lContratoModalidad.USUARIO_ACT = Me.ObtenerUsuario
                    lContratoModalidad.FECHA_ACT = Now

                    bContratoCompraModalidad.ActualizarCONTRATO_COMPRA_MODALIDAD(lContratoModalidad)
                End If
            Next
        End If

        Me.esNuevo = False
        Return ""
    End Function

    Protected Sub btnCargarPlantilla_Click(sender As Object, e As EventArgs) Handles btnCargarPlantilla.Click
        Dim listaPlantilla As listaRANGO_PORC_PENA = (New cRANGO_PORC_PENA).ObtenerListaPorPROGRAMA_FORMACION(ProgramasFormacion.HABIL_TECNICO_PERMANENTE)
        Dim listaContratoPena As New ListaCONTRATO_COMPRA_PENALIZACION
        Dim lEntidad As CONTRATO_COMPRA_PENALIZACION

        Me.LISTA_CONTRATO_COMPRA_PENALIZACION = New ListaCONTRATO_COMPRA_PENALIZACION
        If listaPlantilla IsNot Nothing AndAlso listaPlantilla.Count > 0 Then
            For i = 0 To listaPlantilla.Count - 1
                lEntidad = New CONTRATO_COMPRA_PENALIZACION
                lEntidad.ID_CONTRA_PENA = ObtenerIdPena(listaContratoPena)
                lEntidad.ID_TIPO_PENA = listaPlantilla(i).ID_TIPO_PENA
                lEntidad.RANGO_INI = listaPlantilla(i).RANGO_INI
                lEntidad.RANGO_FIN = listaPlantilla(i).RANGO_FIN
                lEntidad.PORC_PENA = listaPlantilla(i).PORC_PENA
                lEntidad.REFERENCIA = Me.lblREFERENCIA.Text
                listaContratoPena.Add(lEntidad)
            Next
        End If

        Me.LISTA_CONTRATO_COMPRA_PENALIZACION = listaContratoPena
        Me.CargarDetallePenalizaciones()
    End Sub

    Private Function ObtenerIdPena(ByVal lista As ListaCONTRATO_COMPRA_PENALIZACION) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_CONTRA_PENA > Id Then
                Id = lista(i).ID_CONTRA_PENA
            End If
        Next
        Return (Id + 1)
    End Function

    Private Function ObtenerIdPagoAsiste(ByVal lista As listaCONTRATO_COMPRA_PAGO_ASISTE) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_CONTRA_ASISTE > Id Then
                Id = lista(i).ID_CONTRA_ASISTE
            End If
        Next
        Return (Id + 1)
    End Function

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.lblMensajeError.Text = ""
        Me.cbxTIPO_PENALIZA.Value = Nothing
        Me.speRANGO_INICIAL.Value = Nothing
        Me.speRANGO_FINAL.Value = Nothing
        Me.spePORCENTAJE_PENALIZACION.Value = Nothing
        Me.popAgregarPenalizacion.ShowOnPageLoad = True
        Me.cbxTIPO_PENALIZA.Focus()
    End Sub

    Protected Sub btnAceptarPopup_Click(sender As Object, e As EventArgs) Handles btnAceptarPopup.Click
        Dim lista As ListaCONTRATO_COMPRA_PENALIZACION
        Dim lItem As New CONTRATO_COMPRA_PENALIZACION

        'Validar formulario popup
        If Me.cbxTIPO_PENALIZA.Value Is Nothing Then
            Me.lblMensajeError.Text = "* Seleccione la penalización automática"
            Return
        End If
        If Me.speRANGO_INICIAL.Text = "" Then
            Me.lblMensajeError.Text = "* Ingrese el rango inicial en días"
            Return
        End If
        If Me.speRANGO_FINAL.Text = "" Then
            Me.lblMensajeError.Text = "* Ingrese el rango final en días"
            Return
        End If
        If Me.speRANGO_INICIAL.Value >= Me.speRANGO_FINAL.Value Then
            Me.lblMensajeError.Text = "* Rango inicial en días no puede ser mayor o igual que rango final"
            Return
        End If
        If Me.spePORCENTAJE_PENALIZACION.Text = "" Then
            Me.lblMensajeError.Text = "* Ingrese el porcentaje de penalización"
            Return
        End If

        lista = Me.LISTA_CONTRATO_COMPRA_PENALIZACION
        If lista Is Nothing Then lista = New ListaCONTRATO_COMPRA_PENALIZACION
        lItem.ID_CONTRA_PENA = Me.ObtenerIdPena(lista)
        lItem.ID_TIPO_PENA = Convert.ToDecimal(Me.cbxTIPO_PENALIZA.Value)
        lItem.RANGO_INI = Convert.ToDecimal(Me.speRANGO_INICIAL.Value)
        lItem.RANGO_FIN = Convert.ToDecimal(Me.speRANGO_FINAL.Value)
        lItem.PORC_PENA = Convert.ToDecimal(Me.spePORCENTAJE_PENALIZACION.Value)
        lItem.REFERENCIA = Me.lblREFERENCIA.Text
        lista.Add(lItem)

        Me.LISTA_CONTRATO_COMPRA_PENALIZACION = lista
        Me.CargarDetallePenalizaciones()
        Me.popAgregarPenalizacion.ShowOnPageLoad = False
    End Sub

    Protected Sub btnAgregarPagoAsiste_Click(sender As Object, e As EventArgs) Handles btnAgregarPagoAsiste.Click
        Dim lista As listaCONTRATO_COMPRA_PAGO_ASISTE
        Dim lItem As New CONTRATO_COMPRA_PAGO_ASISTE
        Dim idModalidad As Decimal = 0
        Dim dPorcAsisteIni As Decimal = 0
        Dim dPorcAsisteFin As Decimal = 0

        'Validar formulario popup
        If Me.cbxMODALIDAD_FORMACION.Value Is Nothing Then
            Me.lblMensajeErrorPagoAsiste.Text = "* Seleccione la modalidad de formación"
            Return
        End If
        If Me.spePORC_ASISTE_INI.Text = "" Then
            Me.lblMensajeErrorPagoAsiste.Text = "* Ingrese el porcentaje de asistencia inicial"
            Return
        End If
        If Me.spePORC_ASISTE_FIN.Text = "" Then
            Me.lblMensajeErrorPagoAsiste.Text = "* Ingrese el porcentaje de asistencia final"
            Return
        End If
        If Me.spePORC_ASISTE_INI.Value >= Me.spePORC_ASISTE_FIN.Value Then
            Me.lblMensajeErrorPagoAsiste.Text = "* Porcentaje inicial de asistencia no puede ser mayor o igual que porcentaje final"
            Return
        End If
        If Me.spePORC_PAGO_COSTO_PARTI.Text = "" Then
            Me.lblMensajeErrorPagoAsiste.Text = "* Ingrese el porcentaje de pago"
            Return
        End If

        idModalidad = Convert.ToDecimal(Me.cbxMODALIDAD_FORMACION.Value)
        dPorcAsisteIni = Convert.ToDecimal(Me.spePORC_ASISTE_INI.Value)
        dPorcAsisteFin = Convert.ToDecimal(Me.spePORC_ASISTE_FIN.Value)
        lista = Me.LISTA_CONTRATO_COMPRA_PAGO_ASISTE
        If lista Is Nothing Then lista = New listaCONTRATO_COMPRA_PAGO_ASISTE

        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_MODALIDAD_FORMACION = idModalidad AndAlso _
                lista(i).PORC_ASISTE_INI <= dPorcAsisteIni AndAlso _
                dPorcAsisteIni <= lista(i).PORC_ASISTE_FIN Then
                Me.lblMensajeErrorPagoAsiste.Text = "* Ya se ha ingresado un rango en la modalidad " + Me.cbxMODALIDAD_FORMACION.Text + " que incluye el % de asistencia: " + dPorcAsisteIni.ToString
                Return
            End If
        Next
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_MODALIDAD_FORMACION = idModalidad AndAlso _
                lista(i).PORC_ASISTE_INI <= dPorcAsisteFin AndAlso _
                dPorcAsisteFin <= lista(i).PORC_ASISTE_FIN Then
                Me.lblMensajeErrorPagoAsiste.Text = "* Ya se ha ingresado un rango en la modalidad " + Me.cbxMODALIDAD_FORMACION.Text + " que incluye el % de asistencia: " + dPorcAsisteIni.ToString
                Return
            End If
        Next

        lItem.ID_CONTRA_ASISTE = Me.ObtenerIdPagoAsiste(lista)
        lItem.ID_MODALIDAD_FORMACION = idModalidad
        lItem.PORC_ASISTE_INI = dPorcAsisteIni
        lItem.PORC_ASISTE_FIN = dPorcAsisteFin
        lItem.PORC_PAGO_COSTO_PARTI = Convert.ToDecimal(Me.spePORC_PAGO_COSTO_PARTI.Value)
        lItem.REFERENCIA = Me.lblREFERENCIA_PAGO_ASISTE.Text
        lista.Add(lItem)

        Me.LISTA_CONTRATO_COMPRA_PAGO_ASISTE = lista
        Me.CargarDetallePagoAsiste()
        Me.SeleccionarModalidades()
        Me.popAgregarAsistenciaPago.ShowOnPageLoad = False
    End Sub

    Private Sub SeleccionarModalidades()
        Dim lista As listaCONTRATO_COMPRA_PAGO_ASISTE = Me.LISTA_CONTRATO_COMPRA_PAGO_ASISTE
        Dim item As ListEditItem

        Me.lstMODALIDADES.UnselectAll()
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For i As Integer = 0 To lista.Count - 1
                item = Me.lstMODALIDADES.Items.FindByValue(CInt(lista(i).ID_MODALIDAD_FORMACION))
                If item IsNot Nothing Then
                    item.Selected = True
                End If
            Next
        End If
    End Sub

    Protected Sub btnAgregarRgoPagoAsiste_Click(sender As Object, e As EventArgs) Handles btnAgregarRgoPagoAsiste.Click
        Me.lblMensajeErrorPagoAsiste.Text = ""
        Me.cbxMODALIDAD_FORMACION.Value = Nothing
        Me.spePORC_ASISTE_INI.Value = Nothing
        Me.spePORC_ASISTE_FIN.Value = Nothing
        Me.spePORC_PAGO_COSTO_PARTI.Value = Nothing
        Me.popAgregarAsistenciaPago.ShowOnPageLoad = True
        Me.cbxMODALIDAD_FORMACION.Focus()
    End Sub

    Protected Sub cbxFORMA_PAGO_ValueChanged(sender As Object, e As EventArgs) Handles cbxFORMA_PAGO.ValueChanged
        Me.ConfigurarFormaPagoSeleccionada(True)
    End Sub

    Private Sub ConfigurarFormaPagoSeleccionada(Optional seleccionManual As Boolean = False)
        If cbxFORMA_PAGO.Value IsNot Nothing Then
            Select Case CInt(cbxFORMA_PAGO.Value)
                Case FormaPagoContratacion.PorCursoIndeCapacitados
                    TabSolicitud.TabPages(1).ClientEnabled = False
                    If TabSolicitud.TabIndex = 1 Then TabSolicitud.ActiveTabIndex = 0
                    Me.speBASE_PARTI.ClientEnabled = False
                    Me.speBASE_PARTI.Value = Nothing
                    Me.lstMODALIDADES.Enabled = True
                    If seleccionManual Then
                        Me.LISTA_CONTRATO_COMPRA_PAGO_ASISTE = New listaCONTRATO_COMPRA_PAGO_ASISTE
                        Me.CargarDetallePagoAsiste()
                    End If

                Case FormaPagoContratacion.PorParticipantesInscritos
                    TabSolicitud.TabPages(1).ClientEnabled = False
                    If TabSolicitud.TabIndex = 1 Then TabSolicitud.ActiveTabIndex = 0
                    Me.speBASE_PARTI.ClientEnabled = True
                    Me.lstMODALIDADES.Enabled = True
                    If seleccionManual Then
                        Me.LISTA_CONTRATO_COMPRA_PAGO_ASISTE = New listaCONTRATO_COMPRA_PAGO_ASISTE
                        Me.CargarDetallePagoAsiste()
                    End If

                Case FormaPagoContratacion.PorCapacitadosConBase
                    TabSolicitud.TabPages(1).ClientEnabled = False
                    Me.speBASE_PARTI.ClientEnabled = True
                    Me.lstMODALIDADES.Enabled = True
                    If seleccionManual Then
                        Me.LISTA_CONTRATO_COMPRA_PAGO_ASISTE = New listaCONTRATO_COMPRA_PAGO_ASISTE
                        Me.CargarDetallePagoAsiste()
                    End If

                Case FormaPagoContratacion.PorPorcentajeAsistenciaDiferenciado
                    TabSolicitud.TabPages(1).ClientEnabled = True
                    Me.speBASE_PARTI.ClientEnabled = True
                    If seleccionManual Then
                        Me.lstMODALIDADES.Enabled = False
                        Me.lstMODALIDADES.UnselectAll()
                    End If
            End Select
        Else
            TabSolicitud.TabPages(1).ClientEnabled = False
            If TabSolicitud.TabIndex = 1 Then TabSolicitud.ActiveTabIndex = 0
            Me.speBASE_PARTI.ClientEnabled = False
            Me.speBASE_PARTI.Value = Nothing
            Me.lstMODALIDADES.Enabled = False
            Me.lstMODALIDADES.UnselectAll()
            Me.LISTA_CONTRATO_COMPRA_PAGO_ASISTE = New listaCONTRATO_COMPRA_PAGO_ASISTE
            Me.CargarDetallePagoAsiste()
        End If
    End Sub

    Private Sub CargarModalidades()
        Dim listaModalidades As listaMODALIDAD_DE_FORMACION
        listaModalidades = (New cMODALIDAD_DE_FORMACION).ObtenerLista(False, "MODALIDAD_FORMACION")
        Me.lstMODALIDADES.Items.Clear()
        If listaModalidades IsNot Nothing AndAlso listaModalidades.Count > 0 Then
            Me.lstMODALIDADES.DataSource = listaModalidades
            Me.lstMODALIDADES.DataBind()
        End If
    End Sub

    Protected Sub cbxFORMA_PAGO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFORMA_PAGO.SelectedIndexChanged

    End Sub

    Protected Sub ucListaCONTRATO_COMPRA_PAGO_ASISTE1_Eliminando(ID_CONTRA_ASISTE As Decimal) Handles ucListaCONTRATO_COMPRA_PAGO_ASISTE1.Eliminando
        Me.SeleccionarModalidades()
    End Sub
End Class
