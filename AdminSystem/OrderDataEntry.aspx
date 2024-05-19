<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
    <asp:Label ID="lblOrderId" runat="server" Text="Order ID"></asp:Label>
    <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
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
    <p>
        <asp:Label ID="lblOrderCompleted" runat="server" Text="Order Completed"></asp:Label>
        <asp:TextBox ID="txtOrderCompleted" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </p>
    <p>
        <asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
    </p>
    </form>

</body>
</html>


