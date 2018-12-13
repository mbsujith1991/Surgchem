<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_BloodPressure.ascx.cs" Inherits="Perf_Control_Views_View_BloodPressure" %>
 <div id="bloodpressurediv" runat="server">
         <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label33" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblperformancename2" runat="server"></asp:Label></h4>
         </div>
    <div class="clear"></div>
       <div class="align_middle" style="font-weight:bold;width:6.27in;">
           <table  border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;width:100%;font-size:8pt;">
        <tr>
            <td>Sl No</td>
    <td colspan="3" style="width:150px;">Reading set on std(mmHg)</td>
    <td colspan="3" style="width:120px;height:30px;">Reading measured on  DUT(mmHg)</td>
    <td colspan="3" style="width:100px;">Deviation(bpm)</td>
    <td colspan="3" style="width:150px;">Specified limit as per mfr specification (mm.Hg) </td>
    <td rowspan="2">Remarks</td>
        </tr>
        <tr>
            <td>
                Test
            </td>
            <td>Syst</td>
            <td>Dyst</td>
            <td>MAP</td>
            <td>Syst</td>
            <td>Dyst</td>
            <td>MAP</td>
            <td>Syst</td>
            <td>Dyst</td>
            <td>MAP</td>
            <td>Syst</td>
            <td>Dyst</td>
            <td>MAP</td>
        </tr>
               <tr id="bp_1" runat="server">
                   <td>
                       <asp:Label ID="lbbp1" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp2" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp3" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp4" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp5" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp6" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp7" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp8" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp9" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp10" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp11" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp12" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp13" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp14" runat="server" Text=""></asp:Label>
                   </td>
               </tr>
                <tr id="bp_2" runat="server">
                   <td>
                       <asp:Label ID="lbbp15" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp16" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp17" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp18" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp19" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp20" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp21" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp22" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp23" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp24" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp25" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp26" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp27" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbbp28" runat="server" Text=""></asp:Label>
                   </td>
               </tr>
              
    </table>
          
       </div>
   </div>