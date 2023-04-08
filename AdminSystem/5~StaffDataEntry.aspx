<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5~StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 14px; top: 73px; position: absolute; bottom: 1143px" Text="Staff ID" width="130px"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 78px; top: 70px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 14px; top: 103px; position: absolute" Text="Staff Name " width="130px"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 96px; top: 102px; position: absolute; margin-top: 0px"></asp:TextBox>
        <asp:Label ID="lblStaffPhoneNo" runat="server" style="z-index: 1; left: 15px; top: 134px; position: absolute" Text="Staff Phone No" width="130px"></asp:Label>
        <asp:TextBox ID="txtStaffPhoneNo" runat="server" style="z-index: 1; left: 125px; top: 134px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPayroll" runat="server" style="z-index: 1; left: 15px; top: 166px; position: absolute; right: 961px" Text="Payroll" width="130px"></asp:Label>
        <asp:TextBox ID="txtPayroll" runat="server" style="z-index: 1; left: 73px; top: 166px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblSchedule" runat="server" style="z-index: 1; left: 16px; top: 198px; position: absolute" Text="Schedule" width="130px"></asp:Label>
        <asp:TextBox ID="txtSchedule" runat="server" style="z-index: 1; left: 84px; top: 199px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblAttendance" runat="server" style="z-index: 1; left: 16px; top: 232px; position: absolute" Text="Attendance" width="130px"></asp:Label>
        <asp:TextBox ID="txtAttendance" runat="server" style="z-index: 1; left: 98px; top: 233px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkShiftConfirmation" runat="server" style="z-index: 1; left: 15px; top: 263px; position: absolute" Text="Shift Confirmation" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 304px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 15px; top: 336px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 60px; top: 337px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
