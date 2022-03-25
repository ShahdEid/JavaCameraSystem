<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDefault.aspx.cs" Inherits="OrderDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 670px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstOrders" runat="server" Height="483px" OnSelectedIndexChanged="lstOrders_SelectedIndexChanged" Width="459px"></asp:ListBox>
        <asp:Button ID="btnApply" runat="server" BackColor="#CCFFFF" Text="Apply" Width="89px" />
        <asp:Button ID="btnDisplayAll" runat="server" BackColor="#CCFFFF" ForeColor="Black" Text="Display All" Width="66px" />
        <asp:Button ID="btnAdd" runat="server" BackColor="#CCFFFF" Text="Add" Width="100px" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" BackColor="#CCFFFF" Text="Edit" Width="92px" />
        <asp:Button ID="btnDelete" runat="server" BackColor="#CCFFFF" Text="Delete" Width="114px" OnClick="btnDelete_Click" />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <div style="height: 166px">
            : <asp:Label ID="Label1" runat="server" BackColor="Aqua" Text="Enter Order Quantity"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="18px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
