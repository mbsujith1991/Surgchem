<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_Temptest_autoclave.ascx.cs" Inherits="Perf_Control_Views_View_Temptest_autoclave" %>

<%--perf Temptest Autoclave  div starts--%>
        <div id="temp_autoclavediv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server"  Width="30px"></asp:Label>
                <asp:Label ID="lbltempautoclave" runat="server"></asp:Label></h4>
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

                     <tr id="tr_tempautoclave1" runat="server">
        <td>
            <asp:Label ID="lbltemp_auto1" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_auto2" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_auto3" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_auto4" runat="server"></asp:Label></td>
        <td>
           <asp:Label ID="lbltemp_auto5" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_auto6" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_auto7" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_auto8" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_auto9" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_auto10" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_auto11" runat="server"></asp:Label>
        </td>
    </tr>
                     <tr id="tr_tempautoclave2" runat="server">
        <td>
            <asp:Label ID="lbltemp_auto12" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_auto13" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_auto14" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_auto15" runat="server"></asp:Label></td>
        <td>
           <asp:Label ID="lbltemp_auto16" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_auto17" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_auto18" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_auto19" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_auto20" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_auto21" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_auto22" runat="server"></asp:Label>
        </td>
    </tr>
                     <tr id="tr_tempautoclave3" runat="server">
        <td>
            <asp:Label ID="lbltemp_auto23" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_auto24" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_auto25" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_auto26" runat="server"></asp:Label></td>
        <td>
           <asp:Label ID="lbltemp_auto27" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_auto28" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_auto29" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_auto30" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_auto31" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_auto32" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_auto33" runat="server"></asp:Label>
        </td>
    </tr>
                </table>
                </div>
            </div>