<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Perfanalysis_weighingmachn.ascx.cs" Inherits="controls_Perfanalysis_weighingmachn" %>

<style type="text/css">
    .textbox {
        width:100%;
    }
</style>

<asp:HiddenField ID="perf_weighmachn_hidden" runat="server" />

<h3>Performance Analysis of Weighing Machine</h3>

<table style="width:100%;" border="1">
     <tr>
        <th rowspan="2">Sl No</th>
        <th>Standard weight (STD) </th>
        <th>DUT under comparison  </th>
        <th rowspan="2">Value measured on DUT (mm)</th>
        <th>Specified limit as per mfr. Specification(+/-5%)</th>
        <th rowspan="2">Remarks</th>
    </tr>
    <tr>
        <th>in kg</th>
        <th>in kg</th>
        <th>Spec</th>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstdw1" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtvaldut1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec1" runat="server" CssClass="textbox" Text="±5%"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstdw2" runat="server" CssClass="textbox" Text="5"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtvaldut2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec2" runat="server" CssClass="textbox" Text="±5%"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl3" runat="server" CssClass="textbox" Text="3"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstdw3" runat="server" CssClass="textbox" Text="10"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut3" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtvaldut3" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec3" runat="server" CssClass="textbox" Text="±5%"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem3" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl4" runat="server" CssClass="textbox" Text="4"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstdw4" runat="server" CssClass="textbox" Text="15"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut4" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtvaldut4" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec4" runat="server" CssClass="textbox" Text="±5%"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem4" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl5" runat="server" CssClass="textbox" Text="5"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstdw5" runat="server" CssClass="textbox" Text="66"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut5" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtvaldut5" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec5" runat="server" CssClass="textbox" Text="±5%"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem5" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl6" runat="server" CssClass="textbox" Text="6"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstdw6" runat="server" CssClass="textbox" Text="78"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut6" runat="server" CssClass="textbox" Text="78.08"></asp:TextBox></td>
        <td><asp:TextBox ID="txtvaldut6" runat="server" CssClass="textbox" Text="0.08"></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec6" runat="server" CssClass="textbox" Text="±5%"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem6" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" CssClass="button-link" OnClick="btnsave_Click"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="button-link" OnClick="btncancel_Click"/>
</div>
