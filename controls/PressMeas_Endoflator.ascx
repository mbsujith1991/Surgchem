<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PressMeas_Endoflator.ascx.cs" Inherits="controls_PressMeas_Endoflator" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>
<asp:HiddenField ID="acctest_stringehidden" runat="server" />
<h3>Pressure Measurement of Endoflator</h3>

<table class="perftest" border="1">
    <tr>
        <th rowspan="2">Sl No</th>
        <th rowspan="2">Vale Set on Device Under Test (DUT) in mmHg</th>
        <th colspan="5" >Repeated Readings taken on standard (mmHg)</th>
        <th rowspan="2">Mean Value (mmHg)</th>
        <th rowspan="2">Deviation (mmHg)</th>
        
        <th rowspan="2">Spec. Limit as per Mfr. Spec</th>
        <th rowspan="2">Remarks</th>
    </tr>
    <tr>
        <th>R1</th>
        <th>R2</th>
        <th>R3</th>
        <th>R4</th>
        <th>R5</th>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtslno1" runat="server" Text="1" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstddut1" runat="server" Text="100" CssClass="textbox"></asp:TextBox>
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
            <asp:TextBox ID="txtspec1" runat="server" Text="±5 mmHg" CssClass="textbox"></asp:TextBox>
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
            <asp:TextBox ID="txtdutstd2" runat="server" Text="200" CssClass="textbox"></asp:TextBox>
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
            <asp:TextBox ID="txtspec2" runat="server" Text="±5 mmHg" CssClass="textbox"></asp:TextBox>
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
            <asp:TextBox ID="txtstddut3" runat="server" Text="300" CssClass="textbox"></asp:TextBox>
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
            <asp:TextBox ID="txtspec3" runat="server" Text="±5 mmHg" CssClass="textbox"></asp:TextBox>
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