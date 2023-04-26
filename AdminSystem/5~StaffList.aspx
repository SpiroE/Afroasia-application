<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5~StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="233px" Width="262px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" height="26px" OnClick="btnEdit_Click" style="z-index: 1; left: 47px; top: 267px; position: absolute" Text="Edit" width="37px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 83px; top: 267px; position: absolute; width: 52px; right: 760px" Text="Delete" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 391px; position: absolute"></asp:Label>
        <asp:Label ID="lblEnterStaffName" runat="server" style="z-index: 1; left: 10px; top: 316px; position: absolute" Text="Enter a Staff Name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 135px; top: 315px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 11px; top: 351px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 60px; top: 351px; position: absolute" Text="Clear" />
    </form>
</body>
</html>
