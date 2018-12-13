<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Glucometer.ascx.cs" Inherits="controls_Glucometer" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>
<asp:HiddenField ID="flow_hidden" runat="server" />
<h3>Control Reagent for Glucometer</h3>

<table style="width:100%;" border="1">
    <tr>
        <th>Sl No</th>
        <th>CONTROL SOLUTION RANGE(72-76 mg/dl)</th>
        <th>Remarks</th>
        
    </tr>
     <tr>
        <td><asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td><asp:TextBox ID="txtcon1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        
    </tr>
    
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>