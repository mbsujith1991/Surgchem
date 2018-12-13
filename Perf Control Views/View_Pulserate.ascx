<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_Pulserate.ascx.cs" Inherits="Perf_Control_Views_View_Pulserate" %>

<div id="pulseratediv" runat="server">
         <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label34" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblpulseratepacemaker" runat="server"></asp:Label></h4>
         </div>
    <div class="clear"></div>
       <div class="align_middle" style="font-weight:bold;width:6.27in;">
           <table  border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
               <tr>
            <td>Sl No</td>
    <td>Parameter</td>
    <td>Value set on DUT (PPM)</td>
    <td>Value measured on STD (PPM)</td>
    <td>Deviation(PPM)</td>
    <td>Specified limit as per mfr. Specification(+/-5%)</td>
    <td>Remarks</td>
        </tr>
               <tr id="tr_pulserate1" runat="server">
            <td>
                <asp:Label ID="lblpulserate1" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulserate2" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulserate3" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulserate4" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulserate5" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulserate6" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulserate7" runat="server" ></asp:Label></td>
        </tr>
                <tr id="tr_pulserate2" runat="server">
            <td>
                <asp:Label ID="lblpulserate8" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulserate9" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulserate10" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulserate11" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulserate12" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulserate13" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulserate14" runat="server" ></asp:Label></td>
        </tr>
           </table>
           </div>
    </div>