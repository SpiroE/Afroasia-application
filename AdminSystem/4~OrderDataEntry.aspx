<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4~OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 599px">
    &nbsp;<form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblOrderNo" runat="server" style="z-index: 1; left: 10px; top: 18px; position: absolute; right: 923px; height: 22px;" Text="Order Number"></asp:Label>
        </p>
        <asp:Label ID="lblCustomerID" runat="server" height="22px" style="z-index: 1; left: 10px; top: 55px; position: absolute; margin-top: 0px" Text="Customer ID"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" height="22px" style="z-index: 1; left: 9px; top: 92px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="lblProductID" runat="server" height="22px" style="z-index: 1; left: 10px; top: 129px; position: absolute; width: 65px;" Text="Product"></asp:Label>
        <asp:Label ID="lblNoOfCases" runat="server" height="22px" style="z-index: 1; left: 10px; top: 166px; position: absolute" Text="Number of Cases"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" height="22px" style="z-index: 1; left: 11px; top: 204px; position: absolute" Text="Date Added"></asp:Label>
        <asp:CheckBox ID="chkFulfilled" runat="server" style="z-index: 1; left: 12px; top: 241px; position: absolute" Text="Fulfilled" />
        <asp:TextBox ID="txtNoOfCases" runat="server" height="22px" style="z-index: 1; left: 172px; top: 163px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtProductID" runat="server" height="22px" style="z-index: 1; left: 172px; top: 128px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" height="22px" style="z-index: 1; left: 172px; top: 202px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddressID" runat="server" height="22px" style="z-index: 1; left: 171px; top: 91px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerID" runat="server" height="22px" style="z-index: 1; left: 171px; top: 52px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderNo" runat="server" height="22px" style="z-index: 1; left: 170px; top: 15px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 280px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 10px; top: 314px; position: absolute" Text="OK" width="77px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 93px; top: 314px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 347px; top: 18px; position: absolute; width: 49px" Text="Find" />
    </form>
</body>
</html>
