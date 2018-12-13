<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_Bipolarmode.ascx.cs" Inherits="Perf_Control_Views_View_Bipolarmode" %>

 <div id="bipolardiv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label39" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblbipolarmode" runat="server"></asp:Label></h4>
         </div>
            <div class="clear"></div>
       <div class="align_middle" style="font-weight:bold;width:6.27in;">
           <table border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
             
    <tr>
        <th width="10%">Mode</th>
        <th width="10%">Value as Set on DUT( W )</th>
        <th width="8%">Standard Load resistance( Ω )</th>
        <th width="8%">Average Value as on STD( W )</th>
        <th width="8%">Deviation in Watts</th>
        <th width="10%">Allowed Deviation ±15%</th>
        <th width="12%">Remarks</th>
    </tr>
               <tr id="tr_bipolar_1" runat="server">
                   <td><asp:Label ID="lblbipol1" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol2" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol3" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol4" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol5" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol6" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol7" runat="server"></asp:Label></td>
               </tr>
               <tr id="tr_bipolar_2" runat="server">
                   <td><asp:Label ID="lblbipol8" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol9" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol10" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol11" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol12" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol13" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol14" runat="server"></asp:Label></td>
               </tr>
               <tr id="tr_bipolar_3" runat="server">
                   <td><asp:Label ID="lblbipol15" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol16" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol17" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol18" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol19" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol20" runat="server"></asp:Label></td>
                   <td><asp:Label ID="lblbipol21" runat="server"></asp:Label></td>
               </tr>
           </table>
       </div>
        </div>