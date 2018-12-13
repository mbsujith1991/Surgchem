<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_HumidityHygro.ascx.cs" Inherits="Perf_Control_Views_View_HumidityHygro" %>

<div id="humiditydiv" runat="server">
         <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label34" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblhumidity" runat="server"></asp:Label></h4>
         </div>
    <div class="clear"></div>
       <div class="align_middle" style="font-weight:bold;width:6.27in;">
           <table  border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
               <tr>
         <th rowspan="2">Sl No</th>
        <th colspan="2">Humidity Measured on</th>
        <th rowspan="2">Deviation</th>
        <th rowspan="2">Specified limit</th>
        <th rowspan="2">Remarks</th>
    </tr>
    <tr>
        <th>Standard</th>
        <th>DUT</th>
    </tr>
                 <tr id="tr_humidity1" runat="server">
                         <td><asp:Label ID="lblhumidity1" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblhumidity2" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblhumidity3" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblhumidity4" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblhumidity5" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblhumidity6" runat="server"></asp:Label></td>
                     </tr>
           </table>
           </div>
    </div>