<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 265px;
            height: 191px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <img class="auto-style2" src="file:///H:/IMAT2204%20Project%20Management%20Development/LastClone/CameraFrontOffice/App_Code/Logo.png" />&nbsp;<br />
            <br />
            <strong>ID</strong>&nbsp; <asp:TextBox ID="txtID" runat="server" BackColor="White" style="font-weight: 700"></asp:TextBox>
            &nbsp;<asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" BackColor="#FFCC99" BorderColor="#FF9933" Font-Bold="True" ForeColor="#CC6600" Width="88px" BorderStyle="Double" />
        </div>
        <p class="auto-style1">
            <strong>Last Name&nbsp;&nbsp; <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </strong>
        </p>
        <p class="auto-style1">
            <strong>First Name&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            </strong>
        </p>
        <p class="auto-style1">
            <strong>Date of Birth&nbsp; <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
            </strong>
        </p>
        <p class="auto-style1">
            <strong>Phone Number&nbsp; </strong> <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            <strong>Post Code&nbsp;&nbsp; <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
            </strong>
        </p>
        <p class="auto-style1">
            <strong>Payment Type&nbsp; <asp:DropDownList ID="DropDownPayment" runat="server">
                <asp:ListItem>Credit Card</asp:ListItem>
                <asp:ListItem>Debit Card</asp:ListItem>
                <asp:ListItem>Visa</asp:ListItem>
                <asp:ListItem>Mastercard</asp:ListItem>
                <asp:ListItem>American Express</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF9933" style="font-style: italic; text-decoration: underline"></asp:Label>
            </strong>
        </p>
        <p class="auto-style1">
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Font-Bold="True" Width="116px" BorderColor="#0099FF" BorderStyle="Double" ForeColor="#0099FF" />
            &nbsp;&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" Font-Bold="True" Width="146px" BorderColor="Black" BorderStyle="Double" />
        </p>
    </form>
</body>
</html>
