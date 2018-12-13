<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SpO2usercontrol.ascx.cs" Inherits="testfolder_SpO2usercontrol" %>

<style type="text/css">
    
    .textbox {
        width: 100%;
    }
</style>


<asp:HiddenField ID="perf_valueHidden" runat="server" />
<div class="widthdiv">
    SpO2
<table  border="1"  style="width:100%;height:30px; text-align:center;">
  <tr>
    <th rowspan="2">Sl No</th>
    <th colspan="2">Value Set On STD</th>
    <th colspan="2">Value Measured on DUT</th>
    <th colspan="2">Deviation</th>
    <th colspan="2">SPECIFIED LIMIT As per Mfr. Specification</th>
    <th rowspan="2">Remarks</th>
  </tr>
  <tr>
    <th>SpO2 %</th>
    <th>Pulse&nbsp; Rate</th>
    <th>SpO2 %</th>
    <th>Pulse Rate</th>
    <th>SpO2 %</th>
    <th>Pulse Rate</th>
    <th>SpO2 %</th>
    <th>Pulse Rate</th>
  </tr>
 <tr>
     <td><asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
     <td><asp:TextBox ID="txtstdspo2_1" runat="server" CssClass="textbox" Text="95"></asp:TextBox></td>
     <td><asp:TextBox ID="txtstdhrate1" runat="server" CssClass="textbox" Text="75"></asp:TextBox></td>
     <td><asp:TextBox ID="txtdutspo2_1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
     <td><asp:TextBox ID="txtduthrate1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
     <td><asp:TextBox ID="txtdevspo2_1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
     <td><asp:TextBox ID="txtdevhrate1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
     <td><asp:TextBox ID="txtspecspo2_1" runat="server" CssClass="textbox" Text="±2"></asp:TextBox></td>
     <td><asp:TextBox ID="txtspechrate1" runat="server" CssClass="textbox" Text="±2"></asp:TextBox></td>
     <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
 </tr>
     <tr>
     <td><asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
     <td><asp:TextBox ID="txtstdspo2_2" runat="server" CssClass="textbox" Text="90"></asp:TextBox></td>
     <td><asp:TextBox ID="txtstdhrate2" runat="server" CssClass="textbox" Text="65"></asp:TextBox></td>
     <td><asp:TextBox ID="txtdutspo2_2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
     <td><asp:TextBox ID="txtduthrate2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
     <td><asp:TextBox ID="txtdevspo2_2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
     <td><asp:TextBox ID="txtdevhrate2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
     <td><asp:TextBox ID="txtspecspo2_2" runat="server" CssClass="textbox" Text="±2"></asp:TextBox></td>
     <td><asp:TextBox ID="txtspechrate2" runat="server" CssClass="textbox" Text="±2"></asp:TextBox></td>
     <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
 </tr>
     <tr>
     <td><asp:TextBox ID="txtsl3" runat="server" CssClass="textbox" Text="3"></asp:TextBox></td>
     <td><asp:TextBox ID="txtstdspo2_3" runat="server" CssClass="textbox" Text="80"></asp:TextBox></td>
     <td><asp:TextBox ID="txtstdhrate3" runat="server" CssClass="textbox" Text="60"></asp:TextBox></td>
     <td><asp:TextBox ID="txtdutspo2_3" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
     <td><asp:TextBox ID="txtduthrate3" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
     <td><asp:TextBox ID="txtdevspo2_3" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
     <td><asp:TextBox ID="txtdevhrate3" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
     <td><asp:TextBox ID="txtspecspo2_3" runat="server" CssClass="textbox" Text="±2"></asp:TextBox></td>
     <td><asp:TextBox ID="txtspechrate3" runat="server" CssClass="textbox" Text="±2"></asp:TextBox></td>
     <td><asp:TextBox ID="txtrem3" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
 </tr>
</table>
 
    <br />
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" CssClass="widthclass button-link" OnClick="btnsave_Click" />
    <asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="widthclass button-link" OnClick="btncancel_Click" />
    </div>

