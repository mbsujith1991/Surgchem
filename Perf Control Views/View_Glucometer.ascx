<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_Glucometer.ascx.cs" Inherits="Perf_Control_Views_View_Glucometer" %>

<div id="gludiv" runat="server">
         <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label34" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblglu" runat="server"></asp:Label></h4>
         </div>
    <div class="clear"></div>
       <div class="align_middle" style="font-weight:bold;width:6.27in;">
           <table  border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
               <tr>
        <th>Sl No</th>
        <th>CONTROL SOLUTION RANGE(72-76 mg/dl)</th>
        <th>Remarks</th>
        
    </tr>
                <tr id="tr_glu1" runat="server">
                         <td><asp:Label ID="lblglu1" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblglu2" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblglu3" runat="server"></asp:Label></td>
                         
                     </tr>
                     
           </table>
           </div>
    </div>