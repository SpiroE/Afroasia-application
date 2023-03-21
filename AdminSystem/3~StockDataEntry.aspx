<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3~StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>This is the stock entry page</h1>
        <div style="height: 410px">
            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 13px; top: 83px; position: absolute; height: 29px; width: 187px" Text="Product ID"></asp:Label>
            <asp:TextBox ID="txtProductID" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; top: 75px; position: absolute; width: 207px; left: 92px; height: 23px"></asp:TextBox>
            <asp:Label ID="lblProductName" runat="server" style="z-index: 1; left: 15px; top: 124px; position: absolute; width: 187px; height: 25px" Text="Product Name"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; top: 122px; position: absolute; width: 207px; left: 112px; height: 23px"></asp:TextBox>
            <asp:Label ID="lblStockQuantity" runat="server" style="z-index: 1; left: 13px; top: 169px; position: absolute; width: 187px; height: 27px" Text="Stock Quantity"></asp:Label>
            <asp:Label ID="lblStockArrivalDate" runat="server" style="z-index: 1; left: 14px; top: 212px; position: absolute; width: 187px; height: 25px; right: 1284px" Text="Stock Arrival Date"></asp:Label>
            <asp:Label ID="lblTrackingID" runat="server" style="z-index: 1; left: 14px; top: 266px; position: absolute; width: 187px; height: 25px" Text="Tracking ID"></asp:Label>
            <asp:TextBox ID="txtStockQuantity" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; top: 168px; position: absolute; width: 207px; left: 119px; height: 23px; bottom: 678px"></asp:TextBox>
            <asp:TextBox ID="txtStockArrivalDate" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; top: 213px; position: absolute; width: 207px; left: 144px; height: 23px; right: 1126px"></asp:TextBox>
            <asp:TextBox ID="txtTrackingID" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; top: 261px; position: absolute; width: 207px; height: 23px; left: 108px"></asp:TextBox>
            <asp:CheckBox ID="chkProductAvailability" runat="server" style="z-index: 1; left: 13px; top: 306px; position: absolute; right: 1293px; height: 22px" Text="Product Availability" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 341px; position: absolute; width: 137px; height: 25px; right: 1334px"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 100px; top: 378px; position: absolute; width: 73px" Text="Cancel" />
            <asp:Button ID="btnOK" runat="server" height="26px" OnClick="btnOK_Click1" style="z-index: 1; left: 26px; top: 378px; position: absolute" Text="OK" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
