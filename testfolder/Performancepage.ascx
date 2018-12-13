<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Performancepage.ascx.cs" Inherits="testfolder_Performancepage" %>

<link href="../Styles_ecom/ecom.css" rel="stylesheet" />
<style type="text/css">
    .border {
        border-bottom:1px solid;
        height:30px;
    }
</style>
<div id="perf1" runat="server">
 <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label31" runat="server" Text="2.1" Width="30px"></asp:Label>
                <asp:Label ID="lblperformancename" runat="server"></asp:Label></h4>
         </div>
<div class="clear"></div>
<div class="align_middle" style="font-weight:bold;width:6.27in;">
    <table border="1" cellspacing="0" cellpadding="0" style="width:100%;font-size:9pt;">
        <tr>
            <td  id="tdcat1_1" runat="server">
                       <asp:Label ID="lblcat1" runat="server" Text=""></asp:Label>
                   </td>
    <td  id="tdcat1_2" runat="server">
        <asp:Label ID="lblcat2" runat="server" Text=""></asp:Label>
        
    </td>
    <td id="tdcat1_3" runat="server">
        <asp:Label ID="lblcat3" runat="server" Text=""></asp:Label>
        
    </td>
    <td  id="tdcat1_4" runat="server">
        <asp:Label ID="lblcat4" runat="server" Text=""></asp:Label>
    </td>
    <td  id="tdcat1_5" runat="server">
        <asp:Label ID="lblcat5" runat="server" Text=""></asp:Label>
    </td>
    <td   id="tdcat1_6" runat="server">
        <asp:Label ID="lblcat6" runat="server" Text=""></asp:Label>
    </td>
            <td   id="tdcat1_7" runat="server">
        <asp:Label ID="lblcat7" runat="server" Text=""></asp:Label>
    </td>
            <td   id="tdcat1_8" runat="server">
        <asp:Label ID="lblcat8" runat="server" Text=""></asp:Label>
    </td>
            <td   id="tdcat1_9" runat="server">
        <asp:Label ID="lblcat9" runat="server" Text=""></asp:Label>
    </td>
                    
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl" runat="server" Text="" CssClass="border"></asp:Label>
                <br />
                <asp:DataList ID="DataList3" runat="server">
                    <ItemTemplate>
                        <%#Eval("Perf_value") %>
                    </ItemTemplate>
                </asp:DataList>
            </td>
            <td>
                <table>
            <tr>
                <td style="border:1px solid;font-size:8pt;">
                    <asp:Label ID="Label1" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="DataList1" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td style="border:1px solid;font-size:8pt;">
                    <asp:Label ID="Label2" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="DataList2" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
        </table>
            </td>
            <td>
                <table>
            <tr>
                <td style="border:1px solid;">
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                </td>
                <td style="border:1px solid;">
                    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
            </td>
            <td>
                <table>
            <tr>
                <td style="border:1px solid;">
                    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                </td>
                <td style="border:1px solid;">
                    <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
            </td>
            <td>
                <table style="width:100%;">
            <tr>
                <td style="border:1px solid;width:50%;">
                    <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                </td>
                <td style="border:1px solid;width:50%;">
                    <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>
                <table>

                </table>
            </td>
        </tr>
    </table>
</div>
</div>
<div class="clear"></div>

<div id="perf2" runat="server">
<div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label9" runat="server" Text="2.1" Width="30px"></asp:Label>
                <asp:Label ID="Label10" runat="server"></asp:Label></h4>
         </div>
