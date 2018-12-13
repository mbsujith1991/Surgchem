<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_Temp_Hygrometer.ascx.cs" Inherits="Perf_Control_Views_View_Temp_Hygrometer" %>

<div id="temphygrodiv" runat="server">
         <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label34" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lbltemphygro" runat="server"></asp:Label></h4>
         </div>
    <div class="clear"></div>
       <div class="align_middle" style="font-weight:bold;width:6.27in;">
           <table  border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
               <tr>
         <th rowspan="2">Sl No</th>
        <th colspan="2">Temperature Measured on</th>
        <th rowspan="2">Deviation</th>
        <th rowspan="2">Specified limit</th>
        <th rowspan="2">Remarks</th>
    </tr>
    <tr>
        <th>Standard</th>
        <th>DUT(DISPLAY)</th>
    </tr>
                 <tr id="tr_temphygro1" runat="server">
                         <td><asp:Label ID="lbltemphygro1" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lbltemphygro2" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lbltemphygro3" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lbltemphygro4" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lbltemphygro5" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lbltemphygro6" runat="server"></asp:Label></td>
                     </tr>
           </table>
           </div>
    </div>