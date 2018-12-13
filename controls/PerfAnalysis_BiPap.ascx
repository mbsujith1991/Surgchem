<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PerfAnalysis_BiPap.ascx.cs" Inherits="controls_PerfAnalysis_BiPap" %>


<style type="text/css">
    .textbox {
    width:100%;
    }
</style>

<asp:HiddenField ID="perfBipap_hidden" runat="server" />
<h3>PERFORMANCE ANALYSIS OF BiPAP</h3>

<table style="width:100%;" border="1">
    <tr>
       <th width="5%">Sl No</th>
        <th width="30%">Parameter Range</th>
        <th>Value as Set on DUT</th>
        <th>Average Value as on STD</th>
        <th>Deviation</th>
        <th>Allowed Deviation</th>
        <th>Remarks</th>
    </tr>
     <tr>
         <td><asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
         <td><asp:TextBox ID="txtpara1" runat="server" CssClass="textbox" Text="Breath rate (IE)"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdut1" runat="server" CssClass="textbox" Text="25"></asp:TextBox></td>
         <td><asp:TextBox ID="txtavgstd1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
         <td><asp:TextBox ID="txtdev1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
         <td><asp:TextBox ID="txtalodev1" runat="server" CssClass="textbox" Text="± 2BPM"></asp:TextBox></td>
         <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
     <tr>
         <td><asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
         <td><asp:TextBox ID="txtpara2" runat="server" TextMode="MultiLine" CssClass="textbox" Text="Inspiratory Positive Airway Pressure(IPAP) in cm H2O"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdut2" runat="server" CssClass="textbox" Text="16"></asp:TextBox></td>
         <td><asp:TextBox ID="txtavgstd2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
         <td><asp:TextBox ID="txtdev2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
         <td><asp:TextBox ID="txtalodev2" runat="server" CssClass="textbox" Text="± 2 cm H2O"></asp:TextBox></td>
         <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
     <tr>
         <td><asp:TextBox ID="txtsl3" runat="server" CssClass="textbox" Text="3"></asp:TextBox></td>
         <td><asp:TextBox ID="txtpara3" runat="server" CssClass="textbox" TextMode="MultiLine" Text="Expiratory Positive Airway Pressure(EPAP) in cm H2O"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdut3" runat="server" CssClass="textbox" Text="6"></asp:TextBox></td>
         <td><asp:TextBox ID="txtavgstd3" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
         <td><asp:TextBox ID="txtdev3" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
         <td><asp:TextBox ID="txtalodev3" runat="server" CssClass="textbox" Text="± 2 cm H2O"></asp:TextBox></td>
         <td><asp:TextBox ID="txtrem3" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>
