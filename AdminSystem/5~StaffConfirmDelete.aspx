<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5~StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="txtDelete" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Are you sure you would like to delete this record?"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnNo" runat="server" height="26px" OnClick="btnNo_Click" style="z-index: 1; left: 46px; top: 47px; position: absolute" Text="No" width="37px" />
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 9px; top: 47px; position: absolute; right: 644px" Text="Yes" />
    </form>
</body>
</html>
