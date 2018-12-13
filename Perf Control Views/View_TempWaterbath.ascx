<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_TempWaterbath.ascx.cs" Inherits="Perf_Control_Views_View_TempWaterbath" %>

<%--temp waterbath div starts--%>
        <div id="temp_waterdiv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server"  Width="30px"></asp:Label>
                <asp:Label ID="lbltempwater" runat="server"></asp:Label></h4>
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
                     <tr id="tr_tempwater1" runat="server">
        <td>
            <asp:Label ID="lblwater1" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lblwater2" runat="server" ></asp:Label>
        </td>
        <td><asp:Label ID="lblwater3" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater4" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater5" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater6" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater7" runat="server"></asp:Label></td>
        
        <td><asp:Label ID="lblwater8" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater9" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater10" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater11" runat="server" ></asp:Label></td>
    </tr>
     <tr id="tr_tempwater2" runat="server">
        <td>
            <asp:Label ID="lblwater12" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lblwater13" runat="server" ></asp:Label>
        </td>
        <td><asp:Label ID="lblwater14" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater15" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater16" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater17" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater18" runat="server"></asp:Label></td>
        
        <td><asp:Label ID="lblwater19" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater20" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater21" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater22" runat="server" ></asp:Label></td>
    </tr>
     <tr id="tr_tempwater3" runat="server">
        <td>
            <asp:Label ID="lblwater23" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lblwater24" runat="server" ></asp:Label>
        </td>
        <td><asp:Label ID="lblwater25" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater26" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater27" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater28" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater29" runat="server"></asp:Label></td>
        
        <td><asp:Label ID="lblwater30" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater31" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater32" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblwater33" runat="server" ></asp:Label></td>
    </tr>
                </table>
                </div>

        </div>