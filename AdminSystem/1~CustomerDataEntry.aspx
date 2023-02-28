<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1~CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" height="19px" Text="Customer ID" width="150px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblCustomerName" runat="server" height="19px" Text="Customer Name" width="150px"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerPhoneNo" runat="server" height="19px" Text="Customer Phone No" width="150px"></asp:Label>
        <asp:TextBox ID="txtCustomerPhoneNo" runat="server"></asp:TextBox>
        <asp:Label ID="lblFormatExamplePhoneNo" runat="server" Text="+441122334455 - USE AREA CODE"></asp:Label>
        <br />
        <asp:Label ID="lblCustomerEmail" runat="server" height="19px" Text="Customer Email" width="150px"></asp:Label>
        <asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerPass" runat="server" height="19px" Text="Customer Password" width="150px"></asp:Label>
        <asp:TextBox ID="txtCustomerPass" runat="server"></asp:TextBox>
        <asp:Label ID="lblFormatExamplePass" runat="server" Text="50 Character Limit"></asp:Label>
        <br />
        <asp:Label ID="lblAccountCreationDate" runat="server" height="19px" Text="Account Creation Date" width="150px" Font-Bold="False" Font-Italic="False"></asp:Label>
        <asp:TextBox ID="txtAccountCreationDate" runat="server"></asp:TextBox>
        <asp:Label ID="lblFormatExampleDate" runat="server" Text="dd/mm/yyyy"></asp:Label>
        <br />
        <asp:CheckBox ID="chkAccountChecker" runat="server" Text="Active" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="56px" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
