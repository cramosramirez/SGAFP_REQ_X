<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleACCION_FORMATIVA.ascx.vb" Inherits="controles_ucVistaDetalleACCION_FORMATIVA" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucProgramacionAccionFormativa" Src="~/controles/ucProgramacionAccionFormativa.ascx" %>


<style type="text/css">   
    .insatbl
    {
        border-left: 1px solid Silver;
        border-right: 1px solid silver;
        border-top: 1px solid silver;
        border-bottom: 1px solid silver;
        padding: 1px 4px;
        text-align: left;
            font-family: Verdana, Geneva, Arial, Helvetica, sans-serif;
            font-weight: normal;
            font-size: 11px;
            background-color: #FFFFFF;   
            border-collapse: collapse;
            border-spacing: 1px;
    }
    .req{color:Red; font-size:x-small; font-family:Arial, Verdad; font-weight:bold}   
    .insatr
    {  
        text-align: left; 
    }
    .Normal .DDLClass
    {
        font-family: Arial, Verdana, Geneva, Helvetica, sans-serif;
        font-size:xx-small;
    }   
    .CelEtiquetas
    {
         width: 100px; 
    }
    
    .style1
    {
        height: 24px;
    }   
   
   .TextoNormalDerecha
   {
       font-family: Verdana, Geneva, Arial, Helvetica, sans-serif;
       font-size: 11px;
       text-align: right; 
   }
    .DDLClass, .Normal, .TextoNormalIzquierda
    {
        font-family: Verdana, Geneva, Arial, Helvetica, sans-serif;
        font-size: 11px;
        text-align:left; 
    }   
     .TextoNormalCentrado
    {
        font-family: Verdana, Geneva, Arial, Helvetica, sans-serif;
        font-size: 11px;
        text-align:center; 
    }      
    .NormalUPPER
    {}
    </style>
