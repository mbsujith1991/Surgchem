<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SyncTime.ascx.cs" Inherits="controls_SyncTime" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>

<asp:HiddenField ID="syntime_hidden" runat="server" />
<h3>Sync Time</h3>

<table style="width:100%;" border="1">
    <tr>
        <th rowspan="2" width="10%">Delivered Energy (J)</th>
        <th  width="20%">Sync Time</th>
        <th rowspan="2">Remarks</th>
    </tr>
    <tr>
        <th>
            R Wave (msec)*</th>
       
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtdelen1" runat="server" CssClass="textbox" Text="50"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrwave1" runat="server" CssClass="textbox" Text="27.3"></asp:TextBox></td>
        
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="* Normal Sync time should be within 20 to 30 milli second"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtdelen2" runat="server" CssClass="textbox" Text="100"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrwave2" runat="server" CssClass="textbox" Text="22"></asp:TextBox></td>
      
        <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="^ Normal Sync time should be within 50 to 60 milli second"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtdelen3" runat="server" CssClass="textbox" Text="200"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrwave3" runat="server" CssClass="textbox" Text="22"></asp:TextBox></td>
        
        <td><asp:TextBox ID="txtrem3" runat="server" CssClass="textbox"></asp:TextBox></td>
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" CssClass="button-link" OnClick="btnsave_Click"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="button-link" OnClick="btncancel_Click"/>
</div>
