<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_TidalVolume.ascx.cs" Inherits="Perf_Control_Views_View_TidalVolume" %>
<div id="flowdiv" runat="server">
         <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label34" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblflow" runat="server"></asp:Label></h4>
         </div>
    <div class="clear"></div>
       <div class="align_middle" style="font-weight:bold;width:6.27in;">
           <table  border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
               <tr>
        <th>Sl No</th>
        <th>Value as Set on DUT (ml)</th>
        <th>Average Value as on STD (ml)</th>
        <th>Deviation</th>
        <th>Allowed Deviation</th>
        <th>Remarks</th>
    </tr>
                <tr id="tr_flow1" runat="server">
                         <td><asp:Label ID="lblflow1" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow2" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow3" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow4" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow5" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow6" runat="server"></asp:Label></td>
                     </tr>
                     <tr id="tr_flow2" runat="server">
                         <td><asp:Label ID="lblflow7" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow8" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow9" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow10" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow11" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow12" runat="server"></asp:Label></td>
                     </tr>
                    
           </table>
           </div>
    </div>