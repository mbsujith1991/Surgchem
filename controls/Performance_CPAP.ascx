<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Performance_CPAP.ascx.cs" Inherits="controls_Performance_CPAP" %>

<style type="text/css">
    .textbox {
    width:100%;
    }
</style>

<asp:HiddenField ID="perfcpap_hidden" runat="server" />
<h3>PERFORMANCE ANALYSIS OF CPAP</h3>

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
         <td><asp:TextBox ID="txtdut1" runat="server" CssClass="textbox" Text="30"></asp:TextBox></td>
         <td><asp:TextBox ID="txtavgstd1" runat="server" CssClass="textbox" Text="30.1"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdev1" runat="server" CssClass="textbox" Text="0.1"></asp:TextBox></td>
         <td><asp:TextBox ID="txtalodev1" runat="server" CssClass="textbox" Text="± 1BPM"></asp:TextBox></td>
         <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
     <tr>
         <td><asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
         <td><asp:TextBox ID="txtpara2" runat="server" TextMode="MultiLine" CssClass="textbox" Text="Inspiratory Positive Airway Pressure(IPAP) in cm H2O"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdut2" runat="server" CssClass="textbox" Text="8"></asp:TextBox></td>
         <td><asp:TextBox ID="txtavgstd2" runat="server" CssClass="textbox" Text="8.1"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdev2" runat="server" CssClass="textbox" Text="0.1"></asp:TextBox></td>
         <td><asp:TextBox ID="txtalodev2" runat="server" CssClass="textbox" Text="± 1 cm H2O"></asp:TextBox></td>
         <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
     <tr>
         <td><asp:TextBox ID="txtsl3" runat="server" CssClass="textbox" Text="3"></asp:TextBox></td>
         <td><asp:TextBox ID="txtpara3" runat="server" CssClass="textbox" TextMode="MultiLine" Text="Positive End Expiratory Pressure(PEEP)"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdut3" runat="server" CssClass="textbox" Text="4"></asp:TextBox></td>
         <td><asp:TextBox ID="txtavgstd3" runat="server" CssClass="textbox" Text="4.2"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdev3" runat="server" CssClass="textbox" Text="0.2"></asp:TextBox></td>
         <td><asp:TextBox ID="txtalodev3" runat="server" CssClass="textbox" Text="± 1 cm H2O"></asp:TextBox></td>
         <td><asp:TextBox ID="txtrem3" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>