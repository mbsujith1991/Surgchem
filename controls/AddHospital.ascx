<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddHospital.ascx.cs" Inherits="controls_AddHospital" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<link href="../Styles_ecom/bomtv.css" rel="stylesheet" />

<link href="../Styles_ecom/ecom.css" rel="stylesheet" />
<script type="text/javascript">
    function Showalert() {
        alert('Call JavaScript function from codebehind');
    }
</script>
<div class="content_box align_left shadow  round_corner5 colwidth45">
    <asp:HiddenField ID="logid_hidden" runat="server" />
    <asp:HiddenField ID="logidgrid_hidden" runat="server" />
 <table cellpadding="5" cellspacing="5">
     <tr>
         <th colspan="2">Create User</th>
     </tr>
     <tr id="usertypetr" runat="server">
         <td><span style="color:red;">*</span>User Type</td>
         <td>
             <asp:DropDownList ID="drpusertype" runat="server" Width="200px" AutoPostBack="true"  OnSelectedIndexChanged="drpusertype_SelectedIndexChanged">
                 <asp:ListItem Text="User" Value="2"></asp:ListItem>
                 <asp:ListItem Text="Executive" Value="1"></asp:ListItem>
                 <asp:ListItem Text="Super Admin" Value="0"></asp:ListItem>
                 <asp:ListItem Text="Calibration Engr" Value="3"></asp:ListItem>
                 <asp:ListItem Text="Issuing Officer" Value="4"></asp:ListItem>
                 <asp:ListItem Text="BMT-MTH" Value="5"></asp:ListItem>
                 <asp:ListItem Text="BMT-ACH" Value="6"></asp:ListItem>
             </asp:DropDownList></td>
     </tr>
     <tr id="hospname" runat="server">
         <td><span style="color:red;">*</span><asp:Label ID="lblname" runat="server" Text="Hospital Name"></asp:Label></td>
         <td>
             <asp:TextBox ID="txtname" runat="server" Width="200px"></asp:TextBox>
             
         </td>

     </tr>
     <tr id="hospaddress" runat="server">
         <td><span style="color:red;">*</span><asp:Label ID="lbladdress" runat="server" Text="Address"></asp:Label></td>
         <td>
             <asp:TextBox ID="txtaddress" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
             
         </td>
     </tr>
     <tr>
         <td><span style="color:red;">*</span>User Name</td>
         <td>
             <asp:TextBox ID="txtusername" runat="server" Width="200px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic"
                 ValidationGroup="login" ErrorMessage="UserName required" ControlToValidate="txtusername" ForeColor="red"></asp:RequiredFieldValidator>
         </td>

     </tr>
     <tr>
         <td><span style="color:red;">*</span>Password</td>
         <td>
             <asp:TextBox ID="txtpswd" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic"
                 ValidationGroup="login" ControlToValidate="txtpswd" ErrorMessage="Password Required" ForeColor="Red"></asp:RequiredFieldValidator>
         </td>
     </tr>
      <tr>
         <td>Confirm Password</td>
         <td>
             <asp:TextBox ID="txtcpswd" runat="server" TextMode="Password" Width="200px"></asp:TextBox></td>
          <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Please confirm your Password"
               ForeColor="Red" ControlToCompare="txtpswd" Display="Dynamic"
              ValidationGroup="login" ControlToValidate="txtcpswd" Operator="Equal" Type="String"></asp:CompareValidator>
     </tr>
     
     
      <tr>
         <td>&nbsp;</td>
         <td>
             &nbsp;</td>
     </tr>
     <tr>
         <td></td>
         <td>
             <asp:Button ID="btnsave" runat="server" Text="Save" Width="100px" OnClick="btnsave_Click" CssClass="button-link" ValidationGroup="login"/>
             &nbsp;&nbsp;<asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="button-link" OnClick="btncancel_Click"/></td>
     </tr>
 </table>
    </div>
  
