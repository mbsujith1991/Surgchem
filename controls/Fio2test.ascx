<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Fio2test.ascx.cs" Inherits="controls_Fio2test" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>
<asp:HiddenField ID="flow_hidden" runat="server" />
<h3>FiO<sub>2</sub> Test</h3>

<table style="width:100%;" border="1">
    <tr>
        <th>Sl No</th>
        <th>Value as Set on DUT </th>
        <th>Monitored on DUT</th>
        <th>Limit</th>
        <th>Remarks</th>
    </tr>
     <tr>
        <td><asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut1" runat="server" CssClass="textbox" Text="21 %"></asp:TextBox></td>
        <td><asp:TextBox ID="txtmon1" runat="server" CssClass="textbox" Text="21.1 %"></asp:TextBox></td>
        <td><asp:TextBox ID="txtlim1" runat="server" CssClass="textbox" Text="+/- 5%"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut2" runat="server" CssClass="textbox" Text="50 %"></asp:TextBox></td>
        <td><asp:TextBox ID="txtmon2" runat="server" CssClass="textbox" Text="50.2 %"></asp:TextBox></td>
        <td><asp:TextBox ID="txtlim2" runat="server" CssClass="textbox" Text="+/- 5%"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl3" runat="server" CssClass="textbox" Text="3"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut3" runat="server" CssClass="textbox" Text="100 %"></asp:TextBox></td>
        <td><asp:TextBox ID="txtmon3" runat="server" CssClass="textbox" Text="99.8 %"></asp:TextBox></td>
        <td><asp:TextBox ID="txtlim3" runat="server" CssClass="textbox" Text="+/- 5%"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem3" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
            </td>
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>