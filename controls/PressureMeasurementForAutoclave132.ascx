<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PressureMeasurementForAutoclave132.ascx.cs" Inherits="controls_PressureMeasurementForAutoclave132" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>
<asp:HiddenField ID="pres_autoclave_hidden" runat="server" />
<h3>Pressure Measurement At 132 ºC For Autoclave</h3>

<table style="width:100%;" border="1">
    <tr>
        <th rowspan="2">Sl No</th>
        <th colspan="2">Pressure Measured On</th>
        <th rowspan="2">DUT requirement</th>
        <th rowspan="2">Specified limit</th>
        <th rowspan="2">Remarks</th>
    </tr>
    <tr>
        <th>STANDARD</th>
        <th>DUT </th>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtslno1" runat="server" Text="1" CssClass="textbox"></asp:TextBox>
        </td>
                <td>
            <asp:TextBox ID="txtstd1" runat="server" Text="1.4 kg/cm2" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtdutmeasure1" runat="server" Text="1.4 kg/cm2" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdutreq1" runat="server" Text="1.4 kg/cm2" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtspec1" runat="server" Text="±5%" CssClass="textbox"></asp:TextBox>
        </td>
         <td>
            <asp:TextBox ID="txtrem1" runat="server" Text="PASS" CssClass="textbox"></asp:TextBox>
        </td>
        
    </tr>
   </table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;

    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>