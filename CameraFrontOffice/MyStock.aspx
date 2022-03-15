<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyStock.aspx.cs" Inherits="MyStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 51px;
            left: 10px;
        }
        .auto-style2 {
            position: absolute;
            top: 190px;
            left: 10px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 97px;
            left: 10px;
            z-index: 1;
            right: 1011px;
            height: 22px;
        }
        .auto-style4 {
            position: absolute;
            top: 231px;
            left: 10px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 51px;
            left: 166px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 231px;
            left: 168px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 96px;
            left: 167px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 190px;
            left: 167px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 301px;
            left: 180px;
            z-index: 1;
            right: 758px;
        }
        .auto-style10 {
            position: absolute;
            top: 302px;
            left: 64px;
            z-index: 1;
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStockId" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Stock Id"></asp:Label>
            <asp:TextBox ID="txtStockId" runat="server" style="z-index: 1; left: 167px; top: 11px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblStockName" runat="server" CssClass="auto-style1" style="z-index: 1" Text="Stock Name"></asp:Label>
        <asp:Label ID="lblStockQuantity" runat="server" CssClass="auto-style2" Text="Stock Quantity"></asp:Label>
        <asp:Label ID="lblStockType" runat="server" CssClass="auto-style3" Text="Stock Type"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" CssClass="auto-style4" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtStockName" runat="server" CssClass="auto-style5"></asp:TextBox>
        <asp:TextBox ID="txtStockQuantity" runat="server" CssClass="auto-style8"></asp:TextBox>
        <asp:TextBox ID="txtStockType" runat="server" CssClass="auto-style7"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style10" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnClose" runat="server" CssClass="auto-style9" Text="Close" Width="100px" />
        <asp:TextBox ID="txtStockPrice" runat="server" style="z-index: 1; left: 168px; top: 141px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStockPrice" runat="server" style="z-index: 1; left: 12px; top: 144px; position: absolute" Text="Stock Price"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 372px; top: 10px; position: absolute" Text="Find" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 262px; position: absolute"></asp:Label>
    </form>
</body>
</html>
