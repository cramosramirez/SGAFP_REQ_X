<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSOLICITUD_INSCRIPCION_FC.ascx.vb" Inherits="controles_ucVistaDetalleSOLICITUD_INSCRIPCION_FC" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" Tagprefix="dx" %>
<%@ Register TagName="ucListaPARTICIPANTE" Src="~/controles/ucListaPARTICIPANTE.ascx" TagPrefix="uc1" %>

<style type="text/css">
       .req{color:Red; font-size:x-small; font-family:Arial; font-weight:bold}   
       .textUpper input{text-transform:uppercase;}     
    </style>

<dx:ASPxCallbackPanel runat="server" ID="cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF"    
         ClientInstanceName="cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF" ShowLoadingPanel="false"  >   
<ClientSideEvents EndCallback="function(s, e){
                                    if(s.cpResultCallback != undefined){
                                        switch(s.cpResultCallback){
                                            case '':
                                                break;
                                            //case 'MostrarCursosRecibidosPorParticipante':
                                                //CargarCursosRecParticipanteEjercicio(s.cpIdParticipante, s.cpIdEjercicio);
                                                //break;
                                            default:
                                                AsignarMensaje(s.cpResultCallback);
                                                SetContenido(380, 0);
                                        }
                                    }
                               }"  />     
        <PanelCollection>        
            <dx:PanelContent runat="server">      
                 
