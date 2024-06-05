<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblErrorConfirmDelete" runat="server" style="z-index: 1; left: 50px; top: 32px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnConfirmDeleteNo" runat="server" OnClick="btnConfirmDeleteNo_Click" style="z-index: 1; left: 224px; top: 61px; position: absolute" Text="No" />
        <asp:Button ID="btnConfirmDeleteYes" runat="server" OnClick="btnConfirmDeleteYes_Click" style="z-index: 1; left: 71px; top: 61px; position: absolute" Text="Yes" />
    </form>
</body>
</html>
