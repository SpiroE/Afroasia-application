<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3~StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 411px">
            <asp:ListBox ID="lstStockList" runat="server" Height="195px" Width="572px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged"></asp:ListBox>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 20px; top: 276px; position: absolute; width: 150px; height: 26px" Text="Enter a Product Name"></asp:Label>
            <asp:TextBox ID="txtFilterProd" runat="server" style="z-index: 1; left: 171px; top: 271px; position: absolute; width: 273px; height: 27px"></asp:TextBox>
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 96px; top: 319px; position: absolute" Text="Clear" />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 22px; top: 319px; position: absolute" Text="Apply" />
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 14px; top: 220px; position: absolute; width: 62px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 92px; top: 221px; position: absolute; width: 55px" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 19px; top: 375px; position: absolute; width: 115px"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 169px; top: 221px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
