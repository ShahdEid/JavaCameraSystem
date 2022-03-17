<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyStockView.aspx.cs" Inherits="MyStockView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStock" runat="server" Height="207px" Width="297px"></asp:ListBox>
        <p>
            Please enter a stock name:</p>
        <asp:TextBox ID="txtStockName" runat="server" Width="214px"></asp:TextBox>
        <p>
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 10px; top: 339px; position: absolute" Text="Apply" />
            <asp:Button ID="btnDisplayAll" runat="server" style="width: 129px; z-index: 1; left: 101px; top: 339px; position: absolute" Text="Display All" />
        </p>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 10px; top: 384px; position: absolute" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 177px; top: 384px; position: absolute" Text="Delete" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 92px; top: 384px; position: absolute" Text="Edit" />
    </form>
</body>
</html>
