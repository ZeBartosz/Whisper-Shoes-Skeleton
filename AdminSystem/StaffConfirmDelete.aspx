<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:TextBox ID="txtConfirm" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; width: 257px">Are you sure you want to delete this record?</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 164px; top: 66px; position: absolute" Text="No" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 59px; top: 66px; position: absolute" Text="Yes" />
        </p>
    </form>
</body>
</html>