<div class="clear"></div>
<div class="align_middle" style="font-weight:bold;width:6.27in;">
    <table border="1" cellspacing="0" cellpadding="0" style="width:100%;font-size:9pt;">
        <tr>
            <td   id="tdcat2_1" runat="server">
                       <asp:Label ID="lblcat2_1" runat="server" Text=""></asp:Label>
                   </td>
    <td  id="tdcat2_2" runat="server">
        <asp:Label ID="lblcat2_2" runat="server" Text=""></asp:Label>
        
    </td>
    <td id="tdcat2_3" runat="server">
        <asp:Label ID="lblcat2_3" runat="server" Text=""></asp:Label>
        
    </td>
    <td  id="tdcat2_4" runat="server">
        <asp:Label ID="lblcat2_4" runat="server" Text=""></asp:Label>
    </td>
    <td  id="tdcat2_5" runat="server">
        <asp:Label ID="lblcat2_5" runat="server" Text=""></asp:Label>
    </td>
    <td   id="tdcat2_6" runat="server">
        <asp:Label ID="lblcat2_6" runat="server" Text=""></asp:Label>
    </td>
            <td   id="tdcat2_7" runat="server">
        <asp:Label ID="lblcat2_7" runat="server" Text=""></asp:Label>
    </td>
            <td   id="tdcat2_8" runat="server">
        <asp:Label ID="lblcat2_8" runat="server" Text=""></asp:Label>
    </td>
            <td   id="tdcat2_9" runat="server">
        <asp:Label ID="lblcat2_9" runat="server" Text=""></asp:Label>
    </td>
                    
        </tr>
        <tr id="trsubcat2" runat="server">
          
            <td id="tdsubcat2_1" runat="server">
                <table id="tbsubcat2_1" runat="server">
            <tr>
                <td style="border:1px solid;font-size:8pt;">
                     <asp:Label ID="lblsubcat2_1" runat="server" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_1" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td style="border:1px solid;font-size:8pt;">
                    <asp:Label ID="lblsubcat2_2" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_2" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td3" runat="server">
                    <asp:Label ID="lblsubcat2_3" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_3" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td4" runat="server">
                    <asp:Label ID="lblsubcat2_4" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_4" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
        </table>
            </td>
            <td id="tdsubcat2_2" runat="server">
                <table id="tbsubcat2_2" runat="server">
            <tr>
                <td style="border:1px solid;font-size:8pt;">
                     <asp:Label ID="lblsubcat2_5" runat="server" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_5" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td style="border:1px solid;font-size:8pt;">
                    <asp:Label ID="lblsubcat2_6" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_6" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td1" runat="server">
                    <asp:Label ID="lblsubcat2_7" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_7" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td2" runat="server">
                    <asp:Label ID="lblsubcat2_8" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_8" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
        </table>
            </td>
            <td id="tdsubcat2_3" runat="server">
                <table id="tbsubcat2_3" runat="server">
             <tr>
                <td style="border:1px solid;font-size:8pt;">
                     <asp:Label ID="lblsubcat2_9" runat="server" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_9" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td style="border:1px solid;font-size:8pt;">
                    <asp:Label ID="lblsubcat2_10" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_10" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td5" runat="server">
                    <asp:Label ID="lblsubcat2_11" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_11" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td6" runat="server">
                    <asp:Label ID="lblsubcat2_12" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_12" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
        </table>
            </td>
            <td id="tdsubcat2_4" runat="server">
                <table id="tbsubcat2_4" runat="server">
             <tr>
                <td style="border:1px solid;font-size:8pt;">
                     <asp:Label ID="lblsubcat2_13" runat="server" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_13" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td style="border:1px solid;font-size:8pt;">
                    <asp:Label ID="lblsubcat2_14" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_14" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td7" runat="server">
                    <asp:Label ID="lblsubcat2_15" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_15" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td8" runat="server">
                    <asp:Label ID="lblsubcat2_16" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_16" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
        </table>
            </td>
            <td id="tdsubcat2_5" runat="server">
                <table id="tbsubcat2_5" runat="server">
             <tr>
                <td style="border:1px solid;font-size:8pt;">
                     <asp:Label ID="lblsubcat2_17" runat="server" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_17" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td style="border:1px solid;font-size:8pt;">
                    <asp:Label ID="lblsubcat2_18" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_18" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td9" runat="server">
                    <asp:Label ID="lblsubcat2_19" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_19" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td10" runat="server">
                    <asp:Label ID="lblsubcat2_20" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_20" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
        </table>
            </td>
            <td id="tdsubcat2_6" runat="server">
                <table id="tbsubcat2_6" runat="server">
             <tr>
                <td style="border:1px solid;font-size:8pt;">
                     <asp:Label ID="lblsubcat2_21" runat="server" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_21" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td style="border:1px solid;font-size:8pt;">
                    <asp:Label ID="lblsubcat2_22" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_22" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td11" runat="server">
                    <asp:Label ID="lblsubcat2_23" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_23" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td12" runat="server">
                    <asp:Label ID="lblsubcat2_24" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_24" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
        </table>
            </td>
            <td id="tdsubcat2_7" runat="server">
                <table id="tbsubcat2_7" runat="server">
             <tr>
                <td style="border:1px solid;font-size:8pt;">
                     <asp:Label ID="lblsubcat2_25" runat="server" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_25" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td style="border:1px solid;font-size:8pt;">
                    <asp:Label ID="lblsubcat2_26" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_26" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td13" runat="server">
                    <asp:Label ID="lblsubcat2_27" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_27" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td14" runat="server">
                    <asp:Label ID="lblsubcat2_28" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_28" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
        </table>
            </td>
            <td id="tdsubcat2_8" runat="server">
                <table id="tbsubcat2_8">
             <tr>
                <td style="border:1px solid;font-size:8pt;">
                     <asp:Label ID="lblsubcat2_29" runat="server" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_29" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td style="border:1px solid;font-size:8pt;">
                    <asp:Label ID="lblsubcat2_30" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_30" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td15" runat="server">
                    <asp:Label ID="lblsubcat2_31" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_31" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td16" runat="server">
                    <asp:Label ID="lblsubcat2_32" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_32" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
        </table>
            </td>
            <td id="tdsubcat2_9" runat="server">
                <table id="tbsubcat2_33" runat="server">
             <tr>
                <td style="border:1px solid;font-size:8pt;">
                     <asp:Label ID="lblsubcat2_33" runat="server" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_33" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td style="border:1px solid;font-size:8pt;">
                    <asp:Label ID="lblsubcat2_34" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_34" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td17" runat="server">
                    <asp:Label ID="lblsubcat2_35" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_35" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                 <td style="border:1px solid;font-size:8pt;" id="td18" runat="server">
                    <asp:Label ID="lblsubcat2_36" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="datasubcat2_36" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
        </table>
            </td>
        </tr>
       
    </table>
