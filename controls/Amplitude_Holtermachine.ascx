<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Amplitude_Holtermachine.ascx.cs" Inherits="controls_Amplitude_Holtermachine" %>

<style type="text/css">
    .textbox {
        width:100%;
        word-wrap:break-word;
    }
</style>

<asp:HiddenField ID="amplitude_hidden" runat="server" />

<h3>Amplitude</h3>

<table style="width:100%;" border="1">
    <tr>
        <th>Sl No</th>
        <th>Parameter</th>
        <th colspan="2">Value set on STD </th>
        <th>Value measured on DUT (mm)</th>
        <th>Specified limit as per mfr. Specification(+/-5%)</th>
        <th>Remarks</th>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl1" runat="server" Text="1" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtpara" runat="server" Text="Amplitude" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtsetstd1" runat="server" Text="1mv" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtsetstd2" runat="server" Text="sensitivity at 20mm/mV" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut" runat="server" Text="19.3" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec" runat="server" TextMode="MultiLine"  Text="For an amplitude setting of 1mv and sensitivity of 20mm/mV,peak height should be between 19 mm and 21 mm" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox></td>
        
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" CssClass="button-link" OnClick="btnsave_Click"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="button-link" OnClick="btncancel_Click" />
</div>