<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_TempDigitalthermo.ascx.cs" Inherits="Perf_Control_Views_View_TempDigitalthermo" %>

<%--perf Temptest Autoclave  div starts--%>
        <div id="temp_digitaldiv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server"  Width="30px"></asp:Label>
                <asp:Label ID="lbltempdigital" runat="server"></asp:Label></h4>
         </div>
            <div class="clear"></div>
            <div class="align_middle" style="font-weight:bold;width:6.27in;">
                <table border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
                     <tr>
        <th rowspan="2">Sl No</th>
        <th rowspan="2">Temp set on STD(constant temperature water bath) ºc</th>
        <th colspan="5">Temperature measured on thermometer in ºc at specific test points (TPs)</th>
        <th rowspan="2">Mean Value</th>
        <th rowspan="2">Deviation</th>
        <th rowspan="2">Deviations specified limit as per mfr. Spec</th>
        <th rowspan="2">Remarks</th>
    </tr>
    <tr>
        <th>TP1</th>
        <th>TP2</th>
        <th>TP3</th>
        <th>TP4</th>
        <th>TP5</th>
    </tr>
                     <tr id="tr_tempdigthermo1" runat="server">
        <td>
            <asp:Label ID="lbltemp_digital1" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_digital2" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_digital3" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_digital4" runat="server"></asp:Label></td>
        <td>
           <asp:Label ID="lbltemp_digital5" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_digital6" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_digital7" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_digital8" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_digital9" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_digital10" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_digital11" runat="server"></asp:Label>
        </td>
    </tr>
                     <tr id="tr_tempdigthermo2" runat="server">
        <td>
            <asp:Label ID="lbltemp_digital12" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_digital13" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_digital14" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_digital15" runat="server"></asp:Label></td>
        <td>
           <asp:Label ID="lbltemp_digital16" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_digital17" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_digital18" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_digital19" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_digital20" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_digital21" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_digital22" runat="server"></asp:Label>
        </td>
    </tr>
                </table>
                </div>
            </div>