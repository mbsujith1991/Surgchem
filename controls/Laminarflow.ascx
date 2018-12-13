<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Laminarflow.ascx.cs" Inherits="controls_Laminarflow" %>

<style type="text/css">
    .textbox {
        width: 200px;
    }
</style>

<asp:HiddenField ID="syntime_hidden" runat="server" />
<h3>Quality Assurance of Laminar Flow</h3>

<table style="width:100%;" border="1">
    <tr>
        <th>Inside Design condition </th>
        <td>
            <asp:TextBox ID="txtlam1" runat="server" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <th>Area of Operation Theatre</th>
        <td>
            <asp:TextBox ID="txtlam2" runat="server" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <th>
            Required Tonnage of AHU
        </th>
        <td>
            <asp:TextBox ID="txtlam3" runat="server" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <th>
            Air Quantity
        </th>
        <td>
            <asp:TextBox ID="txtlam4" runat="server" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <th>
            Static Pressure
        </th>
        <td>
            <asp:TextBox ID="txtlam5" runat="server" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <th>
            Air Changes calculated
        </th>
        <td>
            <asp:TextBox ID="txtlam6" runat="server" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <th>
            Fresh air changes calculated
        </th>
        <td>
            <asp:TextBox ID="txtlam7" runat="server" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
    
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" CssClass="button-link" OnClick="btnsave_Click"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="button-link" OnClick="btncancel_Click"/>
</div>