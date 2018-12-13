<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TempMeasure_RadiantWarmer.ascx.cs" Inherits="controls_TempMeasure_RadiantWarmer" %>

<style type="text/css">
    .textbox {
   width:100%;
    }
   
</style>

<h3>Temperature Measure of Radiant Warmer</h3>
<asp:HiddenField ID="temp_measure_radiantwarmer" runat="server" />

<table style="width:100%;" border="1">
    <tr>
        <th rowspan="2">Sl No</th>
            <th rowspan="2">Temp set on DUT</th>
            <th rowspan="2">Temp Displayed on DUT</th>
            <th rowspan="2">Temp Measured on STD</th>
            <th colspan="2">Deviation</th>
            <th>Specified limit as per Mfr. Spec.</th>
            <th rowspan="2">Remarks</th>
    </tr>
     <tr>
            <th>w.r.t Temp set on DUT</th>
            <th>w.r.t Temp Display on DUT</th>
           <th>Display</th>
        </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
         <td><asp:TextBox ID="txtsettemp1" runat="server" CssClass="textbox" Text="35.0"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdispdut1" runat="server" CssClass="textbox"></asp:TextBox></td>
         <td><asp:TextBox ID="txttempstd1" runat="server" CssClass="textbox"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdevsetdut1" runat="server" CssClass="textbox"></asp:TextBox></td>
         <td><asp:TextBox ID="txttempdispdut1" runat="server" CssClass="textbox"></asp:TextBox></td>
         <td><asp:TextBox ID="txtspecdisp1" runat="server" CssClass="textbox" Text="± 0.5ºC"></asp:TextBox></td>
         <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
     <tr>
        <td>
            <asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
         <td><asp:TextBox ID="txtsettemp2" runat="server" CssClass="textbox" Text="36.0"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdispdut2" runat="server" CssClass="textbox"></asp:TextBox></td>
         <td><asp:TextBox ID="txttempstd2" runat="server" CssClass="textbox"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdevsetdut2" runat="server" CssClass="textbox"></asp:TextBox></td>
         <td><asp:TextBox ID="txttempdispdut2" runat="server" CssClass="textbox"></asp:TextBox></td>
         <td><asp:TextBox ID="txtspecdisp2" runat="server" CssClass="textbox" Text="± 0.5ºC"></asp:TextBox></td>
         <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click"/>
</div>
