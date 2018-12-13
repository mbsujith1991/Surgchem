<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="controls_Login" %>
<link href="../Styles_ecom/ecom.css" rel="stylesheet" />
<link href="../Styles_ecom/bomtv.css" rel="stylesheet" />

<center>
        <div class="loginbox roundcorner8 padding1" style="width:600px;">
            <h4 style="color: #124866">
                Administrator Login</h4>
            <table cellpadding="5px" cellspacing="5px" width="550px">
                <tr>
                    <td align="left">
                        User Name
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txtUsername" runat="server" ValidationGroup="login" Width="200px"></asp:TextBox>
                                    
                        
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        Password
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" ValidationGroup="login"
                            Width="200px"></asp:TextBox> 
                                       
                    </td>
                </tr>
                
                <tr>
                    <td></td>
                    <td>
                        <asp:Label ID="lbMsg" runat="server" ForeColor="#CC0000"></asp:Label>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" 
                                            ControlToValidate="txtUsername" ErrorMessage="Enter Username" ForeColor="Red" 
                                            ValidationGroup="login"></asp:RequiredFieldValidator>
                        <br />
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic"
                                            ControlToValidate="txtPwd" ErrorMessage="Enter Password" ForeColor="Red"
                                            ValidationGroup="login"></asp:RequiredFieldValidator>  
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="btnlogin_Click" ValidationGroup="login"
                            CssClass="button-link" />
                    </td>
                </tr>
            </table>
        </div>
    </center>     

         
                    
           
       