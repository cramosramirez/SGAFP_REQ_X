<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaMODALIDAD_DE_FORMACION.ascx.vb" Inherits="controles_ucListaMODALIDAD_DE_FORMACION" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_MODALIDAD_FORMACION" Width="100%" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" >
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
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center" Width="50px">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_MODALIDAD_FORMACION")%>'></asp:ImageButton>
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_MODALIDAD_FORMACION")%>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_MODALIDAD_FORMACION" Width="100px"   ReadOnly="True" VisibleIndex="2" Caption="Id Modalidad" />        
        <dx:GridViewDataTextColumn FieldName="MODALIDAD_FORMACION" VisibleIndex="3" Caption="Modalidad de formación" />        
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption="..." Width="50px" ButtonType="Image"  Name="Eliminar" VisibleIndex="4">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text=" " Image-Url="../imagenes/eliminar.png"  >
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarMODALIDAD_DE_FORMACION" DeleteMethod="EliminarMODALIDAD_DE_FORMACION" UpdateMethod="ActualizarMODALIDAD_DE_FORMACION"
    TypeName="SGAFP.BL.cMODALIDAD_DE_FORMACION">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_MODALIDAD_FORMACION" Type="Decimal" />
        <asp:Parameter Name="MODALIDAD_FORMACION" Type="String" />       
        <asp:Parameter Name="NOTAS" Type="String" />       
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MODALIDAD_FORMACION" Type="Decimal" />
        <asp:Parameter Name="MODALIDAD_FORMACION" Type="String" />       
        <asp:Parameter Name="NOTAS" Type="String" />  
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_MODALIDAD_FORMACION" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