</div>
    </div>

<div class="clear"></div>

<div id="perf3" runat="server">
<div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label11" runat="server" Text="2.1" Width="30px"></asp:Label>
                <asp:Label ID="Label12" runat="server"></asp:Label></h4>
         </div>
<div class="clear"></div>
<div class="align_middle" style="font-weight:bold;width:6.27in;">
    <table border="1" cellspacing="0" cellpadding="0" style="width:100%;font-size:9pt;">
        <tr>
            <td  id="tdcat3_1" runat="server">
                       <asp:Label ID="lblcat3_1" runat="server" Text=""></asp:Label>
                   </td>
    <td  id="tdcat3_2" runat="server">
        <asp:Label ID="lblcat3_2" runat="server" Text=""></asp:Label>
        
    </td>
    <td id="tdcat3_3" runat="server">
        <asp:Label ID="lblcat3_3" runat="server" Text=""></asp:Label>
        
    </td>
    <td  id="tdcat3_4" runat="server">
        <asp:Label ID="lblcat3_4" runat="server" Text=""></asp:Label>
    </td>
    <td  id="tdcat3_5" runat="server">
        <asp:Label ID="lblcat3_5" runat="server" Text=""></asp:Label>
    </td>
    <td   id="tdcat3_6" runat="server">
        <asp:Label ID="lblcat3_6" runat="server" Text=""></asp:Label>
    </td>
            <td   id="tdcat3_7" runat="server">
        <asp:Label ID="lblcat3_7" runat="server" Text=""></asp:Label>
    </td>
            <td   id="tdcat3_8" runat="server">
        <asp:Label ID="lblcat3_8" runat="server" Text=""></asp:Label>
    </td>
            <td   id="tdcat3_9" runat="server">
        <asp:Label ID="lblcat3_9" runat="server" Text=""></asp:Label>
    </td>
                    
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label32" runat="server" Text="" CssClass="border"></asp:Label>
                <br />
                <asp:DataList ID="DataList7" runat="server">
                    <ItemTemplate>
                        <%#Eval("Perf_value") %>
                    </ItemTemplate>
                </asp:DataList>
            </td>
            <td>
                <table>
            <tr>
                <td style="border:1px solid;font-size:8pt;">
                    <asp:Label ID="Label33" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="DataList8" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td style="border:1px solid;font-size:8pt;">
                    <asp:Label ID="Label34" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="DataList9" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
        </table>
            </td>
            <td>
                <table>
            <tr>
                <td style="border:1px solid;">
                    <asp:Label ID="Label35" runat="server" Text=""></asp:Label>
                </td>
                <td style="border:1px solid;">
                    <asp:Label ID="Label36" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
            </td>
            <td>
                <table>
            <tr>
                <td style="border:1px solid;">
                    <asp:Label ID="Label37" runat="server" Text=""></asp:Label>
                </td>
                <td style="border:1px solid;">
                    <asp:Label ID="Label38" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
            </td>
            <td>
                <table style="width:100%;">
            <tr>
                <td style="border:1px solid;width:50%;">
                    <asp:Label ID="Label39" runat="server" Text=""></asp:Label>
                </td>
                <td style="border:1px solid;width:50%;">
                    <asp:Label ID="Label40" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>
                <table>

                </table>
            </td>
        </tr>
    </table>
