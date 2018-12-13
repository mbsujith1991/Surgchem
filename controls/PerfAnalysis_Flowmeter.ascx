<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PerfAnalysis_Flowmeter.ascx.cs" Inherits="controls_PerfAnalysis_Flowmeter" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>

<asp:HiddenField ID="flowmeter_hidden" runat="server" />
<h3>Flow Meter</h3>

<table style="width:100%;" border="1">
    <tr>
        <th width="10%">Sl No</th>
        <th  width="20%">Value as Set on DUT (FLOW IN LITRES)</th>
        <th></th>
    </tr>
   
    <tr>
        <td>
            <asp:TextBox ID="txtdelen1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrwave1" runat="server" CssClass="textbox" Text="8 L"></asp:TextBox></td>
        
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="All the DUTs  tested and the test values are come under ± 5 % deviation."></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtdelen2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrwave2" runat="server" CssClass="textbox" Text="4 L"></asp:TextBox></td>
      <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtdelen3" runat="server" CssClass="textbox" Text="3"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrwave3" runat="server" CssClass="textbox" Text="2 L"></asp:TextBox></td>
        
        <td><asp:TextBox ID="txtrem3" runat="server" CssClass="textbox"></asp:TextBox></td>
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" CssClass="button-link" OnClick="btnsave_Click"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="button-link" OnClick="btncancel_Click"/>
</div>