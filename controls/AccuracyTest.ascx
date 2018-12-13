<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AccuracyTest.ascx.cs" Inherits="testfolder_AccuracyTest" %>
<style type="text/css">
    .widthclass {
    float:right;
    }
    .widthdiv {
    width:auto;
    }
</style>
<style type="text/css">
    
</style>
<asp:HiddenField ID="perf_valueHidden" runat="server" />
<asp:HiddenField ID="perf_namehidden" runat="server" />
<asp:HiddenField ID="perfvalueid_hidden" runat="server" />

Accuracy test
<div class="widthdiv">
    <table  border="1" cellspacing="0" cellpadding="0" style="height:30px; text-align:center;font-size:8pt">
        <tr>
    <td>Sl No</td>
    <td>Value Set On DUT in ml/hr</td>
    <td>Instant values Measured on STD in ml/hr</td>
    <td>Mean Value</td>
    <td>Deviation in ml/hr</td>
    <td>Deviation in %</td>
    <td>General Acceptable Spec. Limit ( ± 5% ml/hr)</td>
    <td>Remarks</td>
  </tr>
    </table>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server">
                
            </asp:PlaceHolder>
             
        </ContentTemplate>            
    </asp:UpdatePanel>
    <br />
<asp:Button ID="btnadd" runat="server" Text="Add" CssClass="widthclass button-link"  OnClick="btnadd_Click"/>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="widthclass button-link" />
    <asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="widthclass button-link" OnClick="btncancel_Click" />
    </div>