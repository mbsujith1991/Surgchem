<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_Perf_micropipette.ascx.cs" Inherits="Perf_Control_Views_View_Perf_micropipette" %>

<%--perf Holtermachine  div starts--%>
        <div id="perfholterdiv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server"  Width="30px"></asp:Label>
                <asp:Label ID="lblperfholter" runat="server"></asp:Label></h4>
         </div>
            <div class="clear"></div>
            <div class="align_middle" style="font-weight:bold;width:6.27in;">
                <table border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
                     <tr>
       <th width="5%">Sl No</th>
        <th width="30%">Standard Volume (STD) in ul</th>
        <th colspan="3">Measured Volume on DUT as per Electronic Balance with the  Z factor  [Volume ( ml or ul ) = Weight ( mg or ug ) x Z]</th>
        <th>Mean Value</th>
        <th>Deviation</th>
        <th>Specified Limit as per Mfr’s Spec</th>
        <th>Remarks</th>
    </tr>
                     <tr id="tr_perfholter1" runat="server">
        <td>
            <asp:Label ID="lblperf_holter1" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lblperf_holter2" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblperf_holter3_1" runat="server"></asp:Label>

        </td>
      
        <td>
            <asp:Label ID="lblperf_holter3_2" runat="server"></asp:Label>
        </td>
        <td>
           
            <asp:Label ID="lblperf_holter3_3" runat="server"></asp:Label>

        </td>
        <td>
          
            <asp:Label ID="lblperf_holter3_4" runat="server"></asp:Label>

        </td>
        <td>
            <asp:Label ID="lblperf_holter4" runat="server"></asp:Label>

        </td>
        <td>
           <asp:Label ID="lblperf_holter5" runat="server"></asp:Label>

        </td>
        <td>
            <asp:Label ID="lblperf_holter6" runat="server"></asp:Label>

        </td>
       
    </tr>
                     <tr id="tr_perfholter2" runat="server">
        <td>
            <asp:Label ID="lblperf_holter7" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lblperf_holter8" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblperf_holter9_1" runat="server"></asp:Label>

        </td>
    
        <td>
            <asp:Label ID="lblperf_holter9_2" runat="server"></asp:Label>

        </td>
        <td>
            
            <asp:Label ID="lblperf_holter9_3" runat="server"></asp:Label>

        </td>
        <td>
            
            <asp:Label ID="lblperf_holter9_4" runat="server"></asp:Label>

        </td>
        <td>
            <asp:Label ID="lblperf_holter10" runat="server"></asp:Label>

        </td>
        <td>
           <asp:Label ID="lblperf_holter11" runat="server"></asp:Label>

        </td>
        <td>
            <asp:Label ID="lblperf_holter12" runat="server"></asp:Label>

        </td>
       
    </tr>
                </table>
                </div>
            </div>