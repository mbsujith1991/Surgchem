﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Flow.ascx.cs" Inherits="controls_Flow" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>
<asp:HiddenField ID="flow_hidden" runat="server" />
<h3>Flow</h3>

<table style="width:100%;" border="1">
    <tr>
        <th>Sl No</th>
        <th>Value as Set on DUT (L/minute)</th>
        <th>Average Value as on STD (L/minute)</th>
        <th>Deviation</th>
        <th>Allowed Deviation</th>
        <th>Remarks</th>
    </tr>
     <tr>
        <td><asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut1" runat="server" CssClass="textbox" Text="8"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstd1" runat="server" CssClass="textbox" Text="8.2"></asp:TextBox></td>
        <td><asp:TextBox ID="txtval1" runat="server" CssClass="textbox" Text="0.2"></asp:TextBox></td>
        <td><asp:TextBox ID="txtalodev1" runat="server" CssClass="textbox" Text="+/- 5%"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut2" runat="server" CssClass="textbox" Text="6"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstd2" runat="server" CssClass="textbox" Text="6.2"></asp:TextBox></td>
        <td><asp:TextBox ID="txtval2" runat="server" CssClass="textbox" Text="0.2"></asp:TextBox></td>
        <td><asp:TextBox ID="txtalodev2" runat="server" CssClass="textbox" Text="+/- 5%"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl3" runat="server" CssClass="textbox" Text="3"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut3" runat="server" CssClass="textbox" Text="5"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstd3" runat="server" CssClass="textbox" Text="5.2"></asp:TextBox></td>
        <td><asp:TextBox ID="txtval3" runat="server" CssClass="textbox" Text="0.2"></asp:TextBox></td>
        <td><asp:TextBox ID="txtalodev3" runat="server" CssClass="textbox" Text="+/- 5%"></asp:TextBox></td>
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