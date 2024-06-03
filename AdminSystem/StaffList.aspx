<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstStaffList" runat="server" Height="387px" Width="761px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" /><asp:Label runat="server" Text="lblError" ID="lblError"></asp:Label>
        </p>
        <asp:Label runat="server" Text="Enter a Staff Name :" ID="lblEnterFilter"></asp:Label>
        <asp:TextBox runat="server" ID="txtFilter"></asp:TextBox>
        
        <asp:Button runat="server" Text="Apply Filter" ID="btnApply" OnClick="btnApply_Click"></asp:Button>
        <asp:Button runat="server" Text="Clear Filter" ID="btnClear" OnClick="btnClear_Click"></asp:Button>
    </form>
</body>
</html>
