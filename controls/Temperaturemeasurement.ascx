<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Temperaturemeasurement.ascx.cs" Inherits="controls_Temperaturemeasurement" %>

<style type="text/css">
    .textbox {
    width:100%;
    }
</style>

<asp:HiddenField ID="tempmeasure_deepfreezer" runat="server" />
<h3>Temperature Measurement</h3>
    <table border="1" style="width:100%;">
        <tr>
            <th rowspan="2">
                Sl No
            </th>
            <th rowspan="2">Temperature Set on DUT</th>
            <th colspan="3">Temperature measured on DUT</th>
            <th rowspan="2">Mean Value</th>
            <th rowspan="2">Deviation</th>
            <th rowspan="2">Deviation Specified limit as per Mfr. Spec.</th>
            <th rowspan="2">Remarks</th>
        </tr>
       <tr>
        <th>TP1</th>
        <th>TP2</th>
        <th>TP3</th>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td><asp:TextBox ID="txttempset1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txttp1_1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txttp2_1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txttp3_1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        
        
        <td><asp:TextBox ID="txtmean1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec1" runat="server" CssClass="textbox" Text="+-5%"></asp:TextBox></td>
             
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
        <td><asp:TextBox ID="txttempset2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txttp1_2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txttp2_2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txttp3_2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        
        
        <td><asp:TextBox ID="txtmean2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec2" runat="server" CssClass="textbox" Text="+-5%"></asp:TextBox></td>
             
        <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    </table>
   
    <br />
  <div>
      <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
      <asp:Button ID="btnsave" runat="server" Text="Save" CssClass="button-link"  OnClick="btnsave_Click"/>
    <asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="button-link" />
  </div>