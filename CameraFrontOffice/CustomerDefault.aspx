﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDefault.aspx.cs" Inherits="CustomerDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstCustomers" runat="server" Height="162px" Width="199px" OnSelectedIndexChanged="lstCustomers_SelectedIndexChanged"></asp:ListBox>
        <br />
        Please Enter a First Name<br />
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="Button1_Click" />
            &nbsp;<asp:Button ID="btnDisplay" runat="server" Text="Display" />
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="36px" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" />
        </p>
    </form>
</body>
</html>