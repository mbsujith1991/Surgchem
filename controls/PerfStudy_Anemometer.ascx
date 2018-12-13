<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PerfStudy_Anemometer.ascx.cs" Inherits="controls_PerfStudy_Anemometer" %>

<style type="text/css">
    .textbox {
    width:100%;
    }
</style>
<asp:HiddenField ID="perfstudy_anemometer_hidden" runat="server" />

<h3>Performance Study of Anemometer</h3>

<table style="width:100%;" border="1">
    <tr>
        <th>Sl No</th>
        <th>SET AIR FLOW</th>
        <th>AIR FLOW ON STANDARD TEST EQUIPMENT</th>
        <th>AIR FLOW ON DUT</th>
        <th>DEVIATION+/- 5%</th>
        <th>REMARKS</th>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td><asp:TextBox ID="txtsetair1" runat="server" CssClass="textbox" Text="90"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstdair1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtairdut1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td><asp:TextBox ID="txtsetair2" runat="server" CssClass="textbox" Text="100"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstdair2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtairdut2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
</table>
<br />

<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>