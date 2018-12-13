<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EnergyOutput.ascx.cs" Inherits="controls_EnergyOutput" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>
<asp:HiddenField ID="Energy_output" runat="server" />
<h3>Energy Output</h3>

<table style="width:100%;" border="1">
    <tr>
        <th>Sl No</th>
        <th>Value Set on DUT (J)</th>
        <th>Value Measured on STD (J)</th>
        <th>Deviation From the Set Value (J)</th>
        <th>Allowed Deviation (J)</th>
        <th>Remarks</th>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut1" runat="server" CssClass="textbox" Text="50"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstd1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtval1" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtalodev1" runat="server" CssClass="textbox" Text="+/- 5 %"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut2" runat="server" CssClass="textbox" Text="100"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstd2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtval2" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtalodev2" runat="server" CssClass="textbox" Text="+/- 5 %"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl3" runat="server" CssClass="textbox" Text="3"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut3" runat="server" CssClass="textbox" Text="150"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstd3" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtval3" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtalodev3" runat="server" CssClass="textbox" Text="+/- 5 %"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem3" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl4" runat="server" CssClass="textbox" Text="4"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut4" runat="server" CssClass="textbox" Text="200"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstd4" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtval4" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtalodev4" runat="server" CssClass="textbox" Text="+/- 5 %"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem4" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
            </td>
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>