<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PerformanceTest.ascx.cs" Inherits="controls_PerformanceTest" %>

 <!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <title>Dynamically create textboxes in ASP.Net</title>
</head>
<body>
    <form id="form1" runat="server">
        Add Performance Test
        <div style="width:450px; height:auto; margin:20px auto; padding:20px 0px; border:thin solid #333;">
            Enter Performance Test Name&nbsp;&nbsp;<asp:TextBox ID="txtperfname" runat="server"></asp:TextBox>
            <br />
            <br />
             Click Add Button to Enter Performance Test  Categories
       <div style="width:200px;padding-left:100px;"> 
          
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server">
                
            </asp:PlaceHolder>
             <asp:Button ID="btnCreate" runat="server" Text="Add Category" OnClick="btnCreate_Click" />
    <asp:Button ID="btnRead" runat="server" Text="Save" OnClick="btnRead_Click" />
        </ContentTemplate>            
    </asp:UpdatePanel>
        
    </div>
            </div>
    </form>
</body>
</html>
