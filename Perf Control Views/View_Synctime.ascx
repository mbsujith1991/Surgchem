<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_Synctime.ascx.cs" Inherits="Perf_Control_Views_View_Synctime" %>

<%--perf sync div starts--%>
        <div id="syntimediv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server"  Width="30px"></asp:Label>
                <asp:Label ID="lblsynctime" runat="server"></asp:Label></h4>
         </div>
            <div class="clear"></div>
            <div class="align_middle" style="font-weight:bold;width:6.27in;">
                <table border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
                    <tr>
        <th rowspan="2" width="10%">Delivered Energy (J)</th>
        <th width="20%">Sync Time</th>
        <th rowspan="2">Remarks</th>
    </tr>
    <tr>
        <th>
            R Wave (msec)*</th>
        
    </tr>
                    <tr id="tr_syn1" runat="server">
        <td>
            <asp:Label ID="lblsyn1" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblsyn2" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblsyn3" runat="server" ></asp:Label></td>
       
    </tr>
    <tr id="tr_syn2" runat="server">
        <td><asp:Label ID="lblsyn5" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblsyn6" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblsyn7" runat="server" ></asp:Label></td>
        
    </tr>
    <tr id="tr_syn3" runat="server">
        <td><asp:Label ID="lblsyn9" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblsyn10" runat="server" ></asp:Label></td>
        <td><asp:Label ID="lblsyn11" runat="server" ></asp:Label></td>
       
    </tr>
                </table>
                </div>
            </div>