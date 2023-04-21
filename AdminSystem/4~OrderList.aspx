<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4~OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; height: 400px; width: 596px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 453px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 68px; top: 453px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 126px; top: 453px; position: absolute" Text="Delete" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 640px; position: absolute"></asp:Label>
        </p>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 10px; top: 575px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 85px; top: 575px; position: absolute" Text="Clear" />
        <asp:Label ID="lblFulfilledMessage" runat="server" style="z-index: 1; left: 10px; top: 515px; position: absolute; width: 202px" Text="Enter the fullfilled status"></asp:Label>
        <asp:TextBox ID="txtFulfilledInput" runat="server" style="z-index: 1; left: 229px; top: 514px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
