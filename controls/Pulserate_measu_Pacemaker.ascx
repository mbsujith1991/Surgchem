<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Pulserate_measu_Pacemaker.ascx.cs" Inherits="controls_Pulserate_measu_Pacemaker" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>

<asp:HiddenField ID="Defibrillation" runat="server" />
<h3>Pulse Rate Measurement</h3>
    <table  border="1" style="width:100%;">
        <tr>
            <td>Sl No</td>
    <td width="15%">Parameter</td>
    <td>Value set on DUT (PPM)</td>
    <td>Value measured on STD (PPM)</td>
    <td>Deviation(PPM)</td>
    <td>Specified limit as per mfr. Specification(+/-5%)</td>
    <td>Remarks</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
            <td><asp:TextBox ID="txtpara1" runat="server" CssClass="textbox" Text="Pulse Rate"></asp:TextBox></td>
            <td><asp:TextBox ID="txtstd1" runat="server" CssClass="textbox" Text="40"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdut1" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdev1" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtspec1" runat="server" CssClass="textbox" Text="±2 PPM"></asp:TextBox></td>
            <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
        </tr>
         <tr>
            <td>
                <asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
            <td><asp:TextBox ID="txtpara2" runat="server" CssClass="textbox" Text="Pulse Rate"></asp:TextBox></td>
            <td><asp:TextBox ID="txtstd2" runat="server" CssClass="textbox" Text="180"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdut2" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdev2" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtspec2" runat="server" CssClass="textbox" Text="±2 PPM"></asp:TextBox></td>
            <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
        </tr>
        </table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>