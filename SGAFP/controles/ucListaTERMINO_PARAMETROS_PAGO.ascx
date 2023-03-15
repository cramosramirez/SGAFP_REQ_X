<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaTERMINO_PARAMETROS_PAGO.ascx.vb" Inherits="controles_ucListaTERMINO_PARAMETROS_PAGO" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_TERMINO_PARAM" Width="100%" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" >
    <SettingsPager PageSize="15">
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />    
    <Columns>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center" Width="30px">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_TERMINO_PARAM") %>'></asp:ImageButton>
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_TERMINO_PARAM")%>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_TERMINO_PARAM" ReadOnly="True" VisibleIndex="2" Caption="Id termino param" Visible="false"    />
        <dx:GridViewDataTextColumn FieldName="DESCRIPCION" VisibleIndex="2" Caption="Descripcion" Width="200px" HeaderStyle-Wrap="True" CellStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center"  />
        <dx:GridViewDataTextColumn FieldName="TDR" VisibleIndex="2" Caption="Termino Referencia" Width="120px" HeaderStyle-Wrap="True" CellStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center"  />        
        <dx:GridViewDataTextColumn FieldName="UNIDAD_ORGANIZATIVA" VisibleIndex="2" Caption="Unidad Organizativa" UnboundType="String" HeaderStyle-Wrap="True" CellStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" />                
        <dx:GridViewDataTextColumn FieldName="ID_UNIDAD_ORGANIZATIVA" VisibleIndex="5" Caption="Id unidad organizativa" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="CENTRO_RESPONSABILIDAD" VisibleIndex="6" Caption="Centro Responsabilidad" UnboundType="String" HeaderStyle-Wrap="True" CellStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" />
        <dx:GridViewDataTextColumn FieldName="ID_CENTRO_RESPONSABILIDAD" VisibleIndex="6" Caption="Id centro responsabilidad" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="REFERENTE" VisibleIndex="6" Caption="Referente" UnboundType="String" HeaderStyle-Wrap="True" CellStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" />
        <dx:GridViewDataTextColumn FieldName="ID_REFERENTE" VisibleIndex="7" Caption="Id referente" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FORMA_PAGO" VisibleIndex="8" Caption="Forma de pago" UnboundType="String" HeaderStyle-Wrap="True" CellStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" />
        <dx:GridViewDataTextColumn FieldName="MODALIDAD" VisibleIndex="8" Caption="Modalidad" UnboundType="String" HeaderStyle-Wrap="True" CellStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" />
        <dx:GridViewDataTextColumn FieldName="ID_FORMA_PAGO" VisibleIndex="8" Caption="Id forma pago" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PORC_ASISTENCIA_MIN" VisibleIndex="9" Caption="% Mínimo de asistencia requerida" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="BASE_PARTI" VisibleIndex="10" Caption="Base parti" Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="ES_ACTIVO" VisibleIndex="11" Caption="Activo" UnboundType="Boolean" Width="70px" HeaderStyle-HorizontalAlign="Center"   />        
        <dx:GridViewDataTextColumn FieldName="NOMBRE_USUARIO_CREA" VisibleIndex="11" Caption="Usuario registró" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="12" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="13" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="14" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="15" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="16">
            <CustomButtons>
               <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text=" " Image-ToolTip="Eliminar" >
