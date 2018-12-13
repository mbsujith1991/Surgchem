<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_Tempmeasure_middlechamber.ascx.cs" Inherits="Perf_Control_Views_View_Tempmeasure_middlechamber" %>

<%-- Temptest Freezmiddlechamberer  div starts--%>
        <div id="temp_middlechamberdiv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server"  Width="30px"></asp:Label>
                <asp:Label ID="lbltempmiddlechamber" runat="server"></asp:Label></h4>
         </div>
            <div class="clear"></div>
            <div class="align_middle" style="font-weight:bold;width:6.27in;">
                <table border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
                     <tr>
        <th rowspan="2">Sl No</th>
        <th colspan="5">Temperature Measured on STD ºC at Specified Test Points (TPs)</th>
        <th rowspan="2">Mean Value</th>
        <th rowspan="2">Temp Range on DUT in ºC</th>
        <th rowspan="2">Remarks</th>
    </tr>
    <tr>
        <th>TP1</th>
        <th>TP2</th>
        <th>TP3</th>
        <th>TP4</th>
        <th>TP5</th>
    </tr>
                    <tr id="tr_tempmiddlechamber1" runat="server">
        <td>
            <asp:Label ID="lbltemp_middlechamber1" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_middlechamber2" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_middlechamber3" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_middlechamber4" runat="server"></asp:Label></td>
        <td>
           <asp:Label ID="lbltemp_middlechamber5" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_middlechamber6" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_middlechamber7" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_middlechamber8" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_middlechamber9" runat="server"></asp:Label>
        </td>
       
    </tr>
                    </table>
                </div>
            </div>