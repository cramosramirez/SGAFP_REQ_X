<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleTERMINO_PARAMETROS_PAGO.ascx.vb" Inherits="controles_ucVistaDetalleTERMINO_PARAMETROS_PAGO" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaTERMINO_PAGO_PENALIZACION" Src="~/controles/ucListaTERMINO_PAGO_PENALIZACION.ascx" %>
<%@ Register tagprefix="uc1" tagname="ucListaTERMINO_PAGO_ASISTE" Src="~/controles/ucListaTERMINO_PAGO_ASISTE.ascx" %>


<style type="text/css">
    .auto-style1 {
        height: 23px;
    }
</style>


<table border="0">
    <tr>
        <td width="300px"><dx:ASPxLabel ID="Label1" runat="server" Text="Identificador:"></dx:ASPxLabel></td>
        <th colspan="3">     
            <dx:ASPxTextBox ID="txtID_TERMINO_PARAM" runat="server" Width="150px">
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>   
            </dx:ASPxTextBox>
        </th>        
    </tr>    
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="Descripción:"></dx:ASPxLabel></td>
        <th colspan="3">            
            <dx:ASPxMemo ID="txtDESCRIPCION" Font-Bold="true" runat="server" MaxLength="1000" Width="100%">
            </dx:ASPxMemo>
        </th>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Font-Bold="true" Text="Criterios de resolución"></dx:ASPxLabel></td> 
        <th colspan="3"><hr /></th>        
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="No. Término de referencia (digitar solo números):"></dx:ASPxLabel></td>
        <th colspan="3">
            <dx:ASPxTextBox ID="txtTDR" AutoPostBack="true" Font-Bold="true" runat="server" MaxLength="100" Width="100%">
            </dx:ASPxTextBox>
        </th>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Unidad organizativa:"></dx:ASPxLabel></td>
        <th colspan="3">
            <dx:ASPxComboBox ID="cbxUNIDAD_ORGANIZATIVA" AutoPostBack="true" runat="server" DataSourceID="odsUNIDAD_ORGANIZATIVA" ValueField="ID_UNIDAD_ORGANIZATIVA" ValueType="System.Int32" IncrementalFilteringMode="Contains" TextField="NOMBRE_UNIDAD"  Width="100%" >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" /> 
            </dx:ASPxComboBox>  
        </th>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Centro de responsabilidad:"></dx:ASPxLabel></td>
        <th colspan="3">
            <dx:ASPxComboBox ID="cbxCENTRO_RESPONSABILIDAD" runat="server" ValueField="ID_CENTRO_RESPONSABILIDAD" ValueType="System.Int32" IncrementalFilteringMode="Contains" TextField="NOMBRE_CENTRO_RESPONSABILIDAD"  Width="100%" >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" /> 
            </dx:ASPxComboBox>  
        </th>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Referente:"></dx:ASPxLabel></td>
        <th colspan="3">
            <dx:ASPxComboBox ID="cbxREFERENTE" runat="server" DataSourceID="odsREFERENTE" ValueField="ID_REFERENTE" IncrementalFilteringMode="Contains" ValueType="System.Int32" TextField="NOMBRE_REFERENTE"  Width="100%" >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" /> 
            </dx:ASPxComboBox>  
        </th>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Activo:"></dx:ASPxLabel></td>
        <th colspan="3" style="text-align:left" >
            <dx:ASPxCheckBox ID="chkACTIVO" runat="server">
            </dx:ASPxCheckBox> 
        </th>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" Font-Bold="true" Text="Condiciones para pago"></dx:ASPxLabel></td> 
        <th colspan="3"><hr /></th>        
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="Forma de pago:"></dx:ASPxLabel></td>
        <th colspan="3" >
            <dx:ASPxComboBox ID="cbxFORMA_PAGO" runat="server" AutoPostBack="true" ValueField="ID_FORMA_PAGO" ValueType="System.Int32" TextField="NOMBRE_PAGO"  Width="100%" >
            </dx:ASPxComboBox>
        </th>
    </tr>  
    <tr id ="trBASE_PARTI" runat="server" visible="false"  >
        <td><dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Número de participante (base pago):"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxSpinEdit ID="speBASE_PARTI" runat="server" NumberType="Integer" Width="150px">
            </dx:ASPxSpinEdit>
        </td>
    </tr> 
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel20" runat="server" Font-Bold="true" Text="Condición para considerarse participante activo"></dx:ASPxLabel></td> 
        <th colspan="3"><hr /></th>        
    </tr>  
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Porcentaje mínimo de asistencia:"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxSpinEdit ID="spePORC_ASISTENCIA_MIN" runat="server" Width="150px">
            </dx:ASPxSpinEdit>
        </td>
    </tr>     
    <tr>
        <th colspan="4" >
             <dx:ASPxPageControl ID="TabSolicitud" runat="server" ClientInstanceName="TabSolicitud" 
                EnableHierarchyRecreation="True" Width="100%" 
                Font-Names="Verdana,Arial,Tahoma"  Font-Size="XX-Small" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css" CssPostfix="SoftOrange" SpriteCssFilePath="~/App_Themes/SoftOrange/{0}/sprite.css" TabSpacing="2px" ActiveTabIndex="0" >                 
                 <LoadingPanelImage Url="~/App_Themes/SoftOrange/Web/Loading.gif">
                </LoadingPanelImage>
                 <Paddings Padding="4px" />
                <ContentStyle>
                    <Border BorderColor="LightGray" BorderStyle="Solid" BorderWidth="3px" />            
                </ContentStyle>
                <TabPages>   
                     <dx:TabPage Text="1. PENALIZACIONES AUTOMATICAS" ToolTip="Penalizaciones automáticas de la oferta">
                        <ContentCollection>    
                            <dx:ContentControl ID="ContentControl1" runat="server">
                                <table>
                                    <tr>
                                        <td><dx:ASPxButton ID="btnCargarPlantilla" runat="server" AutoPostBack="true" Text="Cargar plantilla" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" Width="150px" ></dx:ASPxButton> </td>
                                        <td><dx:ASPxButton ID="btnAgregar" runat="server" AutoPostBack="true" Text="Agregar rango" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" Width="170px" ></dx:ASPxButton> </td>
                                        <td><dx:ASPxButton ID="btnBorrarRangos" runat="server" AutoPostBack="true" Text="Limpiar detalle" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" Width="170px" ></dx:ASPxButton> </td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <th colspan="4" >            
                                            <uc1:ucListaTERMINO_PAGO_PENALIZACION id="ucListaTERMINO_PAGO_PENALIZACION1" PermitirEditarInline="true" PermitirEliminar="true" runat="server"></uc1:ucListaTERMINO_PAGO_PENALIZACION>
                                        </th>
                                    </tr>                                   
                                </table>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>        
                    <dx:TabPage Text="2. PAGO POR PORCENTAJES DE ASISTENCIA DIFERENCIADO" ToolTip="Pago por porcentajes de asistencia">
                        <ContentCollection>    
                            <dx:ContentControl ID="ContentControl2" runat="server">
                                <table>
                                    <tr>                                        
                                        <td><dx:ASPxButton ID="btnAgregarRgoPagoAsiste" runat="server" AutoPostBack="true" Text="Agregar rango" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" Width="170px" ></dx:ASPxButton> </td>
                                        <td><dx:ASPxButton ID="btnLimpiarRgoPagoAsiste" runat="server" AutoPostBack="true" Text="Limpiar detalle" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" Width="170px" style="height: 23px" ></dx:ASPxButton> </td>
                                        <td></td>                                        
                                    </tr>
                                    <tr>
                                        <th colspan="3" >            
                                            <uc1:ucListaTERMINO_PAGO_ASISTE id="ucListaTERMINO_PAGO_ASISTE1" PermitirEditarInline="true" PermitirEliminar="true" runat="server"></uc1:ucListaTERMINO_PAGO_ASISTE>
                                        </th>
                                    </tr>                                   
                                </table>
                            </dx:ContentControl>
                         </ContentCollection>
                     </dx:TabPage> 
                    <dx:TabPage Text="3. MODALIDADES DE EJECUCIÓN" ToolTip="Modalidades de ejecución permitidas">
                        <ContentCollection>    
                            <dx:ContentControl ID="ContentControl3" runat="server">
                                <table width="100%">
                                    <tr> 
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="Seleccione las modalidades que se ejecutarán en esta contratación:">
                                            </dx:aspxlabel>
                                        </td>                                        
                                    </tr>    
                                    <tr> 
                                        <td>
                                            <dx:ASPxListBox ID="lstMODALIDADES" TextField="MODALIDAD_FORMACION" ValueField="ID_MODALIDAD_FORMACION" ValueType="System.Int32" runat="server" Width="100%" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" SelectionMode="CheckColumn" >
                                                <LoadingPanelImage Url="~/App_Themes/Office2010Silver/Editors/Loading.gif">
                                                </LoadingPanelImage>
                                                <LoadingPanelStyle ImageSpacing="5px">
                                                </LoadingPanelStyle> 
                                                <DisabledStyle ForeColor="Black" />                                                
                                            </dx:ASPxListBox>
                                        </td>                                        
                                    </tr>                                                                   
                                </table>
                            </dx:ContentControl>
                         </ContentCollection>
                     </dx:TabPage>            
                </TabPages>
                 <DisabledStyle ForeColor="#CCCCCC">
                 </DisabledStyle>
            </dx:ASPxPageControl>
        </th>
    </tr>
