<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyStock.aspx.cs" Inherits="MyStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 37px;
            left: 10px;
        }
        .auto-style2 {
            position: absolute;
            top: 71px;
            left: 8px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 107px;
            left: 9px;
            z-index: 1;
            right: 1102px;
        }
        .auto-style4 {
            position: absolute;
            top: 143px;
            left: 11px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 38px;
            left: 166px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 144px;
            left: 167px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 107px;
            left: 166px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 70px;
            left: 166px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 237px;
            left: 183px;
            z-index: 1;
            right: 965px;
        }
        .auto-style10 {
            position: absolute;
            top: 237px;
            left: 67px;
            z-index: 1;
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
        <asp:Button ID="btnClose" runat="server" CssClass="auto-style9" Text="Close" />
    </form>
</body>
</html>
