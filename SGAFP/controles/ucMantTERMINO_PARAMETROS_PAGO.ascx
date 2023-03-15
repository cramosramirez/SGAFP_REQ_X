<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantTERMINO_PARAMETROS_PAGO.ascx.vb" Inherits="controles_ucMantTERMINO_PARAMETROS_PAGO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaTERMINO_PARAMETROS_PAGO" Src="~/controles/ucListaTERMINO_PARAMETROS_PAGO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleTERMINO_PARAMETROS_PAGO" Src="~/controles/ucVistaDetalleTERMINO_PARAMETROS_PAGO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">PARAMETROS DE PAGO Y PENALIZACIONES PARA LIBRE GESTION</asp:Label></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaTERMINO_PARAMETROS_PAGO id="ucListaTERMINO_PARAMETROS_PAGO1" PermitirFiltroEnEncabezado="true" PermitirFilaDeFiltro="false" runat="server"></uc1:ucListaTERMINO_PARAMETROS_PAGO>
                <uc1:ucVistaDetalleTERMINO_PARAMETROS_PAGO ID="ucVistaDetalleTERMINO_PARAMETROS_PAGO1" runat="server" Visible="false" ></uc1:ucVistaDetalleTERMINO_PARAMETROS_PAGO></TD>
        </TR>
    </TBODY>
</TABLE>