</table>
<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />
<dx:ASPxLabel ID="lblREFERENCIA_PAGO_ASISTE" runat="server" Visible="false" />

<asp:ObjectDataSource ID="odsUNIDAD_ORGANIZATIVA" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaPorActivas" TypeName="SGAFP.BL.cUNIDAD_ORGANIZATIVA">
    <SelectParameters>                             
        <asp:Parameter DefaultValue="true" Name="AgregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="[Aplica a todos]" Name="nombreVacio" Type="String" />
        <asp:Parameter DefaultValue="NOMBRE_UNIDAD" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsCENTRO_RESPONSABILIDAD" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaPorActivas" TypeName="SGAFP.BL.cCENTRO_RESPONSABILIDAD">
    <SelectParameters>                             
        <asp:Parameter DefaultValue="true" Name="AgregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="[Aplica a todos]" Name="nombreVacio" Type="String" />
        <asp:Parameter DefaultValue="NOMBRE_CENTRO_RESPONSABILIDAD" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsREFERENTE" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cREFERENTE">
    <SelectParameters>                             
        <asp:Parameter DefaultValue="true" Name="AgregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="[Aplica a todos]" Name="nombreVacio" Type="String" />
        <asp:Parameter DefaultValue="NOMBRE_REFERENTE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsTIPO_PENALIZA_AUTO" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaPenalizacionAutomatica" TypeName="SGAFP.BL.cTIPO_PENALIZA">
    <SelectParameters>                             
        <asp:Parameter DefaultValue="ID_TIPO_PENA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<dx:ASPxPopupControl ID="popAgregarPenalizacion" Modal="True"  runat="server" 
                        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" HeaderText="Agregar rango de penalización" ContentStyle-Paddings-Padding="7px"   
                        AllowDragging="True" ClientInstanceName="popAgregarPenalizacion" 
                        CloseAction="CloseButton" CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" CssPostfix="Office2010Blue" SpriteCssFilePath="~/App_Themes/Office2010Blue/{0}/sprite.css" Width="450px" EnableHotTrack="False">  

