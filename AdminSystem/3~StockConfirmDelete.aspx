<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3~StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 157px">
            Are you sure you want to delete this record<br />
            <br />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 85px; top: 63px; position: absolute; " Text="No" />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 20px; top: 64px; position: absolute" Text="Yes" />
        </div>
    </form>
</body>
</html>
