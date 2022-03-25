<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JavaStaffView.aspx.cs" Inherits="JavaStaffView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstStaff" runat="server" Height="207px" Width="297px"></asp:ListBox>
        <div>
        </div>
        <p>
        <asp:TextBox ID="txtStaffName" runat="server" Width="214px" style="z-index: 1; left: 10px; top: 304px; position: absolute"></asp:TextBox>
            Enter the details to To Find Staff</p>
        <p>
            &nbsp;</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnStaffApply" runat="server" style="z-index: 1; left: 10px; top: 339px; position: absolute; right: 1211px;" Text="Apply" />
            <asp:Button ID="btnStaffDisplayAll" runat="server" style="width: 189px; z-index: 1; left: 179px; top: 339px; position: absolute" Text="Display All" />
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnStaffAdd" runat="server" style="z-index: 1; left: 11px; top: 411px; position: absolute; width: 147px; height: 23px;" Text="Add" OnClick="btnAdd_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnStaffEdit" runat="server" OnClick="btnStaffEdit_Click" Text="Edit" Width="147px" />
        </p>
        <p>
            <asp:Button ID="btnStaffDelete" runat="server" OnClick="btnStaffDelete_Click" Text="Delete" Width="145px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
