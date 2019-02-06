<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Perfanalysis_micropipette2019.ascx.cs" Inherits="controls_Perfanalysis_micropipette2019" %>
<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>
<asp:HiddenField ID="Perfanalysis_Holtermachine_hidden" runat="server" />
<h3>Performance Analysis of Micro Pipette</h3>

<table style="width: 100%;" border="1">
    <tr>
        <th width="5%">Sl No</th>
        <th width="30%">Device Reading(&#181;l)</th>
        <th>Mean Value(&#181;l)</th>
        <th>Correction(&#181;l)</th>
        <th>Accuracy(%)</th>
        <th>Remarks</th>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtDevRead1" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtMean1" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtCorrection1" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtAccuracy1" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtrem1" runat="server" CssClass="textbox"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtDevRead2" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtMean2" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtCorrection2" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtAccuracy2" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtrem2" runat="server" CssClass="textbox"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl3" runat="server" CssClass="textbox" Text="3"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtDevRead3" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtMean3" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtCorrection3" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtAccuracy3" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtrem3" runat="server" CssClass="textbox"></asp:TextBox></td>
    </tr>    
</table>

<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link" />&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link" />
</div>