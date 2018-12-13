<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_TempMeasure.ascx.cs" Inherits="Perf_Control_Views_View_TempMeasure" %>

 <div id="tempmeasurediv" runat="server">
         <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label37" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblperformancename6" runat="server"></asp:Label></h4>
         </div>
    <div class="clear"></div>
       <div class="align_middle" style="font-weight:bold;width:6.27in;">
           <table border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
        <tr>
            <td rowspan="2">
                Sl No
            </td>
            <td rowspan="2">Temp set on DUT</td>
            <td rowspan="2">Temp Displayed on DUT</td>
            <td rowspan="2">Temp Measured on STD</td>
            <td colspan="2">Deviation</td>
            <td colspan="2">Specified limit as per Mfr. Spec.</td>
            <td rowspan="2">Remarks</td>
        </tr>
        <tr>
           
            <td>w.r.t Temp set on DUT</td>
            <td>w.r.t Temp Display on DUT</td>
            <td>Set</td>
            <td>Display</td>
           
        </tr>
          <tr id="temp_1" runat="server">
              <td>
                  <asp:Label ID="lbtemp1" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp2" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp3" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp4" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp5" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp6" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp7" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp8" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp9" runat="server" Text=""></asp:Label>
              </td>
          </tr>
               <tr id="temp_2" runat="server">
              <td>
                  <asp:Label ID="lbtemp10" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp11" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp12" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp13" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp14" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp15" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp16" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp17" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp18" runat="server" Text=""></asp:Label>
              </td>
          </tr>
               <tr id="temp_3" runat="server">
              <td>
                  <asp:Label ID="lbtemp19" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp20" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp21" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp22" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp23" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp24" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp25" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp26" runat="server" Text=""></asp:Label>
              </td>
              <td>
                  <asp:Label ID="lbtemp27" runat="server" Text=""></asp:Label>
              </td>
          </tr>
         
    </table>
          
       </div>
    </div>