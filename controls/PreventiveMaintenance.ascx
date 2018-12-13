<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PreventiveMaintenance.ascx.cs" Inherits="controls_PreventiveMaintenance" %>

<link href="../Styles_ecom/ecom.css" rel="stylesheet" />
<script type = "text/javascript">
    function Printpreventive() {
        var panel = document.getElementById("<%=pnlpreventive.ClientID %>");
         var printWindow = window.open('', '', 'height=400,width=800');
         printWindow.document.write('<html><head><title>DIV Contents</title>');
         printWindow.document.write('</head><body >');
         printWindow.document.write(panel.innerHTML);
         printWindow.document.write('</body></html>');
         printWindow.document.close();
         setTimeout(function () {
             printWindow.print();
         }, 500);
         return false;
     }
    </script>
<style type="text/css">
    
    .txtwidth {
        width:250px;
    }
</style>
<asp:HiddenField ID="idhospitalhidden" runat="server" />
<asp:HiddenField ID="hospnamehidden" runat="server" />
<asp:HiddenField ID="reportidhidden" runat="server" />
<asp:HiddenField ID="datepreventionhidden" runat="server" />
    <asp:HiddenField ID="calibdatehidden" runat="server" />
 
<div class="round_corner5 align_left colwidth975">
    <h3>Preventive Maintenance</h3>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="PreventID"
        AllowPaging="true" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="10" Width="100%">

        <Columns>
             
              <asp:TemplateField>
                     <HeaderStyle Height="30px" />
                     <HeaderTemplate>Product Name</HeaderTemplate>
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblproduct" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                     </ItemTemplate>
                    
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Manufacture">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblmanufacture" runat="server" Text='<%# Eval("Manufacture") %>'></asp:Label>
                     </ItemTemplate>
                    
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Model Name">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblmodel" runat="server" Text='<%# Eval("Model") %>'></asp:Label>
                     </ItemTemplate>
                    
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Device Type">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lbldevtype" runat="server" Text='<%# Eval("DeviceType") %>'></asp:Label>
                     </ItemTemplate>
                    
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Device Classification">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lbldevclassi" runat="server" Text='<%# Eval("DeviceClassi") %>'></asp:Label>
                     </ItemTemplate>
                    
                 </asp:TemplateField>
        <asp:TemplateField HeaderText="Supply">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblsupply" runat="server" Text='<%# Eval("Supply") %>'></asp:Label>
                     </ItemTemplate>
                    
                 </asp:TemplateField>
        <asp:TemplateField HeaderText="Serial No">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblslno" runat="server" Text='<%# Eval("Serial_No") %>'></asp:Label>
                     </ItemTemplate>
                   
                 </asp:TemplateField>
            <asp:TemplateField HeaderText="Serial No">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblbioid" runat="server" Text='<%# Eval("BiomedicalID") %>'></asp:Label>
                     </ItemTemplate>
                   
                 </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click" Text="Add"></asp:Button>
                    <asp:Button ID="btndelete" runat="server" OnClick="btndelete_Click" Text="Delete" CommandArgument='<%# Eval("PreventID") %>'></asp:Button>
                </ItemTemplate>
            </asp:TemplateField>
           
        </Columns>
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    <asp:Label ID="lblmsg" runat="server" Text="" ForeColor="Green"></asp:Label>
      </div>

<div class="clear"></div>

<div class="content_box round_corner5 align_left colwidth975">

         <asp:Panel ID="pnlpreventive" runat="server">
             <div style="padding-left:10%;padding-top:5%;padding-right:10%;padding-bottom:5%;">
  
    <table cellpadding="5" cellspacing="5">
        <tr>
            <th colspan="2">Preventive Maintenance Report</th>
        </tr>
        <tr>
            <td class="txtwidth">Product Name</td>
            <td>
                <asp:TextBox ID="txtproname" runat="server" CssClass="txtwidth"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="txtwidth">Manufacture</td>
            <td><asp:TextBox ID="txtmanu" runat="server" CssClass="txtwidth"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="txtwidth">Model</td>
            <td><asp:TextBox ID="txtmodel" runat="server" CssClass="txtwidth"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="txtwidth">Device Type</td>
            <td><asp:TextBox ID="txtdevtype" runat="server" CssClass="txtwidth"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="txtwidth">Device Classification</td>
            <td><asp:TextBox ID="txtdevclass" runat="server" CssClass="txtwidth"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="txtwidth">Supply</td>
            <td><asp:TextBox ID="txtsupply" runat="server" CssClass="txtwidth"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="txtwidth">Power Rating</td>
            <td><asp:TextBox ID="txtpower" runat="server" CssClass="txtwidth"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="txtwidth">Serial No</td>
            <td><asp:TextBox ID="txtserial" runat="server" CssClass="txtwidth"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="txtwidth">Biomedical Product ID</td>
            <td><asp:TextBox ID="txtbiomedical" runat="server" CssClass="txtwidth"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="txtwidth">Location</td>
            <td><asp:TextBox ID="txtlocation" runat="server" CssClass="txtwidth"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="txtwidth">Condition of Item</td>
            <td><asp:TextBox ID="txtcondofitem" runat="server" CssClass="txtwidth"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="txtwidth">Preventive Maintenance Details</td>
            <td>
                <asp:TextBox ID="txtprevent" TextMode="MultiLine"  runat="server" Width="600px" Rows="5"></asp:TextBox>
            </td>
            </tr>
        
        <tr>
            <td>
                Signature
            </td>
            <td>
            </td>
        </tr>
        
    </table>

                 </div>
     </asp:Panel>
                    <asp:Button ID="btnprint" runat="server" Text="Print" CssClass="button-link" OnClientClick = "return Printpreventive();" />
    <asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="button-link" OnClick="btncancel_Click" />


</div>
<div class="clear"></div>

<div class="content_box align_left">
    
</div>