</div>
    </div>

<div class="clear"></div>
<div id="perf4" runat="server">
<div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server" Text="2.1" Width="30px"></asp:Label>
                <asp:Label ID="Label42" runat="server"></asp:Label></h4>
         </div>
<div class="clear"></div>
<div class="align_middle" style="font-weight:bold;width:6.27in;">
    <table border="1" cellspacing="0" cellpadding="0" style="width:100%;font-size:9pt;">
        <tr>
            <td id="tdcat4_1" runat="server">
                       <asp:Label ID="lblcat4_1" runat="server" Text=""></asp:Label>
                   </td>
    <td  id="tdcat4_2" runat="server">
        <asp:Label ID="lblcat4_2" runat="server" Text=""></asp:Label>
        
    </td>
    <td id="tdcat4_3" runat="server">
        <asp:Label ID="lblcat4_3" runat="server" Text=""></asp:Label>
        
    </td>
    <td  id="tdcat4_4" runat="server">
        <asp:Label ID="lblcat4_4" runat="server" Text=""></asp:Label>
    </td>
    <td  id="tdcat4_5" runat="server">
        <asp:Label ID="lblcat4_5" runat="server" Text=""></asp:Label>
    </td>
    <td   id="tdcat4_6" runat="server">
        <asp:Label ID="lblcat4_6" runat="server" Text=""></asp:Label>
    </td>
            <td   id="tdcat4_7" runat="server">
        <asp:Label ID="lblcat4_7" runat="server" Text=""></asp:Label>
    </td>
            <td   id="tdcat4_8" runat="server">
        <asp:Label ID="lblcat4_8" runat="server" Text=""></asp:Label>
    </td>
            <td   id="tdcat4_9" runat="server">
        <asp:Label ID="lblcat4_9" runat="server" Text=""></asp:Label>
    </td>
                    
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label52" runat="server" Text="" CssClass="border"></asp:Label>
                <br />
                <asp:DataList ID="DataList10" runat="server">
                    <ItemTemplate>
                        <%#Eval("Perf_value") %>
                    </ItemTemplate>
                </asp:DataList>
            </td>
            <td>
                <table>
            <tr>
                <td style="border:1px solid;font-size:8pt;">
                    <asp:Label ID="Label53" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="DataList11" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td style="border:1px solid;font-size:8pt;">
                    <asp:Label ID="Label54" runat="server" Text="" CssClass="border"></asp:Label>
                    <br />
                    <asp:DataList ID="DataList12" runat="server">
                        <ItemTemplate>
                            <%#Eval("Perf_value") %>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
        </table>
            </td>
            <td>
                <table>
            <tr>
                <td style="border:1px solid;">
                    <asp:Label ID="Label55" runat="server" Text=""></asp:Label>
                </td>
                <td style="border:1px solid;">
                    <asp:Label ID="Label56" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
            </td>
            <td>
                <table>
            <tr>
                <td style="border:1px solid;">
                    <asp:Label ID="Label57" runat="server" Text=""></asp:Label>
                </td>
                <td style="border:1px solid;">
                    <asp:Label ID="Label58" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
            </td>
            <td>
                <table style="width:100%;">
            <tr>
                <td style="border:1px solid;width:50%;">
                    <asp:Label ID="Label59" runat="server" Text=""></asp:Label>
                </td>
                <td style="border:1px solid;width:50%;">
                    <asp:Label ID="Label60" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>
                <table>

                </table>
            </td>
        </tr>
    </table>
</div>
    </div>