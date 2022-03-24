<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyStockDelete.aspx.cs" Inherits="MyStockDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 200px;
            top: 48px;
            position: absolute;
            width: 42px;
        }
        .auto-style2 {
            z-index: 1;
            left: 103px;
            top: 48px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this stock?</div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" CssClass="auto-style2" />
        <p>
            <asp:Button ID="btnNo" runat="server" Text="No" CssClass="auto-style1" />
        </p>
    </form>
</body>
</html>