<div id="contenedor_principal" style="width:800px; font-family:Verdana,Arial; font-size:xx-small;">
    <table width="100%" >        
        <tr align="center">
           <td>
               <dx:ASPxLabel ID="ASPxLabel1" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Bold="True" Font-Size="X-Small" Text="FORMULARIO DE INSCRIPCIÓN/MATRÍCULA" />
           </td> 
        </tr>
        <tr align="left">
            <td style="color:red">(*) Las respuestas a las preguntas color rojo son obligatorios.</td>
        </tr>
    </table>    
    <table width="100%">        
        <tr>
            <td style="width:80px; font-family:Verdana,Arial; font-size:xx-small;  ">
                <dx:ASPxLabel ID="lblSolicitud" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="ID. SOLICITUD:" />
            </td>
             <td style="width:100px">
                <dx:ASPxTextBox ID="ID_SOLICITUDtxt" ClientInstanceName="ID_SOLICITUDtxt" 
                    Font-Names="Arial,Tahoma" Font-Size="Small" ForeColor="Blue" Font-Bold="true" ReadOnly="true" runat="server" Width="100px" />
            </td>
            <td align="right">
                <dx:ASPxLabel ID="lblInscripcion" runat="server" ForeColor="Red" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="FECHA DE INSCRIPCIÓN: *" />
            </td>
            <td>
                <dx:ASPxDateEdit ID="FECHA_PRESENTACIONDateEdit" Width="120px"  runat="server" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true"  
                    ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Fecha de presentación es requerida.">
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Fecha de presentaci&#243;n es requerida."></RequiredField>
</ValidationSettings>
                </dx:ASPxDateEdit>
            </td>
            <td align="right">
                <dx:ASPxLabel ID="lblParticipante" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="ID. PARTICIPANTE:" />
            </td>
            <td>
                <dx:ASPxTextBox ID="ID_PARTICIPANTEtxt" ClientInstanceName="ID_PARTICIPANTEtxt" 
                    Font-Names="Arial,Tahoma" Font-Size="Small"  ForeColor="Blue" Font-Bold="true" ReadOnly="true" runat="server" Width="100px" />
            </td>            
        </tr>
        <tr id="trEMRESA" runat="server">
            <td>EMPRESA:</td>
            <th colspan="4">
                <dx:ASPxTextBox ID="EMPRESAtxt" CssClass="textUpper" runat="server" Width="100%" >
                       <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" Font-Bold="true" />    
                </dx:ASPxTextBox>
            </th>
            <td>
                <dx:ASPxButton ID="btnBuscarEmpresa" AutoPostBack="false" 
                    CausesValidation="False" runat="server" EnableDefaultAppearance="false" Cursor="hand"
                    ImagePosition="Left" Width="20px" Height="20px" ToolTip="Buscar Participante por DUI" >
                    <Image Url="../imagenes/buscar.gif" />
                    <ClientSideEvents Click="function(s,e){                                                  
                                                    BuscarParticipantes('DUI', DUItxt.GetValue());    
                                        }" 
                    />
                </dx:ASPxButton>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxTextBox ID="ID_ACCION_FORMATIVAtxt" ClientInstanceName="ID_ACCION_FORMATIVAtxt" 
                    Font-Names="Arial,Tahoma" Font-Size="Small"  Font-Bold="true" ReadOnly="true" runat="server" Width="100px" />
            </td>
            <td>
                <dx:ASPxTextBox ID="ID_TIPO_SOLICITUDtxt" ClientInstanceName="ID_TIPO_SOLICITUDtxt"
                    Font-Names="Arial,Tahoma" Font-Size="Small" Font-Bold="true" ReadOnly="true" runat="server" Width="100px" />
            </td>
            <th colspan="4">
                <dx:ASPxTextBox ID="ID_ESTADO_SOLICITUDtxt" ClientInstanceName="ID_ESTADO_SOLICITUDtxt" 
                    Font-Names="Arial,Tahoma" Font-Size="Small"  Font-Bold="true" ReadOnly="true" runat="server" Width="100px" />
            </th>
        </tr>
    </table>    
   <dx:ASPxPageControl ID="TabSolicitud" runat="server" ActiveTabIndex="0" ClientInstanceName="TabSolicitud" 
        EnableHierarchyRecreation="True" Width="100%" EnableCallBacks="false" EnableViewState="true" 
        Font-Names="Verdana, Arial, Tahoma"  Font-Size="XX-Small" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" TabSpacing="0px" >                 
         <LoadingPanelImage Url="~/App_Themes/Office2010Silver/Web/Loading.gif">
        </LoadingPanelImage>
         <LoadingPanelStyle ImageSpacing="5px">
         </LoadingPanelStyle>
         <Paddings Padding="2px" PaddingLeft="5px" PaddingRight="5px" />
        <ContentStyle>
            <Paddings Padding="12px" />
            <Border BorderColor="#868B91" BorderStyle="Solid" BorderWidth="1px" />            
        </ContentStyle>
        <TabPages>                
         <dx:TabPage Text="" >
            <ContentCollection>       
                <dx:ContentControl ID="ContentControl1" runat="server">
                    <table width="70%" style="font-family:Arial,Tahoma,Verdana; font-size:xx-small" >    
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:center; background-color:#E0E0E0">DATOS DE IDENTIFICACIÓN</th> 
                        </tr>
                         <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">1. Documentos de Identidad *</span></th> 
                        </tr>
                        <tr>
                            <th colspan="2" align="left">
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small">
                                    <tr>
                                        <td style="width:70px">DUI:</td>
                                        <td>
                                            <dx:ASPxTextBox ID="DUItxt" ClientInstanceName="DUItxt" runat="server" Width="120px" ValidationSettings-Display="Dynamic" >
                                                <MaskSettings Mask="99999999-9" IncludeLiterals="None" />             
                                                <ValidationSettings Display="Dynamic"></ValidationSettings>
                                                <ClientSideEvents ValueChanged="function(s,e){
                                                                                if(DUItxt.GetValue() != null && ID_PARTICIPANTEtxt.GetText() == '')
                                                                                    BuscarParticipantes('DUI', DUItxt.GetValue());     
                                                                              }"   />
                                            </dx:ASPxTextBox>                                          
                                        </td>
                                        <td align="left" style="width:50px">
                                            <dx:ASPxButton ID="BuscarDUIbtn" AutoPostBack="false" 
                                                CausesValidation="False" runat="server" EnableDefaultAppearance="false" Cursor="hand"
                                                ImagePosition="Left" Width="20px" Height="20px" ToolTip="Buscar Participante por DUI" >
                                                <Image Url="../imagenes/buscar.gif" />
                                                <ClientSideEvents Click="function(s,e){   
                                                                            if(DUItxt.GetValue()==null){
                                                                                AsignarMensaje('Escriba el Número de DUI del Participante');           
                                                                              }
                                                                              else{
                                                                                BuscarParticipantes('DUI', DUItxt.GetValue());                                                                                                                                                             
                                                                              }      
                                                                    }" 
                                                />
                                            </dx:ASPxButton>
                                        </td>
                                        <td>NIT:</td>
                                        <td>
                                            <dx:ASPxTextBox ID="NITtxt" ClientInstanceName="NITtxt" runat="server" Width="120px" ValidationSettings-Display="Dynamic" Height="19px">
                                                <MaskSettings Mask="9999-999999-999-9" IncludeLiterals="None" />                                            
                                                <ValidationSettings Display="Dynamic"></ValidationSettings>
                                                <ClientSideEvents ValueChanged="function(s,e){
                                                                                if(NITtxt.GetValue() != null && ID_PARTICIPANTEtxt.GetText() == '')
                                                                                    BuscarParticipantes('NIT', NITtxt.GetValue());     
                                                                              }" />
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td align="left" style="width:50px">
                                            <dx:ASPxButton ID="BuscarNITbtn" AutoPostBack="false" CausesValidation="False" Cursor="hand" 
                                                runat="server" EnableDefaultAppearance="false" ImagePosition="Left" Width="20px" 
                                                Height="20px" ToolTip="Buscar Participante por NIT" >
                                                <Image Url="../imagenes/buscar.gif" />
                                                <ClientSideEvents Click="function(s,e){     
                                                                            if(NITtxt.GetValue()==null){
                                                                                AsignarMensaje('Escriba el Número de NIT del Participante');           
                                                                              }
                                                                              else{
                                                                                BuscarParticipantes('NIT', NITtxt.GetValue());                                                                                      
                                                                              }      
                                                                    }" 
                                                />
                                            </dx:ASPxButton>
                                        </td>
                                        <td></td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>ISSS:</td>                                        
                                        <td><dx:ASPxTextBox ID="ISSStxt" CssClass="textUpper" ClientInstanceName="ISSStxt"  MaxLength="9" runat="server" Width="120px"  /></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                    </tr>
                                </table>
                            </th>                      
                        </tr>  
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">2. Nombre completo *</span></th> 
                        </tr> 
                        <tr>
                            <th colspan="2" align="left">
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small">
                                    <tr align="left" >
                                        <td style="width:70px">Nombres:</td>
                                        <td><dx:ASPxTextBox ID="NOMBREStxt" CssClass="textUpper" ClientInstanceName="NOMBREStxt" MaxLength="60" runat="server" Width="300px" 
                                               ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Nombres son requeridos." >
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Nombres son requeridos."></RequiredField>
</ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td style="width:70px; text-align:right">Apellidos:</td>
                                        <td><dx:ASPxTextBox ID="APELLIDOStxt" CssClass="textUpper" ClientInstanceName="APELLIDOStxt" MaxLength="60" runat="server" Width="300px" 
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Apellidos son requeridos." >
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Apellidos son requeridos."></RequiredField>
</ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </td>     
                                        <td>
                                            <dx:ASPxButton ID="BuscarNombresbtn" ClientInstanceName="BuscarNombresbtn" 
                                                    AutoPostBack="false" CausesValidation="False" runat="server" 
                                                    EnableDefaultAppearance="false" ImagePosition="Left" Cursor="hand"
                                                    Width="20px" Height="20px" ToolTip="Buscar Participante por Nombres y Apellidos" >
                                                <Image Url="../imagenes/buscar.gif" />
                                                <ClientSideEvents Click="function(s,e){                                                                               
                                                                              if(NOMBREStxt.GetValue()==null && APELLIDOStxt.GetValue()==null){
                                                                                AsignarMensaje('Escriba el Nombre y/o Apellido del Participante');           
                                                                              }
                                                                              else{                                                                                
                                                                                BuscarParticipantes('NOMBRES_APELLIDOS', NOMBREStxt.GetText() + ' ' + APELLIDOStxt.GetText());
                                                                              }   
                                                                            }" 
                                                />
                                            </dx:ASPxButton>                                             
                                        </td>                                                               
                                    </tr>                                   
                                </table>
                            </th> 
                        </tr>                                           
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">3. Fecha Nacimiento *</span></th> 
                        </tr>
                        <tr>
                            <th colspan="2" align="left">
                                <table width="50%"  style="font-family:Arial,Tahoma,Verdana; font-size:xx-small">
                                    <tr>
                                        <td>Fecha:</td>
                                        <td>
                                            <dx:ASPxDateEdit ID="FECHA_NACIMIENTODateEdit" ClientInstanceName="FECHA_NACIMIENTODateEdit" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true"  Width="120px" runat="server" >
                                            <ClientSideEvents DateChanged="function(s,e){                                                        
                                                        EDADtxt.SetText(CalcularEdad(s.GetValue()));
                                                    }"  />
                                            </dx:ASPxDateEdit>
                                        </td>
                                        <td>Edad:</td>  
                                        <td><dx:ASPxTextBox ID="EDADtxt" ClientInstanceName="EDADtxt" runat="server" Width="30px" ReadOnly="true"
                                        ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Edad es requerido."  >
                                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                            <RequiredField IsRequired="True" ErrorText="Edad es requerido."></RequiredField>
                                            </ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td style="padding-left:4px" >(años cumplidos)</td>                                      
                                    </tr>
                                </table>
                            </th>
                        </tr>
                        <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">4. Sexo *</span></td>    
                            <td>
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small" cellpadding="0" cellspacing="0"  >
                                    <tr>
                                        <td>
                                            <dx:ASPxRadioButtonList ID="GENERORadioButtonList" runat="server"  
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="GENERORadioButtonList"  
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px" 
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Sexo es requerido." >
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Masculino" Value="1" />
                                                <dx:ListEditItem Text="Femenino" Value="2"  />                                               
                                                </Items>

