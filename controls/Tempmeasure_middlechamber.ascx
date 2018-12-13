<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Tempmeasure_middlechamber.ascx.cs" Inherits="controls_Tempmeasure_middlechamber" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>

<asp:HiddenField ID="temp_middle" runat="server" />
<h3>Temperature Measurement of Middle Chamber</h3>

<table style="width:100%;" border="1">
    <tr>
        <th rowspan="2">Sl No</th>
        <th colspan="5">Temperature Measured on STD ºC at Specified Test Points (TPs)</th>
        <th rowspan="2">Mean Value</th>
        <th rowspan="2">Temp Range on DUT in ºC</th>
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
        
        <td><asp:TextBox ID="txttp1_1" runat="server" CssClass="textbox" Text="7.7"></asp:TextBox></td>
        <td><asp:TextBox ID="txttp2_1" runat="server" CssClass="textbox" Text="7.6"></asp:TextBox></td>
        <td><asp:TextBox ID="txttp3_1" runat="server" CssClass="textbox" Text="8.5"></asp:TextBox></td>
        <td><asp:TextBox ID="txttp4_1" runat="server" CssClass="textbox" Text="6.5"></asp:TextBox></td>
        <td><asp:TextBox ID="txttp5_1" runat="server" CssClass="textbox" Text="7.7"></asp:TextBox></td>
        
        <td><asp:TextBox ID="txtmean1" runat="server" CssClass="textbox" Text="7.66"></asp:TextBox></td>
        
        <td><asp:TextBox ID="txtspec1" runat="server" CssClass="textbox" Text="2 ºC to8 ºC"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    </table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link" />
</div>