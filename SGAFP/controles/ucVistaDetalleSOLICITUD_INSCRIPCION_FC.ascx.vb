Imports DevExpress.Web.ASPxEditors
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SGAFP.DL.DS_DL
Imports SGAFP.DL.DS_DLTableAdapters
Imports DevExpress.Web.ASPxClasses

Partial Class controles_ucVistaDetalleSOLICITUD_INSCRIPCION_FC
    Inherits ucBase

    Private mComponente As New cSOLICITUD_INSCRIPCION_AF
    Private mEntidad As SOLICITUD_INSCRIPCION_AF
    Private _nuevo As Boolean = False
    Public Event ErrorEvent(ByVal errorMessage As String)

    Private _CODIGO_ERROR As Integer
    Public ReadOnly Property CODIGO_ERROR() As Integer
        Get
            Return _CODIGO_ERROR
        End Get
    End Property

    Public Property ID_PARTICIPANTE() As Decimal
        Get
            If Me.ID_PARTICIPANTEtxt.Text.Trim = "" Then
                Return 0
            Else
                Return CDec(Me.ID_PARTICIPANTEtxt.Text.Trim)
            End If
        End Get
        Set(ByVal value As Decimal)
            Me.ID_PARTICIPANTEtxt.Text = value
        End Set
    End Property

    Public Property FECHA_NACIMIENTO() As Date
        Get
            Return Me.FECHA_NACIMIENTODateEdit.Date
        End Get
        Set(ByVal value As Date)
            Me.FECHA_NACIMIENTODateEdit.Date = value
        End Set
    End Property

    Public Property APELLIDOS() As String
        Get
            Return Me.APELLIDOStxt.Text
        End Get
        Set(ByVal value As String)
            Me.APELLIDOStxt.Text = value
        End Set
    End Property

    Public Property NOMBRES() As String
        Get
            Return Me.NOMBREStxt.Text
        End Get
        Set(ByVal value As String)
            Me.NOMBREStxt.Text = value
        End Set
    End Property

    Public Property DUI() As String
        Get
            Return Me.DUItxt.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.DUItxt.Text = value
        End Set
    End Property

    Public Property NIT() As String
        Get
            Return Me.NITtxt.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.NITtxt.Text = value
        End Set
    End Property

    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            If Me.ID_ACCION_FORMATIVAtxt.Text <> "" Then Return Me.ID_ACCION_FORMATIVAtxt.Text
            Return -1
        End Get
        Set(ByVal value As Decimal)
            Me.ID_ACCION_FORMATIVAtxt.Text = value
        End Set
    End Property

    Private _ID_SOLICITUD As Decimal
    Public Property ID_SOLICITUD() As Decimal
        Get
            Return Me.ID_SOLICITUDtxt.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_SOLICITUD = Value
            Me.ID_SOLICITUDtxt.Text = CStr(Value)
            If Me._ID_SOLICITUD > 0 Then
                Me.CargarDatos()
            Else
                Me.Nuevo()
            End If
        End Set
    End Property

    Private Sub CargarDepartamentos(ByVal cmbDepartamento As ASPxComboBox)
        cmbDepartamento.DataBind()
    End Sub
   

    Private Sub CargarMunicipios(ByVal odsMunicipio As ObjectDataSource, ByVal cmbMunicipio As ASPxComboBox, ByVal CODIGO_DEPARTAMENTO As String)
        odsMunicipio.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = CODIGO_DEPARTAMENTO
        cmbMunicipio.DataBind()
    End Sub


   
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsCallback Then
            Me.CargarDepartamentos(Me.CODIGO_DEPARTAMENTOcbx)
        End If
        Habilitar()
    End Sub

    Public Sub Habilitar(Optional ByVal valor As Boolean = True)
        Dim Condicion As Boolean

        BuscarNombresbtn.ClientEnabled = valor
        BuscarDUIbtn.ClientEnabled = valor
        BuscarNITbtn.ClientEnabled = valor

        ID_ACCION_FORMATIVAtxt.ClientVisible = False
        ID_TIPO_SOLICITUDtxt.ClientVisible = False
        ID_ESTADO_SOLICITUDtxt.ClientVisible = False
        FECHA_PRESENTACIONDateEdit.ClientEnabled = valor
        NOMBREStxt.ClientEnabled = valor
        APELLIDOStxt.ClientEnabled = valor
        DUItxt.ClientEnabled = IIf(Me.ID_SOLICITUDtxt.Text <> "", False, valor)
        NITtxt.ClientEnabled = IIf(Me.ID_SOLICITUDtxt.Text <> "", False, valor)
        ISSStxt.ClientEnabled = valor
        FECHA_NACIMIENTODateEdit.ClientEnabled = valor
        GENERORadioButtonList.ClientEnabled = valor
        CODIGO_DEPARTAMENTOcbx.ClientEnabled = valor
        CODIGO_MUNICIPIOcbx.ClientEnabled = valor
        MOVILtxt.ClientEnabled = valor
        EMAILtxt.ClientEnabled = valor
    End Sub

    Public Sub Nuevo()
        TabSolicitud.ActiveTabIndex = 0
        ID_SOLICITUDtxt.Text = ""
        ID_TIPO_SOLICITUDtxt.Text = ""
        ID_ESTADO_SOLICITUDtxt.Text = Enumeradores.EstadoSolicitud.EnEsperaDeAprobacion
        FECHA_PRESENTACIONDateEdit.Text = ""
        ID_PARTICIPANTEtxt.Text = ""
        NOMBREStxt.Text = ""
        APELLIDOStxt.Text = ""
        DUItxt.Text = ""
        NITtxt.Text = ""
        ISSStxt.Text = ""
        FECHA_NACIMIENTODateEdit.Text = ""
        EDADtxt.Text = ""
        CODIGO_DEPARTAMENTOcbx.SelectedIndex = -1
        CODIGO_MUNICIPIOcbx.SelectedIndex = -1
        MOVILtxt.Text = ""
        EMAILtxt.Text = ""
    End Sub

    Function CalcularEdad(ByVal fechaNacimiento As DateTime) As Integer
        Dim años As Integer = Now.Year - fechaNacimiento.Year
        If Now.Month < fechaNacimiento.Month Or (Now.Month = fechaNacimiento.Month And Now.Day < fechaNacimiento.Day) Then años -= 1
        Return años
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla PARTICIPANTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosParticipante() As String
        Dim bParticipante As New cPARTICIPANTE
        Dim eParticipante As New PARTICIPANTE
        Dim item As New DevExpress.Web.ASPxEditors.ListEditItem


        eParticipante.ID_PARTICIPANTE = Me.ID_PARTICIPANTE
        If bParticipante.ObtenerPARTICIPANTE(eParticipante) <> 1 Then
            Return "Error al Obtener registro de Participante."
        End If
        With eParticipante
            NOMBREStxt.Text = .NOMBRES
            APELLIDOStxt.Text = .APELLIDOS
            DUItxt.Text = .DUI
            NITtxt.Text = .NIT
            ISSStxt.Text = .ISSS
            FECHA_NACIMIENTODateEdit.Value = .FECHA_NACIMIENTO
            If .GENERO = "M" Then GENERORadioButtonList.Value = 1 Else GENERORadioButtonList.Value = 2
            EDADtxt.Text = CalcularEdad(.FECHA_NACIMIENTO)
            Me.CargarDepartamentos(CODIGO_DEPARTAMENTOcbx)
            CODIGO_DEPARTAMENTOcbx.Value = .CODIGO_DEPARTAMENTO
            Me.CargarMunicipios(odsCODIGO_MUNICIPIOcbx, CODIGO_MUNICIPIOcbx, .CODIGO_DEPARTAMENTO)
            CODIGO_MUNICIPIOcbx.Value = .CODIGO_MUNICIPIO
            MOVILtxt.Text = .MOVIL
            EMAILtxt.Text = .EMAIL
            'Mostrar discapacidades
            Dim ListaDiscapacidades As New listaDISCA_POR_PARTICIPANTE
            ListaDiscapacidades = (New cDISCA_POR_PARTICIPANTE).ObtenerListaPorPARTICIPANTE(Me.ID_PARTICIPANTE)
           
        End With
        Return ""
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New SOLICITUD_INSCRIPCION_AF
        mEntidad.ID_SOLICITUD = ID_SOLICITUD

        If mComponente.ObtenerSOLICITUD_INSCRIPCION_AF(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        With mEntidad
            Me.ID_SOLICITUDtxt.Text = .ID_SOLICITUD
            Me.FECHA_PRESENTACIONDateEdit.Date = .FECHA_PRESENTACION
            Me.ID_ACCION_FORMATIVAtxt.Text = .ID_ACCION_FORMATIVA
            Me.ID_TIPO_SOLICITUDtxt.Text = .ID_TIPO_SOLICITUD
            Me.ID_ESTADO_SOLICITUDtxt.Text = .ID_ESTADO_SOLICITUD
            Me.ID_PARTICIPANTEtxt.Text = .ID_PARTICIPANTE
            Me.NOMBREStxt.Text = .NOMBRES
            Me.APELLIDOStxt.Text = .APELLIDOS
            Me.DUItxt.Text = .DUI
            Me.NITtxt.Text = .NIT
            Me.ISSStxt.Text = .ISSS

          
            Me.FECHA_NACIMIENTODateEdit.Value = .FECHA_NACIMIENTO
            If .GENERO = "M" Then Me.GENERORadioButtonList.Value = 1 Else Me.GENERORadioButtonList.Value = 2
            Me.EDADtxt.Text = CalcularEdad(.FECHA_NACIMIENTO)
            Me.CargarDepartamentos(CODIGO_DEPARTAMENTOcbx)
            Me.CODIGO_DEPARTAMENTOcbx.Value = .CODIGO_DEPARTAMENTO
            Me.CargarMunicipios(odsCODIGO_MUNICIPIOcbx, CODIGO_MUNICIPIOcbx, .CODIGO_DEPARTAMENTO)
            Me.CODIGO_MUNICIPIOcbx.Value = .CODIGO_MUNICIPIO
            Me.MOVILtxt.Text = .MOVIL
            Me.EMAILtxt.Text = .EMAIL
        End With
        Me.Habilitar()
    End Sub

    Private Sub SeleccionarElemento(ByRef lista As DevExpress.Web.ASPxEditors.ASPxComboBox, ByVal valor As Object)
        Dim indice As Integer = lista.Items.IndexOfValue(valor)
        lista.SelectedIndex = indice
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <returns>2
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	02/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        mEntidad = New SOLICITUD_INSCRIPCION_AF

        Dim sResumeError As New StringBuilder
        Dim sError As New StringBuilder
        If Me.ID_PARTICIPANTEtxt.Text <> "" Then
            'Se ha seleccionado un participante, verificar que si ya tenía DUI/NIT estos no se hayan cambiado, ni tampoco los Nombres y Apellidos
            Dim lEntidadPart As PARTICIPANTE = (New cPARTICIPANTE).ObtenerPARTICIPANTE(CDec(Me.ID_PARTICIPANTEtxt.Text))
            If lEntidadPart IsNot Nothing Then
                If lEntidadPart.DUI <> String.Empty AndAlso lEntidadPart.DUI <> Me.DUItxt.Text Then
                    sError.Append("* No se puede cambiar el DUI de un participante que ya existe.") : sError.Append("<br>")
                End If
                If lEntidadPart.NIT <> String.Empty AndAlso lEntidadPart.NIT <> Me.NITtxt.Text Then
                    sError.Append("* No se puede cambiar el NIT de un participante que ya existe.") : sError.Append("<br>")
                End If
            End If
        End If
        If Me.NOMBREStxt.Text.Trim = "" Or Me.APELLIDOStxt.Text.Trim = "" Then
            sError.Append("* Nombres y Apellidos son requeridos.") : sError.Append("<br>")
        End If
        If Me.DUItxt.Text.Length > 0 And Me.DUItxt.Text.Length < 9 Then
            sError.Append("* DUI no válido.") : sError.Append("<br>")
        End If
        If Me.NITtxt.Text.Length > 0 And Me.NITtxt.Text.Length < 14 Then
            sError.Append("* NIT no válido.") : sError.Append("<br>")
        End If
        If Not IsDate(Me.FECHA_NACIMIENTODateEdit.Date) Then
            sError.Append("* Fecha de nacimiento no válida.") : sError.Append("<br>")
        End If
        If Me.GENERORadioButtonList.Value Is Nothing Then
            sError.Append("* Sexo es requerido.") : sError.Append("<br>")
        End If
        If IsNumeric(Me.EDADtxt.Text.Trim) AndAlso (Decimal.Parse(Me.EDADtxt.Text) < 10 Or Decimal.Parse(Me.EDADtxt.Text) > 100) Then
            sError.Append("* Fecha de nacimiento no válida.") : sError.Append("<br>")
        End If
        If CODIGO_DEPARTAMENTOcbx.Value Is Nothing Then
            sError.Append("* Departamento de domicilio es requerido.") : sError.Append("<br>")
        End If
        If CODIGO_MUNICIPIOcbx.Value Is Nothing Then
            sError.Append("* Municipio de domicilio es requerido.") : sError.Append("<br>")
        End If
        If sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 1. DATOS DE IDENTIFICACION</b><br>", 1)
            sError.Append("<div>")
            sError.Insert(0, "<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;"">LOS SIGUIENTES CAMPOS SON REQUERIDOS:</div><br>")
        End If


        sResumeError.Append(sError)
        sError = New StringBuilder
        If sResumeError.Length > 0 Then Return sResumeError.ToString



        '   Seteando la Entidad
        If ID_SOLICITUDtxt.Text <> "" Then
            mEntidad.ID_SOLICITUD = Decimal.Parse(ID_SOLICITUDtxt.Text)
            mEntidad.ID_TIPO_SOLICITUD = Decimal.Parse(Me.ID_TIPO_SOLICITUDtxt.Text)
            mEntidad.ID_ESTADO_SOLICITUD = Decimal.Parse(Me.ID_ESTADO_SOLICITUDtxt.Text)
        Else
            mEntidad.ID_SOLICITUD = 0
            Dim lEntidadAFDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(Decimal.Parse(Me.ID_ACCION_FORMATIVAtxt.Text))
            mEntidad.ID_TIPO_SOLICITUD = Utilerias.ObtenerTipoSolicitudPorProgramaFormacion(CInt(lEntidadAFDetalle.ID_PROGRAMA_FORMACION))
            mEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.EnEsperaDeAprobacion
        End If
        With mEntidad
            .FECHA_PRESENTACION = FECHA_PRESENTACIONDateEdit.Date
            .ID_ACCION_FORMATIVA = Decimal.Parse(Me.ID_ACCION_FORMATIVAtxt.Text)

            If Me.ID_PARTICIPANTEtxt.Text <> "" Then .ID_PARTICIPANTE = CDec(Me.ID_PARTICIPANTEtxt.Text)

            '   ***     SECCIÓN 1. DATOS DE IDENTIFICACIÓN
            .NOMBRES = NOMBREStxt.Text.Trim.ToUpper
            .APELLIDOS = APELLIDOStxt.Text.Trim.ToUpper
            .DUI = DUItxt.Text
            .NIT = NITtxt.Text
            .ISSS = ISSStxt.Text.Trim.ToUpper
            .NUM_DOCTO = ""
            .TIPO_DOCTO = -1
            .ID_PAIS = 57
            .FECHA_NACIMIENTO = FECHA_NACIMIENTODateEdit.Date
            If GENERORadioButtonList.Value = 1 Then
                .GENERO = "M"
            Else
                .GENERO = "F"
            End If
            .EDAD = Decimal.Parse(EDADtxt.Text)
            .MIEMBROS_GRUPO_FAMILIAR = 0
            .ID_ESTADO_CIVIL = -1
            .ES_JEFE_HOGAR = -1
            .TIENE_HIJOS = -1
            .NO_DE_HIJOS = -1
            .SE_DEDICA_ALGUNA_PROFESION = -1
            .PROFESION_OFICIO = ""
            .DIRECCION = ""
            .CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTOcbx.Value
            .CODIGO_MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(CODIGO_DEPARTAMENTOcbx.Value, CODIGO_MUNICIPIOcbx.Value).CODIGO_MUNICIPIO
            .TELEFONO = ""
            .MOVIL = MOVILtxt.Text.Trim
            .EMAIL = EMAILtxt.Text.Trim.ToLower
            .CON_DISCAPACIDAD = 0
            .DISCA_POR_SOLICITUDSOLICITUD_INSCRIPCION_AF = Nothing
            .DISC_OTRA = ""

            '   ***     SECCIÓN 2. EDUCACIÓN FORMAL Y FORMACIÓN OCUPACIONAL
            .ID_LEE_ESCRIBE = 1
            .ID_NIVEL_ACADEMICO = -1
            .OTRA_EDUCACION_FORMAL = ""
            .TITULO_CERTIFICADO_OBTENIDO = ""
            .ESTUDIA_ACTUALMENTE = -1
            .ID_NIVEL_ACADEMICO = -1
            .ID_TIEMPO_DEJO_ESTUDIAR = -1
            .RECIBIO_CURSO_ANTERIOR = ""
            .BENEF_OBT_EMPLEO = 0
            .BENEF_TRAB_CTA_PROPIA = 0
            .BENEF_PROM_EMP_ACT = 0
            .BENEF_CAMB_EMP_X_CURSO = 0
            .BENEF_OBT_ING_EXTRA = 0
            .RAZON_NO_BENEFICIO = ""
            '   ***     SECCIÓN 3. INFORMACIÓN SOBRE SU SITUACIÓN LABORAL
            .OCUACT_ESTUDIA = 0
            .OCUACT_OFICIO_HOGAR = 0
            .OCUACT_TRABAJA = 0
            .OCUACT_BUSCA_TRABAJO = 0
            .OCUACT_OTRA = ""
            .TIPO_EMPLEO_OTRO = ""
            .ID_TIPO_EMPLEO = -1
            .SECTOR_EMPLEO = -1
            .TRABAJO_ANTERIOR = ""
            '   ***     SECCIÓN 4. INFORMACIÓN SOBRE LOS INGRESOS
            .RECIBE_INGRESOS = -1
            .MANERA_OBT_ING_AYUDA_FAM = 0
            .MANERA_OBT_ING_PENSION = 0
            .MANERA_OBT_ING_REMESA = 0
            .MANERA_OBT_ING_TRABAJO = 0
            .MANERA_OBT_ING_OTRO = ""
            '   ***     SECCIÓN 5. EXPECTATIVAS RESPECTO A LA FORMACIÓN - EXPECTATIVAS LABORALES
            .EXPFOR_PROMOCION_EMPLEO = 0
            .EXPFOR_CAMBIAR_EMPLEO = 0
            .EXPFOR_OBTENER_EMPLEO = 0
            .EXPFOR_TRABAJAR_CTA_PROPIA = 0
            .EXPFOR_INGRESOS_EXTRAS = 0
            .EXPFOR_NINGUNO = 0
            .EXPFOR_OTRO = ""
            .CURSO_REL_TRAB_ACTUAL = 0
            .CURSO_REL_TRAB_NUEVO = 0
            '   ***     SECCIÓN 6. SEGUIMIENTO
            .NOMBRE_REFERENCIA = ""
            .ID_REFERENCIA = -1
            .DIRECCION_REFERENCIA = ""
            .DEPARTAMENTO_REFERENCIA = ""
            .MUNICIPIO_REFERENCIA = ""
            .TELEFONO_REFERENCIA = ""
            .MOVIL_REFERENCIA = ""
            .EMAIL_REFERENCIA = ""
            .SUGERENCIAS = ""
            .USERID = ObtenerUsuario()
            .LASTUPDATE = Now

            Me._CODIGO_ERROR = mComponente.ActualizarSOLICITUD_INSCRIPCION_AF(mEntidad, TipoConcurrencia.Pesimistica, "")
            If Me._CODIGO_ERROR <> 1 Then
                ExceptionManager.Publish(New Exception(mComponente.sError + vbCrLf + mComponente.sErrorTecnico))
                Return "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><center><b>Error al Guardar Solicitud.</b></center><br>" + _
                        mComponente.sError + "</div>"
            End If

        End With

        Return ""
    End Function

   

#Region "Propiedades adicionales CallbackPanel"
    Dim _Tipo As String
    Public Property Tipo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property

    Dim _Criterio As String
    Public Property Criterio() As String
        Get
            Return _Criterio
        End Get
        Set(ByVal value As String)
            _Criterio = value
        End Set
    End Property

    Protected Sub cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF.Callback
        Dim parametros() As String = e.Parameter.Split(";")
        Dim sResult As String = ""

        Select Case parametros(0)
            Case 0  'Inicializar campos del Formulario
                Me.Nuevo()
        End Select
    End Sub

#End Region
  
End Class
