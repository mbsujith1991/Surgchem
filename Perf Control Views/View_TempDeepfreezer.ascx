<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_TempDeepfreezer.ascx.cs" Inherits="Perf_Control_Views_View_TempDeepfreezer" %>

 <div id="tempdeepfreezerdiv" runat="server">
         <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label34" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lbldeepfreezer" runat="server"></asp:Label></h4>
         </div>
    <div class="clear"></div>
       <div class="align_middle" style="font-weight:bold;width:6.27in;">
           <table  border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
               <tr>
            <th rowspan="2">
                Sl No
            </th>
            <th rowspan="2">Temp SET on DUT ºC</th>
            <th rowspan="2">Temp Display on DUT ºC</th>
            <th colspan="5">Temperature measured on STD specific Test Points(TPs)</th>
            <th rowspan="2">Mean Value</th>
            <th rowspan="2">Deviation</th>
            <th rowspan="2">Specified limit as per Mfr. Spec.</th>
            <th rowspan="2">Remarks</th>
        </tr>
       <tr>
        <th>TP1</th>
        <th>TP2</th>
        <th>TP3</th>
        <th>TP4</th>
        <th>TP5</th>
    </tr>

                 <tr id="tr_deepfreezer1" runat="server">
        <td>
            <asp:Label ID="lbldeep1" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbldeep2" runat="server"></asp:Label>
        </td>
             <td><asp:Label ID="lbldeep3" runat="server"></asp:Label></td>
        <td><asp:Label ID="lbldeep4" runat="server"></asp:Label></td>
        <td><asp:Label ID="lbldeep5" runat="server"></asp:Label></td>
        <td><asp:Label ID="lbldeep6" runat="server"></asp:Label></td>
        <td><asp:Label ID="lbldeep7" runat="server"></asp:Label></td>
        <td><asp:Label ID="lbldeep8" runat="server"></asp:Label></td>
        
        <td><asp:Label ID="lbldeep9" runat="server"></asp:Label></td>
        <td><asp:Label ID="lbldeep10" runat="server"></asp:Label></td>
        <td><asp:Label ID="lbldeep11" runat="server"></asp:Label></td>
             
        <td><asp:Label ID="lbldeep12" runat="server"></asp:Label></td>
    </tr>
           </table>
           </div>
     </div>