<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Sexo es requerido."></RequiredField>
</ValidationSettings>

                                                <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>                                                                                  
                                    </tr>
                                </table>
                            </td>
                        </tr> 
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">5. Domicilio *</span></th>  
                        </tr> 
                        <tr>                            
                            <th colspan="2" align="left">
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small">                            
                                    <tr>
                                        <td>Departamento:</td>
                                        <td><dx:ASPxComboBox ID="CODIGO_DEPARTAMENTOcbx" ClientInstanceName="CODIGO_DEPARTAMENTOcbx"  Width="180px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                                                    DataSourceID="odsDepartamento" TextField="NOMBRE" ValueField="CODIGO_DEPARTAMENTO" 
                                                    ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Departamento de residencia es requerido." >                                                    
                                                     <ClientSideEvents SelectedIndexChanged="function(s,e){
                                                                                            CODIGO_MUNICIPIOcbx.PerformCallback(CODIGO_DEPARTAMENTOcbx.GetValue().toString());                                                                                                                
                                                                                        }"  />

<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Departamento de residencia es requerido."></RequiredField>
</ValidationSettings>
                                            </dx:ASPxComboBox>
                                        </td>
                                        <td>Municipio:</td>
                                        <td><dx:ASPxComboBox ID="CODIGO_MUNICIPIOcbx" ClientInstanceName="CODIGO_MUNICIPIOcbx" Width="180px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                                             DataSourceID="odsCODIGO_MUNICIPIOcbx" TextField="NOMBRE" ValueField="CODIGO_MUNICIPIO" EnableSynchronization="False"
                                             ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Municipio de residencia es requerido." >                                                   
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Municipio de residencia es requerido."></RequiredField>
</ValidationSettings>
                                            </dx:ASPxComboBox>
                                        </td>                                        
                                    </tr>
                                    <tr>
                                        <td>Tel. Movil:</td>
                                        <td><dx:ASPxTextBox ID="MOVILtxt" CssClass="textUpper" ClientInstanceName="MOVILtxt" MaxLength="40" runat="server" Width="180px" /></td>
                                        <td>Email:</td>
                                        <th>
                                            <dx:ASPxTextBox ID="EMAILtxt" ClientInstanceName="EMAILtxt"  MaxLength="100" runat="server" Width="100%" Text="" >
                                                <ValidationSettings>
                                                <RegularExpression ErrorText="Email no válido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                                </ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </th>                                        
                                    </tr>
                                </table>
                            </th>
                        </tr>
                    </table>
                </dx:ContentControl>
            </ContentCollection>
         </dx:TabPage>
       
        </TabPages>
    </dx:ASPxPageControl>        
</div>


        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>



<asp:ObjectDataSource ID="odsDepartamento" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cDEPARTAMENTO">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsCODIGO_MUNICIPIOcbx" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cMUNICIPIO">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsReferencia" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cREFERENCIA">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE_REFERENCIA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

                      

     
  

  
