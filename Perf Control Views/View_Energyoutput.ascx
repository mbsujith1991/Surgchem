<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_Energyoutput.ascx.cs" Inherits="Perf_Control_Views_View_Energyoutput" %>

 <div id="energyoutputdiv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label40" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblenergyoutput" runat="server"></asp:Label></h4>
         </div>
             <div class="clear"></div>
             <div class="align_middle" style="font-weight:bold;width:6.27in;">
                 <table border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
                     <tr>
        <th>Sl No</th>
        <th>Value Set on DUT (J)</th>
        <th>Value Measured on STD (J)</th>
        <th>Deviation From the Set Value (J)</th>
        <th>Allowed Deviation (J)</th>
        <th>Remarks</th>
    </tr>
                     <tr id="tr_energy1" runat="server">
                         <td><asp:Label ID="lblenout1" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout2" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout3" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout4" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout5" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout6" runat="server"></asp:Label></td>
                     </tr>
                     <tr id="tr_energy2" runat="server">
                         <td><asp:Label ID="lblenout7" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout8" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout9" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout10" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout11" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout12" runat="server"></asp:Label></td>
                     </tr>
                     <tr id="tr_energy3" runat="server">
                         <td><asp:Label ID="lblenout13" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout14" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout15" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout16" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout17" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout18" runat="server"></asp:Label></td>
                     </tr>
                     <tr id="tr_energy4" runat="server">
                         <td><asp:Label ID="lblenout19" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout20" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout21" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout22" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout23" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblenout24" runat="server"></asp:Label></td>
                     </tr>
                 </table>
             </div>
             </div>