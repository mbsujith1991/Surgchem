<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Fio2test_New.ascx.cs" Inherits="controls_Fio2test_New" %>

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
        <th>Observed on DUT </th>
        <th>Range</th>
        <th>Remarks</th>
    </tr>
     <tr>
        <td><asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut1" runat="server" CssClass="textbox" Text="94 %"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrange1" runat="server" CssClass="textbox" Text="90 % - 95 %"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblTestTime" runat="server" Text="Test Time"></asp:Label>
</div>
<div>
    <asp:Label ID="lblInMinute" runat="server" Text="In Minute "></asp:Label>: 10 min
</div>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>