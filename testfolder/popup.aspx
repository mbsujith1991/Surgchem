<%@ Page Language="C#" AutoEventWireup="true" CodeFile="popup.aspx.cs" Inherits="testfolder_popup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>jQuery Show Modal Popup from code behind or server side</title>
<link type="text/css" rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
<script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
<script type="text/javascript" src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
<script type="text/javascript">
    function showmodalpopup() {
        $("#popupdiv").dialog({
            title: "jQuery Popup from Server Side",
            width: 430,
            height: 250,
            modal: true,
            buttons: {
                Close: function () {
                    $(this).dialog('close');
                }
            }
        });
    };
</script>
</head>
<body>
<form id="form1" runat="server">
<div>
<div id="popupdiv" title="Basic modal dialog" style="display: none">
<b> Welcome to Aspdotnet-Suresh.com</b>
</div>
<asp:Button ID="btnShowModal" runat="server" Text="Show Popup" OnClick="btnShowModal_Click" />
</div>
</form>
</body>
</html>