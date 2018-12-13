<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Temp_Humidity.ascx.cs" Inherits="controls_Temp_Humidity" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>

<asp:HiddenField ID="temp_middle" runat="server" />
<h3>Humidity of Hygrometer</h3>

<table style="width:100%;" border="1">
    <tr>
         <th rowspan="2">Sl No</th>
        <th colspan="2">Humidity Measured on</th>
        <th rowspan="2">Deviation</th>
        <th rowspan="2">Specified limit</th>
        <th rowspan="2">Remarks</th>
    </tr>
    <tr>
        <th>Standard</th>
        <th>DUT</th>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl1" runat="server" Text="1" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstd1" runat="server" Text="48" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut1" runat="server" Text="48" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev1" runat="server" Text="0" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec1" runat="server" Text="±5%" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem1" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox></td>
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>