<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RPMMeasurement_4_28_18.ascx.cs" Inherits="controls_RPMMeasurement_4_28_18" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>
<asp:HiddenField ID="rpmmeasure_hidden" runat="server" />
<h3>RPM Measurement</h3>

    <table class="perftest" border="1">
    <tr>
        <th>Sl No</th>
        <th>Display on Device Under Test (DUT)</th>
        <th colspan="5" width="35%" >RPM Measured on Standard</th>
        <th >Mean Value</th>
        <th >Deviation</th>
        <th >Spec. Limit as per Mfr. Spec.</th>
        <th >Remarks</th>
    </tr>
         <tr>
        <td>
            <asp:TextBox ID="txtslno1" runat="server" Text="1" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstddut1" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtinstnt1" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtinstnt2" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtinstnt3" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtinstnt4" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtinstnt5" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtmean1" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdevml1" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        
        <td>
            <asp:TextBox ID="txtspec1" runat="server" Text="+/-5%" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem1" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
         <tr>
        <td>
            <asp:TextBox ID="txtslno2" runat="server" Text="2" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdutstd2" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtinstnt6" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
         <td>
            <asp:TextBox ID="txtinstnt7" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
         <td>
            <asp:TextBox ID="txtinstnt8" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
         <td>
            <asp:TextBox ID="txtinstnt9" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
         <td>
            <asp:TextBox ID="txtinstnt10" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtmean2" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdevml2" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
       
        <td>
            <asp:TextBox ID="txtspec2" runat="server" Text="+/-5%" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem2" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
     
        </table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>
