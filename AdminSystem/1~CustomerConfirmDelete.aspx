<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1~CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you would like to delete this record? (You cannot undo the changes once the process is complete)<br />
            <br />
            <asp:Button ID="btnYes" runat="server" height="20px" OnClick="btnYes_Click" Text="Yes" width="33px" />
            <asp:Button ID="btnNo" runat="server" height="20px" OnClick="btnNo_Click" Text="No" width="33px" />
        </div>
    </form>
</body>
</html>
