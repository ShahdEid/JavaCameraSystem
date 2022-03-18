<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyStockDelete.aspx.cs" Inherits="MyStockDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this stock?</div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 45px; top: 48px; position: absolute" Text="Yes" />
        <p>
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 116px; top: 48px; position: absolute" Text="No" />
        </p>
    </form>
</body>
</html>
