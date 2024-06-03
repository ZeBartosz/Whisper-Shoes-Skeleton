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
        <asp:ListBox ID="lstCustomerList" runat="server" Style="z-index: 1; left: 17px; top: 99px; position: absolute; height: 400px; width: 741px"></asp:ListBox>
        <p>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 689px; top: 41px; position: absolute; height: 48px; width: 65px" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 24px; top: 58px; position: absolute" Text="[lblError]"></asp:Label>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click"  style="z-index: 1; left: 520px; top: 42px; position: absolute; height: 48px; width: 78px" Text="Delete" />
        </p>
        <p>
        <asp:Button runat="server" Text="Add" OnClick="BtnAdd_Click1" ID="BtnAdd_Click2" Style="z-index: 1; left: 610px; top: 41px; position: absolute; height: 48px; width: 69px" ></asp:Button>
        </p>
    </form>
</body>
</html>
