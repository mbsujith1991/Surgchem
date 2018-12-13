<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_Luxmeasure.ascx.cs" Inherits="Perf_Control_Views_View_Luxmeasure" %>

<style type="text/css">
    .auto-style1 {
        height: 15px;
    }
</style>

<div id="luxmeasurediv" runat="server">
         <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label34" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblluxmeasure" runat="server"></asp:Label></h4>
         </div>
    <div class="clear"></div>
       <div class="align_middle" style="font-weight:bold;width:6.27in;">
           <table  border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
               <tr>
        <th rowspan="2">Sl No</th>
        <th colspan="3">Value Measured at 1 m away from DUT at specified Test Points(Lux)</th>
        <th rowspan="2">Specified Limit as per Mfr. Spec.(Lux)</th>
        <th rowspan="2">Remarks</th>
    </tr>
    <tr>
        <th class="auto-style1">TP1</th>
        <th class="auto-style1">TP2</th>
        <th class="auto-style1">TP3</th>
    </tr>
                <tr id="tr_luxmeasure" runat="server">
        <td>
            <asp:Label ID="lbllux1" runat="server" ></asp:Label></td>
       
        <td><asp:Label ID="lbllux2" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lbllux3" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lbllux4" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lbllux5" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lbllux6" runat="server" ></asp:Label></td>
    </tr>
           </table>
           </div>
    </div>