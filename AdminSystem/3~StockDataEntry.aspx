<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3~StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Button1 {
            z-index: 1;
            left: 407px;
            top: 84px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1>This is the stock entry page</h1>
        <div style="height: 410px">
            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 13px; top: 83px; position: absolute; height: 29px; width: 187px" Text="Product ID"></asp:Label>
            <asp:Label ID="lblProductName" runat="server" style="z-index: 1; left: 15px; top: 124px; position: absolute; width: 187px; height: 25px" Text="Product Name"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; top: 121px; position: absolute; width: 313px; left: 111px; height: 23px"></asp:TextBox>
            <asp:Label ID="lblStockQuantity" runat="server" style="z-index: 1; left: 13px; top: 169px; position: absolute; width: 187px; height: 27px" Text="Stock Quantity"></asp:Label>
            <asp:Label ID="lblStockArrivalDate" runat="server" style="z-index: 1; left: 14px; top: 212px; position: absolute; width: 187px; height: 25px; " Text="Stock Arrival Date"></asp:Label>
            <asp:Label ID="lblTrackingID" runat="server" style="z-index: 1; left: 18px; top: 256px; position: absolute; width: 187px; height: 25px" Text="Tracking ID"></asp:Label>
            <asp:TextBox ID="txtStockQuantity" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; top: 168px; position: absolute; width: 50px; left: 121px; height: 23px; bottom: 380px"></asp:TextBox>
            <asp:TextBox ID="txtStockArrivalDate" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; top: 208px; position: absolute; width: 207px; left: 146px; height: 23px; right: 790px"></asp:TextBox>
            <asp:TextBox ID="txtTrackingID" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; top: 251px; position: absolute; width: 50px; height: 23px; left: 101px"></asp:TextBox>
            <asp:CheckBox ID="chkProductAvailability" runat="server" style="z-index: 1; left: 28px; top: 317px; position: absolute; right: 1079px; height: 22px" Text="Product Availability" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 28px; top: 403px; position: absolute; width: 137px; height: 25px; right: 986px"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 103px; top: 443px; position: absolute; width: 73px" Text="Cancel" />
            <asp:Button ID="btnOK" runat="server" height="26px" OnClick="btnOK_Click1" style="z-index: 1; left: 24px; top: 443px; position: absolute; right: 1145px;" Text="OK" />
            <asp:TextBox ID="txtProductID" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; top: 82px; position: absolute; width: 48px; left: 93px; height: 23px; bottom: 466px;"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" style="position: absolute; top: 85px; left: 194px; height: 29px;" Text="Find" OnClick="btnFind_Click" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
