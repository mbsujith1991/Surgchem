<%@ Control Language="C#" AutoEventWireup="true" CodeFile="flowrate_dialysismachine.ascx.cs" Inherits="controls_flowrate_dialysismachine" %>


<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>

<asp:HiddenField ID="Defibrillation" runat="server" />
<h3>Flow Rate of Dialysis Machine</h3>
    <table  border="1" style="width:100%;">
        <tr>
            <td>Sl No</td>
            <td>Value set on DUT</td>
            <td colspan="3">Instant Values Measured on Standard in ml/min</td>
            <td>Mean Value</td>
            <td>Deviation(±5%)</td>
            <td>Remarks</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
            <td><asp:TextBox ID="txtstd1" runat="server" CssClass="textbox" Text="100"></asp:TextBox></td>
            <td><asp:TextBox ID="txtinst1" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtinst2" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtinst3" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtmean1" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdev1" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
            <td><asp:TextBox ID="txtstd2" runat="server" CssClass="textbox" Text="200"></asp:TextBox></td>
            <td><asp:TextBox ID="txtinst4" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtinst5" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtinst6" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtmean2" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdev2" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtsl3" runat="server" CssClass="textbox" Text="3"></asp:TextBox></td>
            <td><asp:TextBox ID="txtstd3" runat="server" CssClass="textbox" Text="300"></asp:TextBox></td>
            <td><asp:TextBox ID="txtinst7" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtinst8" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtinst9" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtmean3" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdev3" runat="server" CssClass="textbox"></asp:TextBox></td>
            <td><asp:TextBox ID="txtrem3" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
        </tr>
    </table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>