<table id="VistaDetalle" cellspacing="1px" cellpadding="0" border="0"  class="insatbl">
    <tr >
        <th colspan="4" style="font-family:Arial; text-align:center; font-size:xx-small; color:Red;">(*) Los campos color rojo son obligatorios.</th>
    </tr>
	<tr runat="server" id="trID_ACCION_FORMATIVA">
		<td width="3"></td>
		<td align="left">
			<asp:Label Font-Names="Arial, Verdana" Font-Size="XX-Small" id="lblID_ACCION_FORMATIVA" runat="server" Text="ID CURSO" /></td>
		<td>
			<asp:TextBox CssClass="TextoNormalDerecha" ID="txtID_ACCION_FORMATIVA" runat="server"
                ReadOnly="True" Width="100px"></asp:Textbox></td>
		<td width="3"></td>
	</tr>
    <tr runat="server" id="trID_PROVEEDOR_AF">
        <td width="3">
        </td>
         <td align="left">
            <asp:Label CssClass="req" ID="lblID_PROVEEDOR_AF" runat="server" Text="PROVEEDOR *" />
        </td>
        <td>
            <cc1:ddlPROVEEDOR_AF ID="ddlPROVEEDOR_AF1" runat="server" AutoPostBack="True" 
                CssClass="DDLClass" Width="300px">
            </cc1:ddlPROVEEDOR_AF>
        </td>
        <td width="3">
        </td>
    </tr>    
    <tr runat="server" id="trCONTRATO_BOLPROS" visible="false" >
        <td width="3">
        </td>
         <td align="left">
            <asp:Label CssClass="req" ID="Label4" runat="server" Text="CONTRATO BOLPROS *" />
        </td>
        <td>
            <cc1:ddlCONTRATO_BOLPROS ID="ddlCONTRATO_BOLPROS1" runat="server" AutoPostBack="True" 
                CssClass="DDLClass" Width="300px">
            </cc1:ddlCONTRATO_BOLPROS>
        </td>
        <td width="3">
        </td>
    </tr>
    <tr runat="server" id="trACCION_CONTRATADA" visible="false" >
        <td width="3">
        </td>
         <td align="left">
            <asp:Label CssClass="req" ID="Label5" runat="server" Text="PROGRAMA BOLPROS *" />
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxACCION_CONTRATADA" AutoPostBack="true" runat="server" Height="18px" TextField="NOMBRE_ACCION_FORMATIVA" ValueField="ID_ACCION_CONTRATADA" 
                ValueType="System.Decimal" Width="300px">
         </dx:ASPxComboBox>
        </td>
        <td width="3">
        </td>
    </tr>
    <tr runat="server" id="trMODALIDAD_DE_FORMACION">
        <td width="3">
        </td>
        <td align="left">
            <asp:Label CssClass="req" ID="Label7" Text="MODALIDAD DE FORMACI�N *" runat="server" />
        </td>
        <td>
            <cc1:ddlMODALIDAD_DE_FORMACION id="ddlMODALIDAD_DE_FORMACION1" runat="server" AutoPostBack="True" 
                            CssClass="DDLClass" Width="300px" AllowFindHeight="260px"></cc1:ddlMODALIDAD_DE_FORMACION>        
        </td>
        <td width="3">
        </td>
    </tr>	
    <tr runat="server" id="trID_SITIO_CAPACITACION">
        <td width="3">
        </td>
        <td align="left">
            <asp:Label CssClass="req" ID="lblID_SITIO_CAPACITACION" runat="server" Text="CENTRO FORMACI�N *" />
        </td>
        <td>
            <cc1:ddlSITIO_CAPACITACION ID="ddlSITIO_CAPACITACION1" runat="server" AutoPostBack="True"
                CssClass="DDLClass" Width="300px">
            </cc1:ddlSITIO_CAPACITACION>
        </td>
        <td width="3">
        </td>
    </tr>
    <tr runat="server" id="trAREA_FORMACION">
        <td width="3">
        </td>
        <td align="left">
            <asp:Label CssClass="req" ID="lblID_AREA_FORMACION" runat="server"  Text="AREA DE FORMACI�N *" />
        </td>
        <td>
            <cc1:ddlAREA_FORMACION ID="ddlAREA_FORMACION1" runat="server" AutoPostBack="True"
                CssClass="DDLClass" Width="300px">
            </cc1:ddlAREA_FORMACION>
        </td>
        <td width="3">
        </td>
    </tr>
    <tr runat="server" id="trID_TEMA_CURSO">
        <td width="3">
        </td>
        <td align="left">
            <asp:Label CssClass="req" ID="lblID_TEMA_CURSO" runat="server" Text="CURSO *" />
        </td>
        <td>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtTEMA_CURSO" 
                runat="server" Width="280px"></asp:TextBox>
        </td>
        <td width="3">
        </td>
    </tr>
    <tr runat="server" id="trID_OFERTA_FORMATIVA">
		<td width="3"></td>
		<td align="left">
			<asp:Label CssClass="req" id="lblID_OFERTA_FORMATIVA" runat="server" Text="OFERTA *"/></td>
		<td>
			<cc1:ddlOFERTA_FORMATIVA id="ddlOFERTA_FORMATIVA1" runat="server" 
                AutoPostBack="True" CssClass="DDLClass" ></cc1:ddlOFERTA_FORMATIVA>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="ddlOFERTA_FORMATIVA1" Display="Dynamic" 
                ErrorMessage="Seleccione la oferta formativa">*</asp:RequiredFieldValidator>
        </td>
		<td width="3"></td>
	</tr>
    <tr runat="server" id="trNOMBRE_ACCION_FORMATIVA">
        <td width="3">
        </td>
        <td align="left">
            <asp:Label CssClass="req" ID="lblNOMBRE_ACCION_FORMATIVA" Text="NOMBRE CURSO *" runat="server" />
        </td>
        <td>
            <asp:TextBox CssClass="NormalUPPER" ID="txtNOMBRE_ACCION_FORMATIVA" runat="server" Width="296px" ></asp:TextBox>        
        </td>
        <td width="3">
        </td>
    </tr>	    
    <tr runat="server" id="trCODIGO_GRUPO_NUMERO_PARTICIPANTES">
        <td width="3">
        </td>
        <td align="left">
            <asp:Label CssClass="req" ID="lblCODIGO_GRUPO" runat="server" Text="CODIGO CURSO *" />
        </td>
        <td>
            <table>
                <tr>
                    <td>
                        <dx:ASPxTextBox ID="txtCODIGO_GRUPO" ClientInstanceName="txtCODIGO_GRUPO" runat="server" Width="150px"
                             ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" MaskSettings-ErrorText="Error en C�digo de Curso, el Correlativo debe ser de 3 d�gitos." >                            
                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip" >
                                <RequiredField ErrorText="C�digo de Curso es requerido." IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>   
                    </td>
                    <td>
                        <asp:Label CssClass="req" id="lblNUMERO_PARTICIPANTES" runat="server" Text="CUPO *"  />
                    </td>
                    <td>
                        <asp:TextBox CssClass="TextoNormalDerecha" id="txtNUMERO_PARTICIPANTES" Enabled="false" Text="22"  
                            runat="server" Width="80px"></asp:TextBox>
			            <asp:RegularExpressionValidator ID="RegularExpressionValidatorNUMERO_PARTICIPANTES" 
                            runat="server" ControlToValidate="txtNUMERO_PARTICIPANTES"
			            Display="Dynamic" ErrorMessage="Debe ingresar un numero valido" 
                            ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtNUMERO_PARTICIPANTES" Display="Dynamic" 
                            ErrorMessage="Escriba el numero de participantes">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>            
        </td>
        <td width="3">
        </td>
    </tr>
	
	<tr runat="server" id="trPARTICIPANTES_INSCRITOS">
		<td width="3"></td>
		<td align="left">
			<asp:Label Font-Names="Arial,Verdana" Font-Size="XX-Small" ForeColor="Red" id="lblPARTICIPANTES_INSCRITOS" Text="INSCRITOS *"  runat="server" /></td>
		<td>
            <table>
                <tr>
                    <td>
                        <asp:TextBox CssClass="TextoNormalDerecha" id="txtPARTICIPANTES_INSCRITOS" 
                        runat="server" Width="50px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorPARTICIPANTES_INSCRITOS" 
                            runat="server" ControlToValidate="txtPARTICIPANTES_INSCRITOS"
			            Display="Dynamic" ErrorMessage="Debe ingresar un numero valido" 
                            ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
                    </td>
                    <td></td>
                    <td></td>
                    <td>                       
                        
                    </td>
                </tr>
            </table>
			
			
        </td>
		<td width="3"></td>
	</tr>
	
	<tr>
	    <td width="3"></td>	    
	    <th align="left" colspan="2" class="insatbl"   >
	     <uc1:ucProgramacionAccionFormativa runat="server" id="ucProgramacion1" />
	    </th>
	    <td width="3"></td>
	</tr>
	
	<tr runat="server" id="trHORARIO">
		<td width="3"></td>
		<td align="left" class="req" >
			<asp:Label runat="server" ID="LabelHorario" Text="HORARIO: *" /> </td>
		<td>
			<asp:TextBox CssClass="NormalUPPER" id="txtHORARIO" runat="server" 
                Width="300px" MaxLength="800" EnableTheming="True" Height="50px" TextMode="MultiLine" >
            </asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtHORARIO" Display="Dynamic" 
                ErrorMessage="Escriba el Horario del Curso">*</asp:RequiredFieldValidator>           
        </td>
		<td width="3"></td>
	</tr>

    <tr runat="server" id="trLUGAR_EJECUCION">
		<td width="3"></td>
		<td align="left" class="req" >
			<asp:Label runat="server" ID="Label1" Text="LUGAR EJECUCI�N: *" /> </td>
		<td>
			<asp:TextBox CssClass="NormalUPPER" id="txtLUGAR_EJECUCION" runat="server" 
                Width="300px" MaxLength="254" EnableTheming="True" Enabled="False" 
                Height="45px" TextMode="MultiLine" ></asp:TextBox>
            </asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txtLUGAR_EJECUCION" Display="Dynamic" 
                ErrorMessage="Escriba el lugar de ejecuci�n del curso">*</asp:RequiredFieldValidator>           
        </td>
		<td width="3"></td>
	</tr>
    <tr runat="server" id="trDEPARTAMENTO">
        <td width="3"></td>
		<td align="left" class="req" >
			<asp:Label runat="server" ID="Label2" Text="DEPARTAMENTO: *" /> </td>
		<td>		
            <cc1:ddlDEPARTAMENTO ID="DdlDEPARTAMENTO1" runat="server" CssClass="DDLClass" Width="300px" 
                AutoPostBack="True" Enabled="False">
            </cc1:ddlDEPARTAMENTO>	
             <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ControlToValidate="DdlDEPARTAMENTO1" Display="Dynamic" 
                ErrorMessage="Seleccione el departamento">*</asp:RequiredFieldValidator>           
        </td>
		<td width="3"></td>
    </tr>
    <tr runat="server" id="trMUNICIPIO">
        <td width="3"></td>
		<td align="left" class="req" >
			<asp:Label runat="server" ID="Label3" Text="MUNICIPIO: *" /> </td>
		<td>	
            <cc1:ddlMUNICIPIO ID="DdlMUNICIPIO1" runat="server" CssClass="DDLClass" 
                Width="300px" Enabled="False">
            </cc1:ddlMUNICIPIO>		
             <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                ControlToValidate="DdlMUNICIPIO1" Display="Dynamic" 
                ErrorMessage="Seleccione el municipio">*</asp:RequiredFieldValidator>           
        </td>
		<td width="3"></td>        
    </tr>
	
	<tr runat="server" id="trNIT_FORMADOR">
		<td width="3"></td>
		<td align="left" class="req" >
			NIT DEL FORMADOR *:</td>
		<td>
            <dx:ASPxTextBox ID="txtCODI_FORMADOR" ClientInstanceName="txtCODI_FORMADOR" AutoPostBack="true" runat="server" Width="300px" ValidationSettings-Display="Dynamic">
                <MaskSettings Mask="9999-999999-999-9" IncludeLiterals="None" />                                            
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />           
            </dx:ASPxTextBox>
        </td>
		<td width="3"></td>
	</tr>
    <tr runat="server" id="trNOMBRE_FORMADOR">
		<td width="3"></td>
		<td align="left" >
			NOMBRE FORMADOR:</td>
		<td>
            <dx:ASPxTextBox ID="txtNOMBRE_FORMADOR" ClientInstanceName="txtNOMBRE_FORMADOR" ClientEnabled="false" MaxLength="150" runat="server" Width="300px" ValidationSettings-Display="Dynamic">  
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />                             
            </dx:ASPxTextBox>
        </td>
		<td width="3"></td>
	</tr>
	
	<tr runat="server" id="trCODIGO_ESTADO_AF_ID_EJERCICIO">
		<td width="3"></td>
		<td align="left">
			<asp:Label CssClass="req" id="lblCODIGO_ESTADO_AF" runat="server"  Text="ESTADO *" />
	    </td>
		<td>
		    <table>
		        <tr>
		            <td>
		                <cc1:ddlESTADO_ACCION_FORMATIVA id="ddlESTADO_ACCION_FORMATIVA1" runat="server" 
                            AutoPostBack="True" CssClass="DDLClass" Width="100px"></cc1:ddlESTADO_ACCION_FORMATIVA>
		            </td>
		            <td>
		                <asp:Label CssClass="req" id="lblID_EJERCICIO" runat="server" Text="EJERCICIO *" />
		            </td>
		            <td>
		                <cc1:ddlEJERCICIO id="ddlEJERCICIO1" runat="server" AutoPostBack="True" 
                            CssClass="DDLClass" Width="130px"></cc1:ddlEJERCICIO>
		            </td>
		        </tr>
		    </table>			
        </td>
		<td width="3"></td>
	</tr>
	
	<tr>
		<td width="3"></td>
		<td align="left">
			<asp:Label CssClass="req" id="lblDURACION_HORAS" runat="server" Text="DURACI�N *" /></td>
		<td>			
            <table>
                <tr>
                    <td>
                        <asp:TextBox CssClass="TextoNormalDerecha" id="txtDURACION_HORAS" 
                            runat="server" Width="80px"></asp:TextBox>
			            <asp:RegularExpressionValidator ID="RegularExpressionValidatorDURACION_HORAS" 
                            runat="server" ControlToValidate="txtDURACION_HORAS"
			            Display="Dynamic" ErrorMessage="Debe ingresar un numero valido" 
                            ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
                    </td>
                    <td>
                        <asp:Label CssClass="req" id="lblCOSTO_X_PARTICIPANTE" runat="server" Text="COSTO X PARTI. *" />
                    </td>
                    <td>
                        <asp:TextBox CssClass="TextoNormalDerecha" id="txtCOSTO_X_PARTICIPANTE" 
                            runat="server" Width="80px"></asp:TextBox>			            
                    </td>
                </tr>
            </table>
        </td>
		<td width="3"></td>
	</tr>
	
	<tr runat="server" id="trUSERID">
		<td width="3"></td>
		<td align="left">
			<asp:Label CssClass="Normal" id="lblUSERID" runat="server">Usuario:</asp:label></td>
		<td>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSERID" runat="server" Width="40px" MaxLength="16"></asp:TextBox>
</td>
		<td width="3"></td>
	</tr>
	<tr runat="server" id="trLASTUPDATE">
		<td width="3"></td>
		<td align="left">
			<asp:Label CssClass="Normal" id="lblLASTUPDATE" runat="server">&Uacute;LTIMA ACTUALIZACI&Oacute;N:</asp:label></td>
		<td>
			<asp:TextBox id="txtLASTUPDATE" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
</td>
		<td width="3"></td>
	</tr>
</table>

<asp:ObjectDataSource ID="odsACCION_CONTRATADA" runat="server" 
    OldValuesParameterFormatString="{0}" SelectMethod="ObtenerListaPorCONTRATO_BOLPROS" 
    TypeName="SGAFP.BL.cACCION_CONTRATADA">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_CONTRATO" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
        <asp:Parameter DefaultValue="ID_ACCION_CONTRATADA" Name="asColumnaOrden" Type="String" />  
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />  
    </SelectParameters>
</asp:ObjectDataSource>

