<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Tempmeasure_deepfreezer.ascx.cs" Inherits="testfolder_Tempmeasure_deepfreezer" %>

<style type="text/css">
    .textbox {
    width:100%;
    }
</style>

<asp:HiddenField ID="tempmeasure_deepfreezer" runat="server" />
<h3>Temperature Measurement Deep Freezer</h3>
    <table border="1" style="width:100%;">
        <tr>
            <th rowspan="2">
                Sl No
            </th>
            <th rowspan="2">Temp SET on DUT ºC</th>
            <th rowspan="2">Temp Display on DUT ºC</th>
            <th colspan="5">Temperature measured on STD specific Test Points(TPs)</th>
            <th rowspan="2">Mean Value</th>
            <th rowspan="2">Deviation</th>
            <th rowspan="2">Specified limit as per Mfr. Spec.</th>
            <th rowspan="2">Remarks</th>
        </tr>
       <tr>
        <th>TP1</th>
        <th>TP2</th>
        <th>TP3</th>
        <th>TP4</th>
        <th>TP5</th>
    </tr>
         <tr>
        <td>
            <asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtsetdut1" runat="server" CssClass="textbox" Text="-10.0"></asp:TextBox>
        </td>
             <td><asp:TextBox ID="txtdispdut1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txttp1_1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txttp2_1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txttp3_1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txttp4_1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txttp5_1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        
        <td><asp:TextBox ID="txtmean1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec1" runat="server" CssClass="textbox" Text="± 5 ºC"></asp:TextBox></td>
             
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    </table>
   
    <br />
  <div>
      <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
      <asp:Button ID="btnsave" runat="server" Text="Save" CssClass="button-link"  OnClick="btnsave_Click"/>
    <asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="button-link" OnClick="btncancel_Click" />
  </div>
