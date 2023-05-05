<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerServiceList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 14px;
            top: 334px;
            position: absolute;
            right: 854px;
        }
        .auto-style2 {
            position: absolute;
            top: 334px;
            left: 70px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 335px;
            left: 121px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 451px;
            left: 5px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 450px;
            left: 78px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 567px;
            left: 16px;
            z-index: 1;
        }
    </style>
</head>
<body style="height: 588px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" CssClass="auto-style1" />
        <p>
            <asp:Button ID="btnEdit" runat="server" CssClass="auto-style2" Text="Edit" OnClick="btnEdit_Click1" />
        </p>
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style3" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style4" OnClick="btnApply_Click" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" CssClass="auto-style5" OnClick="btnClear_Click" Text="Clear" />
        <asp:Label ID="Label1" runat="server" CssClass="auto-style6" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
