<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDefault.aspx.cs" Inherits="CustomerDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstCustomers" runat="server" Height="162px" Width="199px"></asp:ListBox>
        <br />
        Please Enter a First Name<br />
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Apply" />
            <asp:Button ID="Button2" runat="server" Text="Display" />
        </div>
        <p>
            <asp:Button ID="Button3" runat="server" Text="Add" />
            <asp:Button ID="Button4" runat="server" Text="Edit" />
            <asp:Button ID="Button5" runat="server" Text="Delete" />
        </p>
    </form>
</body>
</html>
