﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Whisper Shoes Main</title>
</head>
<body id="lblMainMenu">
    <form id="form1" runat="server">
        <asp:Label ID="lblMainMenu" runat="server" style="z-index: 1; left: 120px; top: 31px; position: absolute" Text="Whisper Shoes Main Menu"></asp:Label>       
        <asp:Button ID="btnStock" runat="server" style="z-index: 1; left: 60px; top: 78px; position: absolute" Text="Stock" OnClick="btnStock_Click" />
        <asp:Button ID="btnStaff" runat="server" style="z-index: 1; left: 129px; top: 78px; position: absolute" Text="Staff" OnClick="btnStaff_Click" />
        <asp:Button ID="btnCustomer" runat="server" Style="z-index: 1; left: 188px; top: 78px; position: absolute" Text="Customer" OnClick="btnCustomer_Click" />
        <asp:Button ID="btnOrder" runat="server" style="z-index: 1; left: 288px; top: 78px; position: absolute" Text="Order" OnClick="btnOrder_Click" />
        <asp:Button ID="btnReviews" runat="server" style="z-index: 1; left: 347px; top: 78px; position: absolute" Text="Reviews" OnClick="btnReviews_Click" />       

    </form>
</body>
</html>
