<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dynamictext.aspx.cs" Inherits="testfolder_dynamictext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function add(type) {

            //Create an input type dynamically.
            var element = document.createElement("input");

            //Assign different attributes to the element.
            element.setAttribute("type", type);
            element.setAttribute("value", type);
            element.setAttribute("name", type);


            var foo = document.getElementById("fooBar");

            //Append the element in page (in span).
            foo.appendChild(element);

        }
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:300px;">
   
<select name="element" style="visibility:hidden;" >
    <%--<option value="button">Button</option>--%>
    <option value="text">Textbox</option>
    <%--<option value="radio">Radio</option>--%>
</select>
 <asp:Label ID="lblcategoryname" runat="server" Text="Category Name"></asp:Label>
<input type="button" value="Add" onclick="add(document.forms[0].element.value)"/>
 
<span id="fooBar">&nbsp;</span>



        <asp:Button ID="addexProductBTN" runat="server" Text="add" onclick="addexProductBTN_Click"/>
<asp:PlaceHolder ID="DynamicControlsHolder" runat="server"></asp:PlaceHolder>
    </div>
       
    </form>
</body>
</html>
