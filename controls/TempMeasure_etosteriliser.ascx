﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TempMeasure_etosteriliser.ascx.cs" Inherits="controls_TempMeasure_etosteriliser" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>

<asp:HiddenField ID="tempmeas_digthermo_hidden" runat="server" />
<h3>Temperature Measurement of ETO Steriliser</h3>

<table style="width:100%;" border="1">
    <tr>
        <th rowspan="2">Sl No</th>
        <th rowspan="2">Temp set on DUT ºc</th>
        <th rowspan="2">Temp Display on DUT ºC</th>
        <th colspan="5">Temperature measured on thermometer in ºc at specific test points (TPs)</th>
        <th rowspan="2">Mean Value</th>
        <th rowspan="2">Deviation</th>
        <th rowspan="2">Deviations specified limit as per mfr. Spec</th>
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
            <asp:TextBox ID="txtdut1" runat="server" CssClass="textbox" Text="42"></asp:TextBox>
        </td>
        <td><asp:TextBox ID="txtdutdisp" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
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
    <asp:Button ID="btnsave" runat="server" Text="Save" CssClass="button-link" OnClick="btnsave_Click"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="button-link" OnClick="btncancel_Click" />
</div>