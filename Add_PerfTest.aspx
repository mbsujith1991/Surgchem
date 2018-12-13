<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Add_PerfTest.aspx.cs" Inherits="Add_PerfTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Dynamically create textboxes in ASP.Net</title>
    <link href="Styles_ecom/ecom.css" rel="stylesheet" />
    <link href="Styles_ecom/bomtv.css" rel="stylesheet" />
    <style type="text/css">
  .text{
      
       width:200px;
        } 
</style>
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     
   
        <div class="content_box align_left shadow round_corner5 colwidth45">
            
            <table cellpadding="5" cellspacing="5">
              <tr>
                  <th colspan="2">Add Performance Test and Categories</th>
                 
              </tr>
                <tr>
                    <td><span style="color:red;">*</span>Enter Performance Test Name</td>
                    <td><asp:TextBox ID="txtperfname" CssClass="text" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        Click Add Button to Enter Performance Test  Categories
                    </td>
                    <td width="200px">
                        
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server">
                
            </asp:PlaceHolder>
             
        </ContentTemplate>            
    </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnCreate" runat="server" Text="Add Category" OnClick="btnCreate_Click" CssClass="button-link" />
                        &nbsp;<asp:Button ID="btnRead" runat="server" Text="Save" OnClick="btnRead_Click" CssClass="button-link" />
                    </td>
                </tr>
            </table>
          
      
            </div>
    
     
    <div class="content_box align_left shadow round_corner5 colwidth45">
        <table cellpadding="5" cellsapcing="5">
            <tr>
                <th colspan="2">Add Performance Test Sub Categories</th>
            </tr>
            <tr>
                <td>Select Performance Test</td>
                <td>
                    <asp:DropDownList ID="ddperftest" runat="server" OnSelectedIndexChanged="ddperftest_SelectedIndexChanged" AutoPostBack="true" Width="239px">
                        <asp:ListItem Text="--select Performance Test--"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Select Performance Test Category</td>
                <td>
                    <asp:DropDownList ID="ddperfcategory" runat="server">
                        <asp:ListItem Text="--select Performance Test Category--"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Click Add Button to Enter Performance Test Sub Categories</td>
                <td width="200px">
                        
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <asp:PlaceHolder ID="PlaceHolder2" runat="server">
                
            </asp:PlaceHolder>
             
        </ContentTemplate>            
    </asp:UpdatePanel>
                    </td>
            </tr>
            <tr>
                <td></td>
                    <td>
                        <asp:Button ID="btncreatesub" runat="server" Text="Add Sub Category" OnClick="btncreatesub_Click" CssClass="button-link"/>
                        &nbsp;<asp:Button ID="btnreadsub" runat="server" Text="Save" OnClick="btnreadsub_Click" CssClass="button-link" />
                    </td>
                </tr>
        </table>

    </div>
   <div class="clear"></div>
</asp:Content>

