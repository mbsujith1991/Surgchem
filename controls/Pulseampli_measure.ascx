<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Pulseampli_measure.ascx.cs" Inherits="controls_Pulseampli_measure" %>
<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>
<asp:HiddenField ID="pulseampli_hidden" runat="server" />
<h3>PULSE AMPLITUDE MEASUREMENT</h3>

<table class="perftest" border="1">
    <tr>
        <th>Sl No</th>
        <th width="20%">Parameter</th>
        <th>Value set on DUT (V)</th>
        <th >Value measured on STD (V)</th>
        <th >Deviation(V)</th>
        <th >Specified limit as per mfr. Specification(+/-5%)</th>
        <th >Remarks</th>
    </tr>
     <tr>
        <td>
            <asp:TextBox ID="txtslno1" runat="server" Text="1" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtpara1" runat="server" Text="Pulse Amplitude" CssClass="textbox"></asp:TextBox>
        </td>
        
        <td>
            <asp:TextBox ID="txtsetdut1" runat="server" Text="2" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtvalmeas1" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev1" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtspec1" runat="server" Text="±0.05 V" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem1" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtslno2" runat="server" Text="2" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtpara2" runat="server" Text="Pulse Amplitude" CssClass="textbox"></asp:TextBox>
        </td>
        
        <td>
            <asp:TextBox ID="txtsetdut2" runat="server" Text="10" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtvalmeas2" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev2" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtspec2" runat="server" Text="±0.05 V" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem2" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>