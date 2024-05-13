<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 19px; top: 13px; position: absolute; " Text="Staff ID" height="19px" width="94px"></asp:Label>
        <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 19px; top: 86px; position: absolute" Text="Staff Email" height="19px" width="94px"></asp:Label>
        <asp:Label ID="lblStaffPassword" runat="server" style="z-index: 1; left: 19px; top: 120px; position: absolute" Text="Staff Password" height="19px" width="94px"></asp:Label>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 19px; position: absolute; top: 45px; bottom: 607px; width: 94px;" Text="Staff Name" height="19px"></asp:Label>
        <asp:Label ID="lblStaffStartDate" runat="server" style="z-index: 1; left: 19px; position: absolute; top: 161px" Text="Staff Start Date"></asp:Label>
        <asp:Label ID="lblStaffSalary" runat="server" style="z-index: 1; left: 19px; position: absolute; top: 199px" Text="Staff Salary" height="19px" width="94px"></asp:Label>
        <p>
            <asp:TextBox ID="txtStaffId" runat="server"  style="z-index: 1; left: 125px; top: 15px; position: absolute; width: 152px" height="18px"></asp:TextBox>
            <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 125px; top: 47px; position: absolute; width: 152px" height="18px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 125px; top: 88px; position: absolute; width: 152px; height: 18px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtStaffStartDate" runat="server" style="z-index: 1; left: 125px; top: 162px; position: absolute" height="18px" width="152px"></asp:TextBox>
            <asp:TextBox ID="txtStaffSalary" runat="server" style="z-index: 1; left: 125px; top: 199px; position: absolute; height: 18px;" width="152px"></asp:TextBox>
            <asp:TextBox ID="txtStaffPassword" runat="server" style="z-index: 1; left: 125px; top: 119px; position: absolute; width: 152px; height: 18px;" OnTextChanged="txtStaffPassword_TextChanged"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkStaffManager" runat="server" style="z-index: 1; left: 127px; top: 240px; position: absolute; width: 107px; margin-bottom: 0px;" Text="Staff Manager" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 277px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 39px; top: 313px; position: absolute" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 164px; top: 312px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
