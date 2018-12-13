<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jqueryTest.aspx.cs" Inherits="css_jqueryTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="//ajax.aspnetcdn.com/ajax/jQuery/jquery-1.11.0.min.js">
</script>
<%--    <script>
        $(document).ready(function () {
            $("button").click(function () {
                $("p").fadeOut();
            });
        });
    </script>--%>
    <script>
        $(document).ready(function () {
            $("button").click(function () {
                $("p").hide();
            });
        });
</script>

</head>
<body>
    <form id="form1" runat="server" >
<h2>This is a heading</h2>
<p>This is a paragraph.</p>
<p>This is another paragraph.</p>
<button>Click me</button>
    </form>
</body>
</html>
