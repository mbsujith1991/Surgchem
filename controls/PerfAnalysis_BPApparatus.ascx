<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PerfAnalysis_BPApparatus.ascx.cs" Inherits="controls_PerfAnalysis_BPApparatus" %>

<style type="text/css">
    .textbox {
        width:100%;
    }
</style>

<asp:HiddenField ID="perf_bpapparatus_hidden" runat="server" />

<h3>Performance Analysis of BP Apparatus</h3>

<table style="width:100%;" border="1">
    <tr>
        <th>Sl No</th>
        <th>Value Set on Device Under Test (DUT) in mmHg</th>
        <th>Readings taken on prosim4 (mmHg)</th>
        <th>Deviation (mmHg)</th>
        <th>Standard Deviation</th>
        <th>Remarks</th>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut1" runat="server" CssClass="textbox" Text="200"></asp:TextBox></td>
        <td><asp:TextBox ID="txtprosim1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtstddev1" runat="server" CssClass="textbox" Text="±5%"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut2" runat="server" CssClass="textbox" Text="150"></asp:TextBox></td>
        <td><asp:TextBox ID="txtprosim2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtstddev2" runat="server" CssClass="textbox" Text="±5%"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl3" runat="server" CssClass="textbox" Text="3"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut3" runat="server" CssClass="textbox" Text="100"></asp:TextBox></td>
        <td><asp:TextBox ID="txtprosim3" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev3" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtstddev3" runat="server" CssClass="textbox" Text="±5%"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem3" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel"  OnClick="btncancel_Click" CssClass="button-link"/>
</div>