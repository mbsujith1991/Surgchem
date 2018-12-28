<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Perfanalysis_micropipetteNew.ascx.cs" Inherits="controls_Perfanalysis_micropipetteNew" %>
<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>
<asp:HiddenField ID="Perfanalysis_Holtermachine_hidden" runat="server" />
<h3>Performance Analysis of Micro Pipette</h3>
<p>
    Pipette clinic follows the norms of ISO/IEC  17025 .This is compliance with national/international standards. piston operated device calibration is carried out in gravimetric method with respect to standards/mentioned as per ISO.
</p>
<table style="width: 100%;" border="1">
    <tr>
        <th width="5%">Sl No</th>
        <th width="30%">Device Reading(&#181;l)</th>
        <th>Mean Value(&#181;l)</th>
        <th>Correction(&#181;l)</th>
        <th>Measurement Uncertainity(&#181;l)</th>
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
            <asp:TextBox ID="txtMeasUncer1" runat="server" CssClass="textbox"></asp:TextBox></td>
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
            <asp:TextBox ID="txtMeasUncer2" runat="server" CssClass="textbox"></asp:TextBox></td>
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
            <asp:TextBox ID="txtMeasUncer3" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtrem3" runat="server" CssClass="textbox"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl4" runat="server" CssClass="textbox" Text="4"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtDevRead4" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtMean4" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtCorrection4" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtMeasUncer4" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtrem4" runat="server" CssClass="textbox"></asp:TextBox></td>
    </tr>
</table>
<p>
    The uncertainity estimated during the calibration is determined with the coverage factor K=2 and at the estimated confident level of 95% in accordance with ISO/TR 20461 .
</p>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link" />&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link" />
</div>
