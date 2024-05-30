<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Style="z-index: 1; left: 17px; top: 99px; position: absolute; height: 400px; width: 741px" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged"></asp:ListBox>
        <p>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 689px; top: 41px; position: absolute; height: 48px; width: 65px" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
        <p>
        <asp:Button runat="server" Text="Add" OnClick="BtnAdd_Click1" ID="BtnAdd_Click2" Style="z-index: 1; left: 610px; top: 41px; position: absolute; height: 48px; width: 69px" ></asp:Button>
        </p>
    </form>
</body>
</html>
