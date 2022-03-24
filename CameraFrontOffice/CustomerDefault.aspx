<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDefault.aspx.cs" Inherits="CustomerDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" />
        <br />
        <br />
        Please Enter a First Name<br/>
        <div>
            <asp:TextBox ID="txtFName" runat="server" Width="199px"></asp:TextBox>
            <br />
            &nbsp;<asp:Button ID="Applybtn" runat="server" Text="Apply" OnClick="Applybtn_Click" BackColor="#FFCC99" BorderColor="#FF9933" Font-Bold="True" ForeColor="#CC6600" Width="91px" />
            &nbsp;<asp:Button ID="btnDisplay" runat="server" Text="Display" OnClick="btnDisplay_Click" BackColor="#FFCC99" BorderColor="#FF9933" Font-Bold="True" ForeColor="#CC6600" Width="100px" />
            <br />
        <asp:ListBox ID="lstCustomers" runat="server" Height="162px" Width="199px" BackColor="#FFCC99"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" BackColor="White" BorderColor="#99FFCC" BorderStyle="Solid" Font-Bold="True" Width="52px" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="57px" BorderColor="#CCCCCC" BorderStyle="Solid" Font-Bold="True" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" BorderColor="#FF3300" BorderStyle="Double" Font-Bold="True" Width="62px" />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
