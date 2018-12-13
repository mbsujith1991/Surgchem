<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_ECG_Deferibrillator.ascx.cs" Inherits="Perf_Control_Views_View_ECG_Deferibrillator" %>

  <div id="ecgdiv" runat="server">
        <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label31" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblperformancename" runat="server"></asp:Label></h4>
         </div>

    <div class="clear"></div>
       <div class="align_middle" style="font-weight:bold;width:6.27in">
           <table  border="1" cellspacing="0" cellpadding="0" style="height:30px;font-size:8pt;width:100%;text-align:center;">
        <tr>
            <td style="width:50px;">Sl No</td>
    <td style="width:100px;">Parameter</td>
    <td style="width:100px;">Value set on STD</td>
    <td style="width:100px;">Value measured on DUT</td>
    <td style="width:100px;">Deviation(bpm)</td>
    <td style="width:100px;">Specified limit as per mfr. specification</td>
    <td style="width:90px;">Remarks</td>
        </tr>
               <tr id="ecg_1" runat="server">
                   <td style="width:50px;">
                       <asp:Label ID="ecg1" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:100px;">
                       <asp:Label ID="ecg2" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:100px;">
                       <asp:Label ID="ecg3" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:100px;">
                       <asp:Label ID="ecg4" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:100px;">
                       <asp:Label ID="ecg5" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:100px;">
                       <asp:Label ID="ecg6" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:90px;">
                       <asp:Label ID="ecg7" runat="server" Text=""></asp:Label>
                   </td>
               </tr>
               <tr id="ecg_2" runat="server">
                    <td style="width:50px;">
                       <asp:Label ID="ecg8" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:100px;">
                       <asp:Label ID="ecg9" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:100px;">
                       <asp:Label ID="ecg10" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:100px;">
                       <asp:Label ID="ecg11" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:100px;">
                       <asp:Label ID="ecg12" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:100px;">
                       <asp:Label ID="ecg13" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:90px;">
                       <asp:Label ID="ecg14" runat="server" Text=""></asp:Label>
                   </td>
               </tr>
               <tr id="ecg_3" runat="server">
                    <td style="width:50px;">
                       <asp:Label ID="ecg15" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:100px;">
                       <asp:Label ID="ecg16" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:100px;">
                       <asp:Label ID="ecg17" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:100px;">
                       <asp:Label ID="ecg18" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:100px;">
                       <asp:Label ID="ecg19" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:100px;">
                       <asp:Label ID="ecg20" runat="server" Text=""></asp:Label>
                   </td>
                   <td style="width:90px;">
                       <asp:Label ID="ecg21" runat="server" Text=""></asp:Label>
                   </td>
               </tr>
              
    </table>
       </div>
      
            </div>