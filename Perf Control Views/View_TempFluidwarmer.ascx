<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_TempFluidwarmer.ascx.cs" Inherits="Perf_Control_Views_View_TempFluidwarmer" %>

<%--perf Temp measure fluid warmer  div starts--%>
        <div id="fluidwarmerdiv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server"  Width="30px"></asp:Label>
                <asp:Label ID="lblfluid" runat="server"></asp:Label></h4>
         </div>
            <div class="clear"></div>
            <div class="align_middle" style="font-weight:bold;width:6.27in;">
                <table border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
                    <tr>
        <th rowspan="2">Sl No</th>
        <th rowspan="2">Temp Display on DUT ºC</th>
        <th colspan="5">Temperature measured on STD specific Test Points(TPs)</th>
        <th rowspan="2">Mean Value</th>
        <th rowspan="2">Deviation</th>
        <th rowspan="2">Specified Limit as per Mfr. Spec.</th>
        <th rowspan="2">Remarks</th>
    </tr>
    <tr>
        <th>TP1</th>
        <th>TP2</th>
        <th>TP3</th>
        <th>TP4</th>
        <th>TP5</th>
    </tr>
                     <tr id="tr_tempfluid1" runat="server">
        <td>
            <asp:Label ID="lbltemp_fluid1" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_fluid2" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_fluid3" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_fluid4" runat="server"></asp:Label></td>
        <td>
           <asp:Label ID="lbltemp_fluid5" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_fluid6" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_fluid7" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_fluid8" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_fluid9" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_fluid10" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_fluid11" runat="server"></asp:Label>
        </td>
    </tr>
                     <tr id="tr_tempfluid2" runat="server">
        <td>
            <asp:Label ID="lbltemp_fluid12" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_fluid13" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_fluid14" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_fluid15" runat="server"></asp:Label></td>
        <td>
           <asp:Label ID="lbltemp_fluid16" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_fluid17" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_fluid18" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_fluid19" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_fluid20" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_fluid21" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_fluid22" runat="server"></asp:Label>
        </td>
    </tr>
                     <tr id="tr_tempfluid3" runat="server">
        <td>
            <asp:Label ID="lbltemp_fluid23" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_fluid24" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_fluid25" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_fluid26" runat="server"></asp:Label></td>
        <td>
           <asp:Label ID="lbltemp_fluid27" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_fluid28" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_fluid29" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_fluid30" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_fluid31" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_fluid32" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_fluid33" runat="server"></asp:Label>
        </td>
    </tr>
                </table>
                </div>
            </div>