<ContentStyle>
<Paddings Padding="7px"></Paddings>
</ContentStyle>

                <LoadingPanelStyle ImageSpacing="5px">
                </LoadingPanelStyle>
                <ContentCollection>
                    <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" >          
                        <table>
                            <tr>
                                <td><dx:ASPxLabel ID="Label30" runat="server" Text="Tipo de penalización:" /></td>
                                <td>
                                    <dx:ASPxComboBox ID="cbxTIPO_PENALIZA" runat="server" DataSourceID="odsTIPO_PENALIZA_AUTO" ValueField="ID_TIPO_PENA" ValueType="System.Int32" TextField="NOMBRE"  Width="300px" >
                                    </dx:ASPxComboBox>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="Rango inicial (días):" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speRANGO_INICIAL" runat="server" SpinButtons-ShowIncrementButtons="false" NumberType="Integer" Width="150px">                                        
<SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                    </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1"><dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="Rango final (días):" /></td>
                                <td class="auto-style1">
                                    <dx:ASPxSpinEdit ID="speRANGO_FINAL" runat="server" NumberType="Integer" Width="150px">
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                    </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="% Penalización:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="spePORCENTAJE_PENALIZACION" runat="server" NumberType="Float" DecimalPlaces="2" DisplayFormatString="#,##0.00"  Width="150px">
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                    </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <th colspan="2">
                                    <dx:ASPxLabel ID="lblMensajeError" runat="server" Text="" Font-Bold="true" ForeColor="Red" />
                                </th>
                            </tr>
                            <tr>
                                <td>
                                     <dx:ASPxButton ID="btnAceptarPopup" runat="server" AutoPostBack="true" Text="Aceptar" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" ></dx:ASPxButton>
                                </td>
                                <td>
                                     <dx:ASPxButton ID="btnCancelarPopup" runat="server" Text="Cancelar" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" >
                                         <ClientSideEvents Click="function(s, e) {popAgregarPenalizacion.Hide();}" />
                                     </dx:ASPxButton>
                                </td>
                            </tr>                            
                        </table> 
                    </dx:PopupControlContentControl>
                </ContentCollection>
                <LoadingPanelImage Url="~/App_Themes/Office2010Blue/Web/Loading.gif">
                </LoadingPanelImage>            
