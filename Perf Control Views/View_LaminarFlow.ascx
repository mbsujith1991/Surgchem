<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_LaminarFlow.ascx.cs" Inherits="Perf_Control_Views_View_LaminarFlow" %>

<div id="flowdiv" runat="server">
         <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label34" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblflow" runat="server"></asp:Label></h4>
         </div>
    <div class="clear"></div>
       <div class="align_middle" style="font-weight:bold;width:6.27in;">
           <table  border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
               <tr id="tr_flow1" runat="server">
        <th>Inside Design condition </th>
        <td>
            <asp:Label ID="txtlam1" runat="server" CssClass="textbox"></asp:Label>
        </td>
    </tr>
    <tr id="tr_flow2" runat="server">
        <th>Area of Operation Theatre</th>
        <td>
            <asp:Label ID="txtlam2" runat="server" CssClass="textbox"></asp:Label>
        </td>
    </tr>
    <tr id="tr_flow3" runat="server">
        <th>
            Required Tonnage of AHU
        </th>
        <td>
            <asp:Label ID="txtlam3" runat="server" CssClass="textbox"></asp:Label>
        </td>
    </tr>
    <tr id="tr_flow4" runat="server">
        <th>
            Air Quantity
        </th>
        <td>
            <asp:Label ID="txtlam4" runat="server" CssClass="textbox"></asp:Label>
        </td>
    </tr>
    <tr id="tr_flow5" runat="server">
        <th>
            Static Pressure
        </th>
        <td>
            <asp:Label ID="txtlam5" runat="server" CssClass="textbox"></asp:Label>
        </td>
    </tr>
    <tr id="tr_flow6" runat="server">
        <th>
            Air Changes calculated
        </th>
        <td>
            <asp:Label ID="txtlam6" runat="server" CssClass="textbox"></asp:Label>
        </td>
    </tr>
    <tr id="tr_flow7" runat="server">
        <th>
            Fresh air changes calculated
        </th>
        <td>
            <asp:Label ID="txtlam7" runat="server" CssClass="textbox"></asp:Label>
        </td>
    </tr>
           </table>
           </div>
    </div>