<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_PressureAutoclave132.ascx.cs" Inherits="Perf_Control_Views_View_PressureAutoclave132" %>
<div id="pressure_atclavediv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblpr_atclave" runat="server"></asp:Label></h4>
         </div>
            <div class="clear"></div>
            <div class="align_middle" style="font-weight:bold;width:6.27in;">
                <table border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
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
                    <tr id="tr_autoclave1" runat="server">
        <td>
            <asp:Label ID="lblpratclave1" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblpratclave2" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblpratclave3" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblpratclave4" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblpratclave5" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblpratclave6" runat="server"></asp:Label>
        </td>
        
    </tr>
                    </table>
                </div>
            </div>