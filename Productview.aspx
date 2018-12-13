<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Productview.aspx.cs" Inherits="Productview" %>


<%@ Register Src="~/controls/Productviewforcustomer.ascx" TagPrefix="uc1" TagName="Productviewforcustomer" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:HiddenField ID="utypeid_hidden" runat="server" />

    <div>
        <asp:Button ID="btnviewreport" runat="server" Text="View Report" CssClass="button"
             OnClick="btnviewreport_Click" Font-Size="Small" BackColor="#D8D8D8" ForeColor="Black"/>&nbsp;
         <asp:Button ID="btnprodview" runat="server" Text="Product View" CssClass="button" Font-Size="Small" BackColor="#003366"
             OnClick="btnprodview_Click" ForeColor="Yellow"/>&nbsp;
         
        <asp:Button ID="btnaddtestcases" runat="server" Text="Add Calibration Test" CssClass="button"
             OnClick="btnaddtestcases_Click" Font-Size="Small" BackColor="#D8D8D8" ForeColor="Black"/>&nbsp;
         <asp:Button ID="btnprevent" runat="server" Text="Preventive Maintenance" CssClass="button"
             OnClick="btnprevent_Click" Font-Size="Small" BackColor="#D8D8D8" ForeColor="Black"/>&nbsp;
         
     </div>
   <div class="clear"></div>
    <div style="width:100%;background-color:white;">
        <uc1:Productviewforcustomer runat="server" ID="Productviewforcustomer" />
    </div>
    <div class="clear"></div>
</asp:Content>

