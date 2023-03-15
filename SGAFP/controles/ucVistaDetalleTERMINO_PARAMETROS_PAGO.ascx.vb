Imports SGAFP.BL
Imports SGAFP.EL
Imports DevExpress.Web.ASPxEditors

Partial Class controles_ucVistaDetalleTERMINO_PARAMETROS_PAGO
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
    Public Property ID_TERMINO_PARAM() As Decimal
        Get
            If Me.ViewState("ID_TERMINO_PARAM") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_TERMINO_PARAM"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Decimal)
            Me.ViewState("ID_TERMINO_PARAM") = Value
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

    Public Property LISTA_TERMINO_PAGO_PENALIZACION As listaTERMINO_PAGO_PENALIZACION
        Set(value As listaTERMINO_PAGO_PENALIZACION)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), ListaTERMINO_PAGO_PENALIZACION) Else Return New ListaTERMINO_PAGO_PENALIZACION
        End Get
    End Property

    Public Property LISTA_TERMINO_PAGO_ASISTE As listaTERMINO_PAGO_ASISTE
        Set(value As listaTERMINO_PAGO_ASISTE)
            Session(Me.lblREFERENCIA_PAGO_ASISTE.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA_PAGO_ASISTE.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA_PAGO_ASISTE.Text), listaTERMINO_PAGO_ASISTE) Else Return New listaTERMINO_PAGO_ASISTE
        End Get
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cTERMINO_PARAMETROS_PAGO
    Private mEntidad As TERMINO_PARAMETROS_PAGO
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
            Me.ucListaTERMINO_PAGO_PENALIZACION1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
    End Sub

    Public Sub CargarDetallePagoAsiste()
        If Me.lblREFERENCIA_PAGO_ASISTE.Text <> "" Then
            Me.ucListaTERMINO_PAGO_ASISTE1.CargarDatosCache(Me.lblREFERENCIA_PAGO_ASISTE.Text)
        End If
    End Sub

    Private Sub CargarCentrosResponsabilidad()
        Dim lista As listaCENTRO_RESPONSABILIDAD
        Dim idUnidadOrg As Decimal = IIf(Me.cbxUNIDAD_ORGANIZATIVA.Value = Nothing, -2, CDec(Me.cbxUNIDAD_ORGANIZATIVA.Value))

        lista = (New cCENTRO_RESPONSABILIDAD).ObtenerListaPorUNIDAD_ORGANIZATIVA(idUnidadOrg, True, "[Aplica a todos]")
        If lista Is Nothing Then
            lista = New listaCENTRO_RESPONSABILIDAD
            Dim lEntidad As New CENTRO_RESPONSABILIDAD
            lEntidad.ID_CENTRO_RESPONSABILIDAD = -1
            lEntidad.NOMBRE_CENTRO_RESPONSABILIDAD = "[Aplica a todos]"
            lista.Insert(0, lEntidad)
        End If
        Me.cbxCENTRO_RESPONSABILIDAD.DataSource = lista
        Me.cbxCENTRO_RESPONSABILIDAD.DataBind()

    End Sub

    Private Sub CargarDatos()
        Dim sError As New String("")
        Dim listaPenalizaciones As ListaTERMINO_PAGO_PENALIZACION
        Dim listaPagoAsiste As listaTERMINO_PAGO_ASISTE

        Me.esNuevo = False
        mEntidad = New TERMINO_PARAMETROS_PAGO
        mEntidad = mComponente.ObtenerTERMINO_PARAMETROS_PAGO(ID_TERMINO_PARAM)
        If mEntidad Is Nothing Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If

        Me.txtID_TERMINO_PARAM.Text = mEntidad.ID_TERMINO_PARAM.ToString()
        Me.txtDESCRIPCION.Text = mEntidad.DESCRIPCION
        Me.txtTDR.Text = mEntidad.TDR
        Me.cbxUNIDAD_ORGANIZATIVA.Value = Convert.ToInt32(mEntidad.ID_UNIDAD_ORGANIZATIVA)
        Me.CargarCentrosResponsabilidad()
        Me.cbxCENTRO_RESPONSABILIDAD.Value = Convert.ToInt32(mEntidad.ID_CENTRO_RESPONSABILIDAD)
        Me.cbxREFERENTE.Value = Convert.ToInt32(mEntidad.ID_REFERENTE)
        Me.chkACTIVO.Checked = IIf(mEntidad.ACTIVO = 1, True, False)
        
        Me.spePORC_ASISTENCIA_MIN.Value = IIf(mEntidad.PORC_ASISTENCIA_MIN = 0, Nothing, mEntidad.PORC_ASISTENCIA_MIN)
        Me.CargarFormaPagoTDR()
        Me.cbxFORMA_PAGO.Value = CInt(mEntidad.ID_FORMA_PAGO)
        Me.speBASE_PARTI.Value = IIf(mEntidad.BASE_PARTI = -1, Nothing, mEntidad.BASE_PARTI)

        'Penalizaciones
        listaPenalizaciones = (New cTERMINO_PAGO_PENALIZACION).ObtenerListaPorTERMINO_PARAMETROS_PAGO(mEntidad.ID_TERMINO_PARAM)
        If listaPenalizaciones IsNot Nothing AndAlso listaPenalizaciones.Count > 0 Then
            For i As Integer = 0 To listaPenalizaciones.Count - 1
                listaPenalizaciones(i).REFERENCIA = Me.lblREFERENCIA.Text
            Next
            Me.LISTA_TERMINO_PAGO_PENALIZACION = listaPenalizaciones
        Else
            Me.LISTA_TERMINO_PAGO_PENALIZACION = New ListaTERMINO_PAGO_PENALIZACION
        End If
        Me.CargarDetallePenalizaciones()

        'Parametros de pago por asistencia
        listaPagoAsiste = (New cTERMINO_PAGO_ASISTE).ObtenerListaPorTERMINO_PARAMETROS_PAGO(mEntidad.ID_TERMINO_PARAM)
        If listaPagoAsiste IsNot Nothing AndAlso listaPagoAsiste.Count > 0 Then
            For i As Integer = 0 To listaPagoAsiste.Count - 1
                listaPagoAsiste(i).REFERENCIA = Me.lblREFERENCIA_PAGO_ASISTE.Text
            Next
            Me.LISTA_TERMINO_PAGO_ASISTE = listaPagoAsiste
        Else
            Me.LISTA_TERMINO_PAGO_ASISTE = New listaTERMINO_PAGO_ASISTE
        End If
        Me.CargarDetallePagoAsiste()
        Me.MarcarModalidades()
        Me.ConfigurarFormaPagoSeleccionada()
        Me.ConfigIngresoTDR()
    End Sub

    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_TERMINO_PARAM.ClientEnabled = False
        Me.txtDESCRIPCION.ClientEnabled = edicion
        Me.txtTDR.ClientEnabled = edicion
        Me.cbxUNIDAD_ORGANIZATIVA.ClientEnabled = edicion
        Me.cbxCENTRO_RESPONSABILIDAD.ClientEnabled = edicion
        Me.cbxREFERENTE.ClientEnabled = edicion
        Me.btnCargarPlantilla.ClientEnabled = edicion
        Me.btnAgregar.ClientEnabled = edicion
        Me.btnBorrarRangos.ClientEnabled = edicion
        If Me.cbxFORMA_PAGO.Value IsNot Nothing AndAlso CInt(Me.cbxFORMA_PAGO.Value) = FormaPagoContratacion.PorPorcentajeAsistenciaDiferenciado Then
            Me.lstMODALIDADES.Enabled = False
        Else
            Me.lstMODALIDADES.Enabled = edicion And Not esNuevo
        End If

        Me.btnAgregarRgoPagoAsiste.ClientEnabled = edicion
        Me.btnLimpiarRgoPagoAsiste.ClientEnabled = edicion
        Me.ConfigIngresoTDR()
    End Sub

    Private Sub Nuevo()
        Me.esNuevo = True
        Me.TabSolicitud.TabPages(1).ClientEnabled = False
        Me.txtID_TERMINO_PARAM.Text = ""
        Me.txtDESCRIPCION.Text = ""
        Me.txtTDR.Text = ""
        Me.cbxUNIDAD_ORGANIZATIVA.SelectedIndex = 0
        Me.CargarCentrosResponsabilidad()
        Me.cbxCENTRO_RESPONSABILIDAD.SelectedIndex = 0
        Me.cbxREFERENTE.SelectedIndex = 0
        Me.spePORC_ASISTENCIA_MIN.Text = ""
        Me.cbxFORMA_PAGO.Value = Nothing
        Me.speBASE_PARTI.Value = Nothing
        Me.chkACTIVO.Checked = True
        Me.LISTA_TERMINO_PAGO_PENALIZACION = New ListaTERMINO_PAGO_PENALIZACION
        Me.CargarDetallePenalizaciones()
        Me.LISTA_TERMINO_PAGO_ASISTE = New listaTERMINO_PAGO_ASISTE
        Me.CargarDetallePagoAsiste()
        Me.ConfigurarFormaPagoSeleccionada()
        Me.CargarFormaPagoTDR()
    End Sub

    Protected Sub btnBorrarRangos_Click(sender As Object, e As EventArgs) Handles btnBorrarRangos.Click
        Me.LISTA_TERMINO_PAGO_PENALIZACION = New ListaTERMINO_PAGO_PENALIZACION
        Me.CargarDetallePenalizaciones()
    End Sub

    Protected Sub btnLimpiarRgoPagoAsiste_Click(sender As Object, e As EventArgs) Handles btnLimpiarRgoPagoAsiste.Click
        Me.LISTA_TERMINO_PAGO_ASISTE = New listaTERMINO_PAGO_ASISTE
        Me.CargarDetallePagoAsiste()
        Me.SeleccionarModalidades()
    End Sub

    Private Sub MarcarModalidades()
        Dim lst As listaTERMINO_PAGO_MODALIDAD
        Dim item As ListEditItem

        lst = (New cTERMINO_PAGO_MODALIDAD).ObtenerListaPorTERMINO_PARAMETROS_PAGO(Me.ID_TERMINO_PARAM)
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
        Dim bContratoCompra As New cTERMINO_PARAMETROS_PAGO
        Dim bTerminoPagoPena As New cTERMINO_PAGO_PENALIZACION
        Dim bTerminoPagoAsiste As New cTERMINO_PAGO_ASISTE
        Dim bTerminoPagoModalidad As New cTERMINO_PAGO_MODALIDAD
        Dim listaPena As listaTERMINO_PAGO_PENALIZACION
        Dim listaPagoAsiste As listaTERMINO_PAGO_ASISTE
        Dim idTerminoParam As Integer = 0
        Dim lista As listaTERMINO_PARAMETROS_PAGO
        Dim bFormaPagoAnteriores As Boolean = False

        listaPena = Me.LISTA_TERMINO_PAGO_PENALIZACION
        listaPagoAsiste = Me.LISTA_TERMINO_PAGO_ASISTE
        If Not Me.esNuevo Then
            mEntidad = bContratoCompra.ObtenerTERMINO_PARAMETROS_PAGO(ID_TERMINO_PARAM)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = Now
            idTerminoParam = ID_TERMINO_PARAM
        Else
            mEntidad = New TERMINO_PARAMETROS_PAGO
            mEntidad.ID_TERMINO_PARAM = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = Now
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = Now
        End If
        If Me.txtDESCRIPCION.Text.Trim = "" Then
            sError.AppendLine("* Ingrese una descripcion que identifique la parametrizacion")
        End If
        If Me.cbxFORMA_PAGO.Value Is Nothing Then
            sError.AppendLine("* Seleccione una forma de pago")
        Else
            bFormaPagoAnteriores = CDec(Me.cbxFORMA_PAGO.Value) = FormaPagoContratacion.PorCursoIndeCapacitados OrElse _
                CDec(Me.cbxFORMA_PAGO.Value) = FormaPagoContratacion.PorCapacitadosConBase OrElse _
                CDec(Me.cbxFORMA_PAGO.Value) = FormaPagoContratacion.PorParticipantesInscritos OrElse _
                CDec(Me.cbxFORMA_PAGO.Value) = FormaPagoContratacion.PorPorcentajeAsistenciaDiferenciado

            If (Me.spePORC_ASISTENCIA_MIN.Value Is Nothing OrElse Not IsNumeric(Me.spePORC_ASISTENCIA_MIN.Text)) AndAlso bFormaPagoAnteriores Then
                sError.AppendLine("* Ingrese el porcentaje mínimo de asistencia")
            End If
            'If CDec(Me.cbxFORMA_PAGO.Value) = FormaPagoContratacion.PorCapacitadosConBase AndAlso (Me.speBASE_PARTI.Text.Trim = "" OrElse Not IsNumeric(Me.speBASE_PARTI.Text.Trim)) Then
            '    sError.AppendLine("* Ingrese la cantidad base de participantes para pago")
            'End If
        End If
        If CDec(Me.cbxFORMA_PAGO.Value) = FormaPagoContratacion.PorPorcentajeAsistenciaDiferenciado AndAlso (listaPagoAsiste Is Nothing OrElse listaPagoAsiste.Count = 0) Then
            sError.AppendLine("* Ingrese los parámetros de pago por asistencia")
        End If
        If Me.lstMODALIDADES.SelectedIndices.Count = 0 Then
            sError.AppendLine("* Seleccione alguna modalidad de ejecucion")
        End If
        'VERIFICAR SI LOS CRITERIOS SE REPITEN CON OTRA CONFIGURACION YA CREADA
        'lista = mComponente.ObtenerListaPorNO_TERMINO_PARAMETROS_PAGO(Me.txtNO_TERMINO_PARAMETROS_PAGO.Text.Trim)
        'If lista IsNot Nothing AndAlso lista.Count > 0 Then
        '    If Me.esNuevo OrElse (mEntidad.ID_TERMINO_PARAM <> lista(0).ID_TERMINO_PARAM) Then
        '        sError.AppendLine("* Ya existe una oferta de compra No. " + Me.txtNO_TERMINO_PARAMETROS_PAGO.Text.Trim + " registrada en el sistema")
        '        Return -1
        '    End If
        'End If
        If sError.ToString <> "" Then
            Return sError.ToString
        End If

        mEntidad.TDR = Me.txtTDR.Text.Trim.ToUpper
        mEntidad.DESCRIPCION = Utilerias.QuitarAcentoEspaciosMinusculas(Me.txtDESCRIPCION.Text.Trim.ToUpper)
        mEntidad.ID_UNIDAD_ORGANIZATIVA = Convert.ToDecimal(Me.cbxUNIDAD_ORGANIZATIVA.Value)
        mEntidad.ID_CENTRO_RESPONSABILIDAD = Convert.ToDecimal(Me.cbxCENTRO_RESPONSABILIDAD.Value)
        mEntidad.ID_REFERENTE = Convert.ToDecimal(Me.cbxREFERENTE.Value)
        
        mEntidad.ID_FORMA_PAGO = CDec(Me.cbxFORMA_PAGO.Value)
        mEntidad.PORC_ASISTENCIA_MIN = Convert.ToDecimal(Me.spePORC_ASISTENCIA_MIN.Value)
        mEntidad.ACTIVO = IIf(chkACTIVO.Checked, 1, 0)
        
        If Me.cbxFORMA_PAGO.Value = FormaPagoContratacion.PorCapacitadosConBase Then
            mEntidad.BASE_PARTI = Convert.ToDecimal(Me.speBASE_PARTI.Value)
        Else
            mEntidad.BASE_PARTI = -1
        End If

        'Guardar datos de la oferta
        If mComponente.ActualizarTERMINO_PARAMETROS_PAGO(mEntidad, TipoConcurrencia.Pesimistica) <> 1 Then
            Return "Fallo al guardar Oferta de Compra: " + mComponente.sError
        End If

        'Asignar ID_TERMINO_PARAM si es nuevo
        If esNuevo Then idTerminoParam = mEntidad.ID_TERMINO_PARAM

        'Guardar datos de las penalizaciones
        bTerminoPagoPena.EliminarlistaTERMINO_PAGO_PENALIZACION(Me.ID_TERMINO_PARAM)
        If listaPena IsNot Nothing AndAlso listaPena.Count > 0 Then
            For i As Integer = 0 To listaPena.Count - 1
                Dim lEntidadPena As New TERMINO_PAGO_PENALIZACION
                lEntidadPena.ID_TERMINO_PENA = 0
                lEntidadPena.ID_TERMINO_PARAM = idTerminoParam
                lEntidadPena.ID_TIPO_PENA = listaPena(i).ID_TIPO_PENA
                lEntidadPena.RANGO_INI = listaPena(i).RANGO_INI
                lEntidadPena.RANGO_FIN = listaPena(i).RANGO_FIN
                lEntidadPena.PORC_PENA = listaPena(i).PORC_PENA
                lEntidadPena.USUARIO_CREA = Me.ObtenerUsuario
                lEntidadPena.FECHA_CREA = Now
                lEntidadPena.USUARIO_ACT = Me.ObtenerUsuario
                lEntidadPena.FECHA_ACT = Now

                bTerminoPagoPena.ActualizarTERMINO_PAGO_PENALIZACION(lEntidadPena, TipoConcurrencia.Pesimistica)
            Next
        End If
        'Guardar datos de pago por asistencia
        bTerminoPagoAsiste.EliminarlistaTERMINO_PAGO_ASISTE(Me.ID_TERMINO_PARAM)
        If Me.cbxFORMA_PAGO.Value = FormaPagoContratacion.PorPorcentajeAsistenciaDiferenciado AndAlso listaPagoAsiste IsNot Nothing AndAlso listaPagoAsiste.Count > 0 Then
            For i As Integer = 0 To listaPagoAsiste.Count - 1
                Dim lEntidadPago As New TERMINO_PAGO_ASISTE
                lEntidadPago.ID_TERMINO_ASISTE = 0
                lEntidadPago.ID_TERMINO_PARAM = idTerminoParam
                lEntidadPago.ID_MODALIDAD_FORMACION = listaPagoAsiste(i).ID_MODALIDAD_FORMACION
                lEntidadPago.PORC_ASISTE_INI = listaPagoAsiste(i).PORC_ASISTE_INI
                lEntidadPago.PORC_ASISTE_FIN = listaPagoAsiste(i).PORC_ASISTE_FIN
                lEntidadPago.PORC_PAGO_COSTO_PARTI = listaPagoAsiste(i).PORC_PAGO_COSTO_PARTI
                lEntidadPago.USUARIO_CREA = Me.ObtenerUsuario
                lEntidadPago.FECHA_CREA = Now
                lEntidadPago.USUARIO_ACT = Me.ObtenerUsuario
                lEntidadPago.FECHA_ACT = Now

                bTerminoPagoAsiste.ActualizarTERMINO_PAGO_ASISTE(lEntidadPago, TipoConcurrencia.Pesimistica)
            Next
        End If

        'Guardar modalidades
        bTerminoPagoModalidad.EliminarlistaTERMINO_PAGO_MODALIDAD(Me.ID_TERMINO_PARAM)
        If Me.lstMODALIDADES.SelectedItems.Count > 0 Then
            Dim lTerminoModalidad As TERMINO_PAGO_MODALIDAD
            For Each item As ListEditItem In Me.lstMODALIDADES.Items
                If item.Selected Then
                    lTerminoModalidad = New TERMINO_PAGO_MODALIDAD
                    lTerminoModalidad.ID_TERMINO_MODAL = 0
                    lTerminoModalidad.ID_TERMINO_PARAM = idTerminoParam
                    lTerminoModalidad.ID_MODALIDAD_FORMACION = CDec(item.Value)
                    lTerminoModalidad.USUARIO_CREA = Me.ObtenerUsuario
                    lTerminoModalidad.FECHA_CREA = Now
                    lTerminoModalidad.USUARIO_ACT = Me.ObtenerUsuario
                    lTerminoModalidad.FECHA_ACT = Now

                    bTerminoPagoModalidad.ActualizarTERMINO_PAGO_MODALIDAD(lTerminoModalidad)
                End If
            Next
        End If

        Me.esNuevo = False
        Return ""
    End Function

    Protected Sub btnCargarPlantilla_Click(sender As Object, e As EventArgs) Handles btnCargarPlantilla.Click
        Dim listaPlantilla As listaRANGO_PORC_PENA = (New cRANGO_PORC_PENA).ObtenerListaPorPROGRAMA_FORMACION(ProgramasFormacion.HABIL_TECNICO_PERMANENTE)
        Dim listaContratoPena As New ListaTERMINO_PAGO_PENALIZACION
        Dim lEntidad As TERMINO_PAGO_PENALIZACION

        Me.LISTA_TERMINO_PAGO_PENALIZACION = New ListaTERMINO_PAGO_PENALIZACION
        If listaPlantilla IsNot Nothing AndAlso listaPlantilla.Count > 0 Then
            For i = 0 To listaPlantilla.Count - 1
                lEntidad = New TERMINO_PAGO_PENALIZACION
                lEntidad.ID_TERMINO_PENA = ObtenerIdPena(listaContratoPena)
                lEntidad.ID_TIPO_PENA = listaPlantilla(i).ID_TIPO_PENA
                lEntidad.RANGO_INI = listaPlantilla(i).RANGO_INI
                lEntidad.RANGO_FIN = listaPlantilla(i).RANGO_FIN
                lEntidad.PORC_PENA = listaPlantilla(i).PORC_PENA
                lEntidad.REFERENCIA = Me.lblREFERENCIA.Text
                listaContratoPena.Add(lEntidad)
            Next
        End If

        Me.LISTA_TERMINO_PAGO_PENALIZACION = listaContratoPena
        Me.CargarDetallePenalizaciones()
    End Sub

    Private Function ObtenerIdPena(ByVal lista As listaTERMINO_PAGO_PENALIZACION) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_TERMINO_PENA > Id Then
                Id = lista(i).ID_TERMINO_PENA
            End If
        Next
        Return (Id + 1)
    End Function

    Private Function ObtenerIdPagoAsiste(ByVal lista As listaTERMINO_PAGO_ASISTE) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_TERMINO_ASISTE > Id Then
                Id = lista(i).ID_TERMINO_ASISTE
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
        Dim lista As ListaTERMINO_PAGO_PENALIZACION
        Dim lItem As New TERMINO_PAGO_PENALIZACION

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

        lista = Me.LISTA_TERMINO_PAGO_PENALIZACION
        If lista Is Nothing Then lista = New ListaTERMINO_PAGO_PENALIZACION
        lItem.ID_TERMINO_PENA = Me.ObtenerIdPena(lista)
        lItem.ID_TIPO_PENA = Convert.ToDecimal(Me.cbxTIPO_PENALIZA.Value)
        lItem.RANGO_INI = Convert.ToDecimal(Me.speRANGO_INICIAL.Value)
        lItem.RANGO_FIN = Convert.ToDecimal(Me.speRANGO_FINAL.Value)
        lItem.PORC_PENA = Convert.ToDecimal(Me.spePORCENTAJE_PENALIZACION.Value)
        lItem.REFERENCIA = Me.lblREFERENCIA.Text
        lista.Add(lItem)

        Me.LISTA_TERMINO_PAGO_PENALIZACION = lista
        Me.CargarDetallePenalizaciones()
        Me.popAgregarPenalizacion.ShowOnPageLoad = False
    End Sub

    Protected Sub btnAgregarPagoAsiste_Click(sender As Object, e As EventArgs) Handles btnAgregarPagoAsiste.Click
        Dim lista As listaTERMINO_PAGO_ASISTE
        Dim lItem As New TERMINO_PAGO_ASISTE
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
        lista = Me.LISTA_TERMINO_PAGO_ASISTE
        If lista Is Nothing Then lista = New listaTERMINO_PAGO_ASISTE

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

        lItem.ID_TERMINO_ASISTE = Me.ObtenerIdPagoAsiste(lista)
        lItem.ID_MODALIDAD_FORMACION = idModalidad
        lItem.PORC_ASISTE_INI = dPorcAsisteIni
        lItem.PORC_ASISTE_FIN = dPorcAsisteFin
        lItem.PORC_PAGO_COSTO_PARTI = Convert.ToDecimal(Me.spePORC_PAGO_COSTO_PARTI.Value)
        lItem.REFERENCIA = Me.lblREFERENCIA_PAGO_ASISTE.Text
        lista.Add(lItem)

        Me.LISTA_TERMINO_PAGO_ASISTE = lista
        Me.CargarDetallePagoAsiste()
        Me.SeleccionarModalidades()
        Me.popAgregarAsistenciaPago.ShowOnPageLoad = False
    End Sub

    Private Sub SeleccionarModalidades()
        Dim lista As listaTERMINO_PAGO_ASISTE = Me.LISTA_TERMINO_PAGO_ASISTE
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
                Case FormaPagoContratacion.PorCursoIndeCapacitados, _
                    FormaPagoContratacion.PorParticipantesInscritos
                    TabSolicitud.TabPages(1).ClientEnabled = False
                    If TabSolicitud.TabIndex = 1 Then TabSolicitud.ActiveTabIndex = 0
                    Me.speBASE_PARTI.ClientEnabled = False
                    Me.speBASE_PARTI.Value = Nothing
                    Me.spePORC_ASISTENCIA_MIN.ClientEnabled = True
                    Me.lstMODALIDADES.Enabled = True
                    If seleccionManual Then
                        Me.LISTA_TERMINO_PAGO_ASISTE = New listaTERMINO_PAGO_ASISTE
                        Me.CargarDetallePagoAsiste()
                    End If

                Case FormaPagoContratacion.PorCapacitadosConBase
                    TabSolicitud.TabPages(1).ClientEnabled = False
                    Me.speBASE_PARTI.ClientEnabled = True
                    Me.spePORC_ASISTENCIA_MIN.ClientEnabled = True
                    Me.lstMODALIDADES.Enabled = True
                    If seleccionManual Then
                        Me.LISTA_TERMINO_PAGO_ASISTE = New listaTERMINO_PAGO_ASISTE
                        Me.CargarDetallePagoAsiste()
                    End If

                Case FormaPagoContratacion.PorPorcentajeAsistenciaDiferenciado
                    TabSolicitud.TabPages(1).ClientEnabled = True
                    Me.speBASE_PARTI.ClientEnabled = False
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
            Me.spePORC_ASISTENCIA_MIN.ClientEnabled = True
            Me.lstMODALIDADES.Enabled = False
            Me.lstMODALIDADES.UnselectAll()
            Me.LISTA_TERMINO_PAGO_ASISTE = New listaTERMINO_PAGO_ASISTE
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

    Protected Sub ucListaTERMINO_PAGO_ASISTE1_Eliminando(ID_TERMINO_ASISTE As Decimal) Handles ucListaTERMINO_PAGO_ASISTE1.Eliminando
        Me.SeleccionarModalidades()
    End Sub

    Protected Sub txtTDR_TextChanged(sender As Object, e As EventArgs) Handles txtTDR.TextChanged
        Me.ConfigIngresoTDR()
    End Sub

    Private Sub ConfigIngresoTDR()
        cbxUNIDAD_ORGANIZATIVA.ClientEnabled = IIf(txtTDR.Text.Trim = "", True, False)
        cbxCENTRO_RESPONSABILIDAD.ClientEnabled = IIf(txtTDR.Text.Trim = "", True, False)
        cbxREFERENTE.ClientEnabled = IIf(txtTDR.Text.Trim = "", True, False)
        If txtTDR.Text.Trim <> "" Then
            cbxUNIDAD_ORGANIZATIVA.SelectedIndex = 0
            cbxCENTRO_RESPONSABILIDAD.SelectedIndex = 0
            cbxREFERENTE.SelectedIndex = 0
        End If
    End Sub

    Private Sub CargarFormaPagoTDR()
        Dim lista As listaFORMA_PAGO = New listaFORMA_PAGO
        Dim lEntidad As FORMA_PAGO

        lEntidad = (New cFORMA_PAGO).ObtenerFORMA_PAGO(FormaPagoContratacion.PorCursoIndeCapacitados)
        If lEntidad IsNot Nothing Then lista.Add(lEntidad)

        lEntidad = (New cFORMA_PAGO).ObtenerFORMA_PAGO(FormaPagoContratacion.PorPorcentajeAsistenciaDiferenciado)
        If lEntidad IsNot Nothing Then lista.Add(lEntidad)

        Me.cbxFORMA_PAGO.DataSource = lista
        Me.cbxFORMA_PAGO.DataBind()
    End Sub

    Protected Sub cbxUNIDAD_ORGANIZATIVA_ValueChanged(sender As Object, e As EventArgs) Handles cbxUNIDAD_ORGANIZATIVA.ValueChanged
        CargarCentrosResponsabilidad()
    End Sub
End Class
