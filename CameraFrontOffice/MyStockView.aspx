<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyStockView.aspx.cs" Inherits="MyStockView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 129px;
            z-index: 1;
            left: 174px;
            top: 339px;
            position: absolute;
        }
        .auto-style2 {
            z-index: 1;
            left: 236px;
            top: 384px;
            position: absolute;
        }
        .auto-style3 {
            z-index: 1;
            left: 122px;
            top: 384px;
            position: absolute;
            width: 69px;
        }
        .auto-style4 {
            z-index: 1;
            left: 10px;
            top: 384px;
            position: absolute;
            width: 68px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStock" runat="server" Height="207px" Width="297px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 241px; position: absolute"></asp:Label>
        <p style="z-index: 1; left: 12px; top: 266px; position: absolute; height: 27px; width: 1115px">
            Please enter a stock type:</p>
        <asp:TextBox ID="txtStockName" runat="server" Width="214px" style="z-index: 1; left: 10px; top: 304px; position: absolute"></asp:TextBox>
        <p>
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 10px; top: 339px; position: absolute" Text="Apply" OnClick="btnApply_Click" />
            <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" CssClass="auto-style1" />
        </p>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" CssClass="auto-style4" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="auto-style2" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" CssClass="auto-style3" />
    </form>
</body>
</html>
