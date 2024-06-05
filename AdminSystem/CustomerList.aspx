<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click"  style="z-index: 1; left: 530px; top: 41px; position: absolute; height: 48px; width: 65px" Text="Delete" />
    <asp:ListBox ID="lstCustomerList" runat="server" Style="z-index: 1; left: 17px; top: 99px; position: absolute; height: 400px; width: 741px"></asp:ListBox>
    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 690px; top: 41px; position: absolute; height: 48px; width: 65px" Text="Edit" />
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 24px; top: 58px; position: absolute" Text="[lblError]"></asp:Label>
    <asp:Button runat="server" Text="Add" OnClick="BtnAdd_Click1" ID="BtnAdd_Click2" Style="z-index: 1; left: 610px; top: 41px; position: absolute; height: 48px; width: 65px"></asp:Button>
    <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 800px; top: 99px; position: absolute" Text="Apply Filter" />
    <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 900px; top: 99px; position: absolute" Text="Clear Filter" />
    <asp:Label ID="lblEnterLastName" runat="server" style="z-index: 1; left: 800px; top: 41px; position: absolute" Text="Enter the customers last name"></asp:Label>
    <asp:TextBox ID="txtFilterCustomerLastName" runat="server" style="z-index: 1; left: 800px; top: 70px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