</dx:ASPxPopupControl>

<dx:ASPxPopupControl ID="popAgregarAsistenciaPago" Modal="True"  runat="server" 
                        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" HeaderText="Agregar rango de asistencia-pago" ContentStyle-Paddings-Padding="7px"   
                        AllowDragging="True" ClientInstanceName="popAgregarAsistenciaPago" 
                        CloseAction="CloseButton" CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" CssPostfix="Office2010Blue" SpriteCssFilePath="~/App_Themes/Office2010Blue/{0}/sprite.css" Width="450px" EnableHotTrack="False">  

<ContentStyle>
<Paddings Padding="7px"></Paddings>
</ContentStyle>

                <LoadingPanelStyle ImageSpacing="5px">
                </LoadingPanelStyle>
                <ContentCollection>
                    <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server" >          
                        <table>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="Tipo de modalidad:" /></td>
                                <td>
                                    <dx:ASPxComboBox ID="cbxMODALIDAD_FORMACION" runat="server" DataSourceID="odsMODALIDAD_FORMACION" ValueField="ID_MODALIDAD_FORMACION" ValueType="System.Int32" TextField="MODALIDAD_FORMACION"  Width="300px" >
                                    </dx:ASPxComboBox>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="Asistencia inicial (%):" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="spePORC_ASISTE_INI" runat="server" SpinButtons-ShowIncrementButtons="false" NumberType="Float" Width="150px">                                        
<SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                    </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="Asistencia final (%):" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="spePORC_ASISTE_FIN" runat="server" NumberType="Float" Width="150px">
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                    </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="% a pagar:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="spePORC_PAGO_COSTO_PARTI" runat="server" NumberType="Float" DecimalPlaces="2" DisplayFormatString="#,##0.00"  Width="150px">
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                    </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <th colspan="2">
                                    <dx:ASPxLabel ID="lblMensajeErrorPagoAsiste" runat="server" Text="" Font-Bold="true" ForeColor="Red" />
                                </th>
                            </tr>
                            <tr>
                                <td>
                                     <dx:ASPxButton ID="btnAgregarPagoAsiste" runat="server" AutoPostBack="true" Text="Aceptar" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" ></dx:ASPxButton>
                                </td>
                                <td>
                                     <dx:ASPxButton ID="btnCancelarPagoAsiste" runat="server" Text="Cancelar" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" >
                                         <ClientSideEvents Click="function(s, e) {popAgregarAsistenciaPago.Hide();}" />
                                     </dx:ASPxButton>
                                </td>
                            </tr>                            
                        </table> 
                    </dx:PopupControlContentControl>
                </ContentCollection>
                <LoadingPanelImage Url="~/App_Themes/Office2010Blue/Web/Loading.gif">
                </LoadingPanelImage>            
</dx:ASPxPopupControl>
<asp:ObjectDataSource ID="odsMODALIDAD_FORMACION" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cMODALIDAD_DE_FORMACION">
    <SelectParameters>                             
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean"  />
        <asp:Parameter DefaultValue="ID_MODALIDAD_FORMACION" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsFORMA_PAGO" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cFORMA_PAGO">
    <SelectParameters>                             
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean"  />
        <asp:Parameter DefaultValue="ID_FORMA_PAGO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>