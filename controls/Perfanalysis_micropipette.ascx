<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Perfanalysis_micropipette.ascx.cs" Inherits="controls_Perfanalysis_micropipette" %>


<style type="text/css">
    .textbox {
    width:100%;
    }
</style>

<asp:HiddenField ID="Perfanalysis_Holtermachine_hidden" runat="server" />

<h3>Performance Analysis of Micro Pipette</h3>

<table style="width:100%;" border="1">
    <tr>
       <th width="5%">Sl No</th>
        <th width="30%">Standard Volume (STD) in &#181;l</th>
        <th colspan="3">Measured Volume on DUT as per Electronic Balance with the  Z factor  [Volume ( ml or ul ) = Weight ( mg or ug ) x Z]</th>
        <th>Mean Value</th>
        <th>Deviation</th>
        <th>Specified Limit as per Mfr’s Spec</th>
        <th>Remarks</th>
    </tr>
     <tr>
         <td><asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
         <td><asp:TextBox ID="txtstdvol1" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdut1_1" runat="server" CssClass="textbox" Text="2.14"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdut1_2" runat="server" CssClass="textbox" Text="2.07"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdut1_3" runat="server" CssClass="textbox" Text="2.16"></asp:TextBox></td>
         <td><asp:TextBox ID="txtmean1" runat="server" CssClass="textbox" Text="2.12"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdev1" runat="server" CssClass="textbox" Text="0.12"></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec1" runat="server" CssClass="textbox" Text="± %10.00 &#181;l"></asp:TextBox></td>
         <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
     <tr>
         <td><asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
         <td><asp:TextBox ID="txtstdvol2" runat="server" CssClass="textbox" Text="20"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdut2_1" runat="server" CssClass="textbox" Text="20.00"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdut2_2" runat="server" CssClass="textbox" Text="20.06"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdut2_3" runat="server" CssClass="textbox" Text="20.16"></asp:TextBox></td>
         <td><asp:TextBox ID="txtmean2" runat="server" CssClass="textbox" Text="20.07"></asp:TextBox></td>
         <td><asp:TextBox ID="txtdev2" runat="server" CssClass="textbox" Text="0.07"></asp:TextBox></td>
       <td><asp:TextBox ID="txtspec2" runat="server" CssClass="textbox" Text="±%1.00&#181;l"></asp:TextBox></td>
         <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
     
    
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>
