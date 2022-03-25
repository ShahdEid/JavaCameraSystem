<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JavaStaffDelete.aspx.cs" Inherits="JavaStaffDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to dedelte this staff</div>
        <asp:Button ID="btnStaffYes" runat="server" OnClick="btnStaffYes_Click" Text="Yes" Width="153px" />
        <asp:Button ID="btnStaffNo" runat="server" style="margin-left: 114px" Text="No" Width="207px" />
    </form>
</body>
</html>
