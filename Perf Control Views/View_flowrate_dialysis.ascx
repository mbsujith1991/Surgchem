﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_flowrate_dialysis.ascx.cs" Inherits="Perf_Control_Views_View_flowrate_dialysis" %>

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
                <th>Value set on DUT</th>
                <th colspan="3">Instant Values Measured on Standard in ml/min</th>
                <th>Mean Value</th>
                <th>Deviation(±5%)</th>
                <th>Remarks</th>
             </tr>
                <tr id="tr_flow1" runat="server">
                         <td><asp:Label ID="lblflow1" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow2" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow3" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow4" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow5" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow6" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblflow7" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblflow8" runat="server"></asp:Label></td>
                     </tr>
                     <tr id="tr_flow2" runat="server">
                         <td><asp:Label ID="lblflow9" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow10" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow11" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow12" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow13" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow14" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow15" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow16" runat="server"></asp:Label></td>
                     </tr>
                    <tr id="tr_flow3" runat="server">
                         <td><asp:Label ID="lblflow17" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow18" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow19" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow20" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow21" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow22" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow23" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblflow24" runat="server"></asp:Label></td>
                     </tr>
                     
           </table>
           </div>
    </div>