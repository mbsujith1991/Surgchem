<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ECG_Holtermachine.ascx.cs" Inherits="controls_ECG_Holtermachine" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>

<asp:HiddenField ID="ecg_holterhyidden" runat="server" />
<h3>ECG</h3>
    <table  border="1" style="width:100%;">
        <tr>
            <td>Sl No</td>
    <td>Parameter</td>
    <td>Value set on STD</td>
    <td>Value measured on DUT</td>
    <td>Deviation(bpm)</td>
    <td>Specified limit as per mfr. Specification(+/-5%)</td>
    <td>Remarks</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
            <td><asp:TextBox ID="txtpara1" runat="server" CssClass="textbox" Text="Heart Rate"></asp:TextBox></td>
            <td><asp:TextBox ID="txtstd1" runat="server" CssClass="textbox" Text="60"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdut1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
            <td><asp:TextBox ID="txtdev1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
            <td><asp:TextBox ID="txtspec1" runat="server" CssClass="textbox" Text="Between 57 bpm and 63bpm"></asp:TextBox></td>
            <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
            <td><asp:TextBox ID="txtpara2" runat="server" CssClass="textbox" Text="Heart Rate"></asp:TextBox></td>
            <td><asp:TextBox ID="txtstd2" runat="server" CssClass="textbox" Text="120"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdut2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
            <td><asp:TextBox ID="txtdev2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
            <td><asp:TextBox ID="txtspec2" runat="server" CssClass="textbox" Text="Between 114 bpm and 126 bpm"></asp:TextBox></td>
            <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
        </tr>
       
    </table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>