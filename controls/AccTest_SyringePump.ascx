<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AccTest_SyringePump.ascx.cs" Inherits="controls_AccTest_SyringePump" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>
<asp:HiddenField ID="acctest_stringehidden" runat="server" />
<h3>Accuracy Test for Syringe Pump</h3>

<table class="perftest" border="1">
    <tr>
        <th>Sl No</th>
        <th>Value Set on DUT in ml/hr</th>
        <th colspan="5" >Instant values Measured on Standard in ml/hr</th>
        <th >Mean Value</th>
        <th >Deviation in ml/hr</th>
        
        <th >General Acceptable Spec. Limit ( ± 5% ml/hr)</th>
        <th >Remarks</th>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtslno1" runat="server" Text="1" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstddut1" runat="server" Text="20" CssClass="textbox"></asp:TextBox>
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
            <asp:TextBox ID="txtspec1" runat="server" Text="1" CssClass="textbox"></asp:TextBox>
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
            <asp:TextBox ID="txtdutstd2" runat="server" Text="30" CssClass="textbox"></asp:TextBox>
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
            <asp:TextBox ID="txtspec2" runat="server" Text="1.5" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem2" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
     <tr>
        <td>
            <asp:TextBox ID="txtslno3" runat="server" Text="3" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstddut3" runat="server" Text="50" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtinstnt11" runat="server" Text="" CssClass="textbox"></asp:TextBox>
            </td>
         <td>
            <asp:TextBox ID="txtinstnt12" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
         <td>
            <asp:TextBox ID="txtinstnt13" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
         <td>
            <asp:TextBox ID="txtinstnt14" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
         <td>
            <asp:TextBox ID="txtinstnt15" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtmean3" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdevml3" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
       
        <td>
            <asp:TextBox ID="txtspec3" runat="server" Text="2.5" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem3" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server"></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>