<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ChamberPressureguage.ascx.cs" Inherits="controls_ChamberPressureguage" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>
<asp:HiddenField ID="flow_hidden" runat="server" />
<h3>Performance Analysis of Chamber Pressure Guage</h3>

<table style="width:100%;" border="1">
    <tr>
        <th rowspan="2">Sl No</th>
        <th colspan="2">Pressure Measured On</th>
        <th rowspan="2">DUT Required</th>
        <th rowspan="2">Specified Limit</th>
        <th rowspan="2">Remarks</th>
    </tr>
    <tr>
        <th>STD</th>
        <th>DUT</th>
    </tr>
     <tr>
        <td><asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtstd1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtval1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtalodev1" runat="server" CssClass="textbox" Text="+/- 5%"></asp:TextBox></td>
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