<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Pressure_Nebuliser.ascx.cs" Inherits="controls_Pressure_Nebuliser" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>
<asp:HiddenField ID="nebu_hidden" runat="server" />
<h3>Pressure(Nebuliser)</h3>

<table style="width:100%;" border="1">
    <tr>
        <th>Sl No</th>
        <th>Parameter</th>
        <th>Value measured on STD (psi)</th>
        <th>Specified limit as per mfr. specification</th>
        <th>Remarks</th>
    </tr>
     <tr>
        <td><asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td><asp:TextBox ID="txtpara1" runat="server" CssClass="textbox" Text="Pressure"></asp:TextBox></td>
        <td><asp:TextBox ID="txtval1" runat="server" CssClass="textbox" Text="35.3"></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec1" runat="server" CssClass="textbox" Text="Should havea air pressure ≥ 35 psi"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
            </td>
    </tr>
    
    
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>