<div class="align_left colwidth45">
    <div class="content_wrap">
    <center>
        <table>
            <tr>
                <td><asp:Label ID="lblsearchby" runat="server" Text="Search by:" ForeColor="White"/></td>
                
               <td> <asp:TextBox ID="txtSearchString" runat="server" Width="200px"></asp:TextBox>
           
                    <cc1:TextBoxWatermarkExtender ID="txtSearchString_TextBoxWatermarkExtender" WatermarkText="User Name" WatermarkCssClass="watermarked" runat="server" Enabled="True" TargetControlID="txtSearchString">
                    </cc1:TextBoxWatermarkExtender>
            
                   
                </td>
                <td>
                    <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                    <asp:ListItem Value="2">Hospital</asp:ListItem>
                    <asp:ListItem Value="1">Executive</asp:ListItem>
                    <asp:ListItem Value="3">Calibration Engr</asp:ListItem>
                    <asp:ListItem Value="4">Issuing Officer</asp:ListItem>
                    <asp:ListItem Text="BMT-MTH" Value="5"></asp:ListItem>
                    <asp:ListItem Text="BMT-ACH" Value="6"></asp:ListItem>
                    
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="btnSearch" runat="server" CssClass="button-link" OnClick="btnSearch_Click" Text="Search" />
                </td> 
            </tr>
        </table>
    </center>
</div>
    <div style="box-shadow:0px 0px 3px #808080">
    <asp:GridView ID="CustomersGridView" runat="server" AutoGenerateColumns="False"  DataKeyNames="LoginID" Width="100%"
                            AllowPaging="True"  OnPageIndexChanging="CustomersGridView_PageIndexChanging" PageSize="5"
                    cellpadding="5" CellSpacing="5"  OnRowDeleting="CustomersGridView_RowDeleting" OnRowEditing="CustomersGridView_RowEditing" GridLines="None" ForeColor="#333333">
              
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
              
        <Columns>
            <asp:BoundField HeaderText="Name" DataField="HospitalName" />
            <asp:BoundField HeaderText="Address" DataField="Address" />
            <asp:BoundField HeaderText="UserName" DataField="Username" />
            <asp:BoundField HeaderText="Password" DataField="Password" />
            <asp:BoundField HeaderText="Usertype" DataField="Usertype" />
            <asp:TemplateField HeaderText="Edit">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="lbedit" runat="server" Text="Update" CssClass="mgridlink"
                                            CommandName="Edit" ImageUrl="~/images/edit.png" OnClick="lbedit_Click"
                                            ToolTip="Edit customer account" CommandArgument='<%# Eval("LoginID") %>'></asp:ImageButton>
                                        <asp:ImageButton ID="lbdelete" runat="server" CssClass="mgridlink" CommandName="Delete"
                                            OnClientClick="return confirm('Are you sure you want to delete this customer?')"
                                          ToolTip="Delete customer details" ImageUrl="~/images/del-icon.gif">
                                        </asp:ImageButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
        </Columns>
              
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
              
    </asp:GridView>
        </div>
    <br />
    <div>
     <asp:GridView ID="exegrid" runat="server" AutoGenerateColumns="False" OnPageIndexChanging="exegrid_PageIndexChanging"
        DataKeyNames="LoginID" AllowPaging="True" OnRowEditing="exegrid_RowEditing" OnRowDeleting="exegrid_RowDeleting" 
         PageSize="4" CellPadding="5" CellSpacing="5" Width="100%" GridLines="None">
        
         <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        
         <Columns>
            
            <asp:BoundField HeaderText="UserName" DataField="Username" />
            <asp:BoundField HeaderText="Password" DataField="Password" />
            <asp:BoundField HeaderText="Usertype" DataField="Usertype" />
             <asp:TemplateField HeaderText="Edit">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="lbedit" runat="server" Text="Update" CssClass="mgridlink"
                                             ImageUrl="~/images/edit.png" OnClick="lbedit_Click1" CommandName="Edit"
                                            ToolTip="Edit customer account" CommandArgument='<%# Eval("LoginID") %>'></asp:ImageButton>
                                        <asp:ImageButton ID="lbdelete" runat="server" CssClass="mgridlink" CommandName="Delete"
                                            OnClientClick="return confirm('Are you sure you want to delete this customer?')"
                                          ToolTip="Delete customer details" ImageUrl="~/images/del-icon.gif">
                                        </asp:ImageButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
        </Columns>
        
         <EditRowStyle BackColor="#999999" />
         <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
         <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
         <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
         <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
         <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
         <SortedAscendingCellStyle BackColor="#E9E7E2" />
         <SortedAscendingHeaderStyle BackColor="#506C8C" />
         <SortedDescendingCellStyle BackColor="#FFFDF8" />
         <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        
         </asp:GridView>
        </div>
</div>  

       

