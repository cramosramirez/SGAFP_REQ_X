<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleMODALIDAD_DE_FORMACION.ascx.vb" Inherits="controles_ucVistaDetalleMODALIDAD_DE_FORMACION" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>


<table>
     <tr>
        <td><dx:ASPxLabel ID="Label1" runat="server" Text="Identificador:"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxTextBox ID="txtID_MODALIDAD_FORMACION" runat="server" Width="150px">
            </dx:ASPxTextBox>
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Modalidad de Formación:"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxTextBox ID="txtMODALIDAD_FORMACION" Font-Bold="true" runat="server" MaxLength="100" Width="500px">
            </dx:ASPxTextBox>
        </td>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Comentario:"></dx:ASPxLabel></td>
        <th colspan="3" >            
            <dx:ASPxTextBox ID="txtNOTAS" Font-Bold="true" runat="server" MaxLength="255" Width="100%">
            </dx:ASPxTextBox>
        </th>
    </tr>
</table>


