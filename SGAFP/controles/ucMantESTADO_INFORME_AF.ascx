<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantESTADO_INFORME_AF.ascx.vb" Inherits="controles_ucMantESTADO_INFORME_AF" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaESTADO_INFORME_AF" Src="~/controles/ucListaESTADO_INFORME_AF.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleESTADO_INFORME_AF" Src="~/controles/ucVistaDetalleESTADO_INFORME_AF.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Estado informe af</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaESTADO_INFORME_AF id="ucListaESTADO_INFORME_AF1" runat="server"></uc1:ucListaESTADO_INFORME_AF>
                <uc1:ucVistaDetalleESTADO_INFORME_AF ID="ucVistaDetalleESTADO_INFORME_AF1" runat="server" Visible="false" ></uc1:ucVistaDetalleESTADO_INFORME_AF></TD>
        </TR>
    </TBODY>
</TABLE>
