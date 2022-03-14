<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID&nbsp; <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <p>
            Last Name&nbsp;&nbsp; <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        </p>
        <p>
            First Name&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </p>
        <p>
            Date of Birth&nbsp; <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        </p>
        <p>
            Phone Number&nbsp; +44 <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        </p>
        <p>
            Post Code&nbsp;&nbsp; <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
        </p>
        <p>
            Payment Type&nbsp; <asp:DropDownList ID="DropDownPayment" runat="server">
                <asp:ListItem>Credit Card</asp:ListItem>
                <asp:ListItem>Debit Card</asp:ListItem>
                <asp:ListItem>Visa</asp:ListItem>
                <asp:ListItem>Mastercard</asp:ListItem>
                <asp:ListItem>American Express</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            &nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        &nbsp;</p>
    </form>
</body>
</html>
