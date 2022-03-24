<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDefault.aspx.cs" Inherits="CustomerDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 285px;
            height: 193px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <img alt="" class="auto-style2" longdesc="http://localhost:10734/App_Code/Logo.png" src="file:///H:/IMAT2204%20Project%20Management%20Development/LastClone/CameraFrontOffice/App_Code/Logo.png" /><br />
        <br />
            <strong>Please Enter a First Name</strong><br/>
        </div>
        <div class="auto-style1">
            <asp:TextBox ID="txtFName" runat="server" Width="199px"></asp:TextBox>
            <br />
            &nbsp;<asp:Button ID="Applybtn" runat="server" Text="Apply" OnClick="Applybtn_Click" BackColor="#FFCC99" BorderColor="#FF9933" Font-Bold="True" ForeColor="#CC6600" Width="91px" />
            &nbsp;<asp:Button ID="btnDisplay" runat="server" Text="Display" OnClick="btnDisplay_Click" BackColor="#FFCC99" BorderColor="#FF9933" Font-Bold="True" ForeColor="#CC6600" Width="100px" />
            <br />
            <br />
        <asp:ListBox ID="lstCustomers" runat="server" Height="162px" Width="488px" BackColor="White" style="font-style: italic"></asp:ListBox>
        </div>
        <p class="auto-style1">
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" BackColor="White" BorderColor="#99FFCC" BorderStyle="Solid" Font-Bold="True" Width="81px" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="88px" BorderColor="#CCCCCC" BorderStyle="Solid" Font-Bold="True" OnClick="btnEdit_Click1" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" BorderColor="#FF3300" BorderStyle="Solid" Font-Bold="True" Width="88px" />
            &nbsp;
            <asp:Label ID="lblError" runat="server" ForeColor="#FF9933" style="font-weight: 700; font-style: italic; text-decoration: underline"></asp:Label>
        </p>
    </form>
</body>
</html>
