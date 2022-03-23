<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JavaStaff.aspx.cs" Inherits="JavaStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Staff ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffID" runat="server" Width="128px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="margin-left: 110px" Text="Find" Width="328px" />
            <br />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffName" runat="server" style="margin-left: 67px"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="DOB"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffDOB" runat="server" style="margin-left: 67px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="PhoneNo"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffPhoneNo" runat="server" style="margin-left: 67px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="HouseNo"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffHouseNo" runat="server" style="margin-left: 67px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="PostCode"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffPostCode" runat="server" style="margin-left: 67px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="StreetName"></asp:Label>
            <asp:TextBox ID="txtStaffStreet" runat="server" style="margin-left: 67px" Width="121px"></asp:TextBox>
        </p>
        <p>
           
            Date Added<asp:TextBox ID="txtDateAdded" runat="server" style="margin-left: 62px; margin-bottom: 0px" Width="115px"></asp:TextBox>
           
        </p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" Width="143px" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="193px" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