<Image ToolTip="Eliminar"></Image>
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
    <Images SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css">
        <LoadingPanelOnStatusBar Url="~/App_Themes/Office2010Silver/GridView/Loading.gif">
        </LoadingPanelOnStatusBar>
        <LoadingPanel Url="~/App_Themes/Office2010Silver/GridView/Loading.gif">
        </LoadingPanel>
    </Images>
    <ImagesFilterControl>
        <LoadingPanel Url="~/App_Themes/Office2010Silver/GridView/Loading.gif">
        </LoadingPanel>
    </ImagesFilterControl>
    <Styles CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver">
        <Header ImageSpacing="5px" SortingImageSpacing="5px">
        </Header>
        <LoadingPanel ImageSpacing="5px">
        </LoadingPanel>
    </Styles>
    <StylesEditors ButtonEditCellSpacing="0">
        <ProgressBar Height="21px">
        </ProgressBar>
    </StylesEditors>
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarTERMINO_PARAMETROS_PAGO" DeleteMethod="EliminarTERMINO_PARAMETROS_PAGO" UpdateMethod="ActualizarTERMINO_PARAMETROS_PAGO"
    TypeName="SGAFP.BL.cTERMINO_PARAMETROS_PAGO">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_TERMINO_PARAM" Type="Decimal" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="TDR" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_CENTRO_RESPONSABILIDAD" Type="Decimal" />
        <asp:Parameter Name="ID_REFERENTE" Type="Decimal" />
        <asp:Parameter Name="ID_FORMA_PAGO" Type="Decimal" />
        <asp:Parameter Name="PORC_ASISTENCIA_MIN" Type="Decimal" />
        <asp:Parameter Name="BASE_PARTI" Type="Decimal" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_TERMINO_PARAM" Type="Decimal" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="TDR" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_CENTRO_RESPONSABILIDAD" Type="Decimal" />
        <asp:Parameter Name="ID_REFERENTE" Type="Decimal" />
        <asp:Parameter Name="ID_FORMA_PAGO" Type="Decimal" />
        <asp:Parameter Name="PORC_ASISTENCIA_MIN" Type="Decimal" />
        <asp:Parameter Name="BASE_PARTI" Type="Decimal" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_TERMINO_PARAM" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorUNIDAD_ORGANIZATIVA" runat="server" 
    SelectMethod="ObtenerListaPorUNIDAD_ORGANIZATIVA" InsertMethod="AgregarTERMINO_PARAMETROS_PAGO" DeleteMethod="EliminarTERMINO_PARAMETROS_PAGO" UpdateMethod="ActualizarTERMINO_PARAMETROS_PAGO"
    TypeName="SGAFP.BL.cTERMINO_PARAMETROS_PAGO">
    <SelectParameters>
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_TERMINO_PARAM" Type="Decimal" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="TDR" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_CENTRO_RESPONSABILIDAD" Type="Decimal" />
        <asp:Parameter Name="ID_REFERENTE" Type="Decimal" />
        <asp:Parameter Name="ID_FORMA_PAGO" Type="Decimal" />
        <asp:Parameter Name="PORC_ASISTENCIA_MIN" Type="Decimal" />
        <asp:Parameter Name="BASE_PARTI" Type="Decimal" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_TERMINO_PARAM" Type="Decimal" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="TDR" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_CENTRO_RESPONSABILIDAD" Type="Decimal" />
        <asp:Parameter Name="ID_REFERENTE" Type="Decimal" />
        <asp:Parameter Name="ID_FORMA_PAGO" Type="Decimal" />
        <asp:Parameter Name="PORC_ASISTENCIA_MIN" Type="Decimal" />
        <asp:Parameter Name="BASE_PARTI" Type="Decimal" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_TERMINO_PARAM" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCENTRO_RESPONSABILIDAD" runat="server" 
    SelectMethod="ObtenerListaPorCENTRO_RESPONSABILIDAD" InsertMethod="AgregarTERMINO_PARAMETROS_PAGO" DeleteMethod="EliminarTERMINO_PARAMETROS_PAGO" UpdateMethod="ActualizarTERMINO_PARAMETROS_PAGO"
    TypeName="SGAFP.BL.cTERMINO_PARAMETROS_PAGO">
    <SelectParameters>
        <asp:Parameter Name="ID_CENTRO_RESPONSABILIDAD" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_TERMINO_PARAM" Type="Decimal" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="TDR" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_CENTRO_RESPONSABILIDAD" Type="Decimal" />
        <asp:Parameter Name="ID_REFERENTE" Type="Decimal" />
        <asp:Parameter Name="ID_FORMA_PAGO" Type="Decimal" />
        <asp:Parameter Name="PORC_ASISTENCIA_MIN" Type="Decimal" />
        <asp:Parameter Name="BASE_PARTI" Type="Decimal" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_TERMINO_PARAM" Type="Decimal" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="TDR" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_CENTRO_RESPONSABILIDAD" Type="Decimal" />
        <asp:Parameter Name="ID_REFERENTE" Type="Decimal" />
        <asp:Parameter Name="ID_FORMA_PAGO" Type="Decimal" />
        <asp:Parameter Name="PORC_ASISTENCIA_MIN" Type="Decimal" />
        <asp:Parameter Name="BASE_PARTI" Type="Decimal" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_TERMINO_PARAM" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorREFERENTE" runat="server" 
    SelectMethod="ObtenerListaPorREFERENTE" InsertMethod="AgregarTERMINO_PARAMETROS_PAGO" DeleteMethod="EliminarTERMINO_PARAMETROS_PAGO" UpdateMethod="ActualizarTERMINO_PARAMETROS_PAGO"
    TypeName="SGAFP.BL.cTERMINO_PARAMETROS_PAGO">
    <SelectParameters>
        <asp:Parameter Name="ID_REFERENTE" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_TERMINO_PARAM" Type="Decimal" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="TDR" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_CENTRO_RESPONSABILIDAD" Type="Decimal" />
        <asp:Parameter Name="ID_REFERENTE" Type="Decimal" />
        <asp:Parameter Name="ID_FORMA_PAGO" Type="Decimal" />
        <asp:Parameter Name="PORC_ASISTENCIA_MIN" Type="Decimal" />
        <asp:Parameter Name="BASE_PARTI" Type="Decimal" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_TERMINO_PARAM" Type="Decimal" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="TDR" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_CENTRO_RESPONSABILIDAD" Type="Decimal" />
        <asp:Parameter Name="ID_REFERENTE" Type="Decimal" />
        <asp:Parameter Name="ID_FORMA_PAGO" Type="Decimal" />
        <asp:Parameter Name="PORC_ASISTENCIA_MIN" Type="Decimal" />
        <asp:Parameter Name="BASE_PARTI" Type="Decimal" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_TERMINO_PARAM" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorFORMA_PAGO" runat="server" 
    SelectMethod="ObtenerListaPorFORMA_PAGO" InsertMethod="AgregarTERMINO_PARAMETROS_PAGO" DeleteMethod="EliminarTERMINO_PARAMETROS_PAGO" UpdateMethod="ActualizarTERMINO_PARAMETROS_PAGO"
    TypeName="SGAFP.BL.cTERMINO_PARAMETROS_PAGO">
    <SelectParameters>
        <asp:Parameter Name="ID_FORMA_PAGO" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_TERMINO_PARAM" Type="Decimal" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="TDR" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_CENTRO_RESPONSABILIDAD" Type="Decimal" />
        <asp:Parameter Name="ID_REFERENTE" Type="Decimal" />
        <asp:Parameter Name="ID_FORMA_PAGO" Type="Decimal" />
        <asp:Parameter Name="PORC_ASISTENCIA_MIN" Type="Decimal" />
        <asp:Parameter Name="BASE_PARTI" Type="Decimal" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_TERMINO_PARAM" Type="Decimal" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="TDR" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_CENTRO_RESPONSABILIDAD" Type="Decimal" />
        <asp:Parameter Name="ID_REFERENTE" Type="Decimal" />
        <asp:Parameter Name="ID_FORMA_PAGO" Type="Decimal" />
        <asp:Parameter Name="PORC_ASISTENCIA_MIN" Type="Decimal" />
        <asp:Parameter Name="BASE_PARTI" Type="Decimal" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_TERMINO_PARAM" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
