﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
    <asp:Label ID="lblOrderId" runat="server" Text="Order ID"></asp:Label>
    <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
        <asp:Button runat="server" Text="Find" ID="btnFind" OnClick="btnFind_Click"></asp:Button>
    <p>
        <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblItemId" runat="server" Text="Item ID"></asp:Label>
        <asp:TextBox ID="txtItemId" runat="server"></asp:TextBox>
    </p>
    <asp:Label ID="lblOrderDate" runat="server" Text="Order Date"></asp:Label>
    <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
    <p>
        <asp:Label ID="lblTotalAmount" runat="server" Text="Total Amount"></asp:Label>
        <asp:TextBox ID="txtTotalAmount" runat="server"></asp:TextBox>
    </p>
    <asp:Label ID="lblShippingAddress" runat="server" Text="Shipping Address"></asp:Label>
    <asp:TextBox ID="txtShippingAddress" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
    <p>
        <asp:CheckBox ID="chkOrderCompleted" runat="server" Text="Order Completed"  />
    </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="Return To Main Menu" />
    </p>
    <p>
        <asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
    </p>
    </form>

</body>
</html>


