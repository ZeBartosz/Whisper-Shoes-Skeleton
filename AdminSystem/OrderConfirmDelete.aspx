<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="lblMsg" runat="server" Text="Want to delete this Order ?"></asp:Label>
            <br />
        </div>
        <asp:Button ID="btnYES" runat="server" OnClick="btnYES_Click" Text="YES" />
        <asp:Button ID="btnNO" runat="server" OnClick="btnNO_Click" Text="NO" />
    </form>
</body>
</html>
