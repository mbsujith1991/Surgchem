<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Add_Hospital_admin.aspx.cs" Inherits="Add_Hospital_admin" %>

<%@ Register Src="~/controls/AddHospital.ascx" TagPrefix="uc1" TagName="AddHospital" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <uc1:AddHospital runat="server" ID="AddHospital" />
                  
    
</asp:Content>

