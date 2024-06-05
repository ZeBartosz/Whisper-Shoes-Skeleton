<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewsConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 10px; top: 45px; position: absolute">Are you sure you want to delete this record?</asp:Label>

        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 80px; top: 90px; position: absolute" Text="Yes" OnClick="btnYes_Click"/>
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 160px; top: 90px; position: absolute" Text="No" OnClick="btnNo_Click"/>
    </form>
</body>
</html>
