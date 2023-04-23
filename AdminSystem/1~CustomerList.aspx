<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1~CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="289px" Width="338px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" Height="22px" OnClick="btnAdd_Click" Text="Add" Width="46px" />
        <asp:Button ID="btnEdit" runat="server" height="22px" OnClick="btnEdit_Click" Text="Edit" width="46px" />
        <asp:Button ID="btnDelete" runat="server" height="22px" OnClick="btnDelete_Click" Text="Delete" width="56px" />
        <br />
        <br />
        Enter a Name<asp:TextBox ID="txtFilter" runat="server" Height="16px" style="margin-left: 7px; margin-top: 1px" Width="123px"></asp:TextBox>
        <p>
            <asp:Button ID="btnApply" runat="server" height="22px" OnClick="btnApply_Click" Text="Apply" width="46px" />
            <asp:Button ID="btnClear" runat="server" height="22px" OnClick="btnClear_Click" Text="Clear" width="46px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
