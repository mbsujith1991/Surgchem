<%@ Page Language="C#" AutoEventWireup="true" CodeFile="perf_table.aspx.cs" Inherits="testfolder_perf_table" %>

<%--<%@ Register Src="~/testfolder/SpO2usercontrol.ascx" TagPrefix="uc1" TagName="SpO2usercontrol" %>
<%@ Register Src="~/testfolder/AccuracyTest.ascx" TagPrefix="uc1" TagName="AccuracyTest" %>
<%@ Register Src="~/testfolder/Pressure.ascx" TagPrefix="uc1" TagName="Pressure" %>
<%@ Register Src="~/testfolder/Volume.ascx" TagPrefix="uc1" TagName="Volume" %>
<%@ Register Src="~/testfolder/ECG.ascx" TagPrefix="uc1" TagName="ECG" %>
<%@ Register Src="~/testfolder/BloodPressure.ascx" TagPrefix="uc1" TagName="BloodPressure" %>--%>







<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
               <table  border="1" cellspacing="0" cellpadding="0" style="height:30px;font-size:8pt;width:100%;">
        <tr>
            <td  style="width:50px;">Sl No</td>
    <td colspan="2" style="width:180px;">Parameter</td>
    <td colspan="2">Value set on STD</td>
    <td colspan="2">Value measured on DUT</td>
    <td colspan="2">Deviation(bpm)</td>
    <td colspan="2">Specified limit as per mfr. specification</td>
    <td >Remarks</td>
        </tr>
    </table>
            </HeaderTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%#Eval("Perf_Value") %>' Width="60px"></asp:Label>
                
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
