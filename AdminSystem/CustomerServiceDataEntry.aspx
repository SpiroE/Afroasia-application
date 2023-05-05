<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerServiceDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            z-index: 1;
            left: 55px;
            top: 186px;
            position: absolute;
            width: 98px;
        }
    </style>
</head>
<body style="height: 164px">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtIssueID" runat="server" style="z-index: 1; left: 138px; top: 14px; position: absolute"></asp:TextBox>
            <asp:Label ID="IssueID" runat="server" style="z-index: 1; left: 10px; top: 12px; position: absolute" Text="Issue ID"></asp:Label>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 332px; top: 15px; position: absolute" Text="Find" />
            <br />
            <asp:Label ID="CustomerID" runat="server" style="z-index: 1; left: 11px; top: 32px; position: absolute" Text="Customer ID"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 138px; top: 36px; position: absolute"></asp:TextBox>
            <br />
             <asp:Label ID="LabelProductId" runat="server" style="z-index: 1; left: 10px; top: 55px; position: absolute" Text="Product ID"></asp:Label>
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 138px; top: 55px; position: absolute"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtIssue" runat="server" style="z-index: 1; left: 138px; top: 75px; position: absolute"></asp:TextBox>
            <asp:Label ID="Issue" runat="server" style="z-index: 1; left: 10px; top: 72px; position: absolute" Text="Issue"></asp:Label>
            <br />
            <asp:TextBox ID="txtIssueDate" runat="server" style="z-index: 1; left: 138px; top: 95px; position: absolute"></asp:TextBox>
            <asp:Label ID="IssueDate" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Issue Date"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 148px; position: absolute"></asp:Label>
            <br />
            <br /> 
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" Text="OK" Width="33px"  />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" style="margin-left: 26px" />
           
            <br />
            <asp:CheckBox ID="chkReturnEligibility" runat="server" style="z-index: 1; left: 10px; top: 110px; position: absolute" Text="Return Eligibility" />
            <br />
        </div>
    </form>
</body>
</html>
