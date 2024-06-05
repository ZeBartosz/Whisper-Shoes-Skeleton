<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstReviewList" runat="server" Height="200px" Width="300px"></asp:ListBox>

        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 10px; top: 270px; position: absolute" Text="Add" OnClick="btnAdd_Click"/>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 80px; top: 270px; position: absolute" Text="Edit" OnClick="btnEdit_Click"/>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 160px; top: 270px; position: absolute" Text="Delete" OnClick="btnDelete_Click"/>

        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 10px; top: 330px; position: absolute" Text="Enter a Customer Name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" Style="z-index: 1; left: 200px; top: 330px; position: absolute" ></asp:TextBox>

        <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 10px; top: 380px; position: absolute" Text="Apply Filter" OnClick="btnApplyFilter_Click"/>
        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 160px; top: 380px; position: absolute" Text="Clear Filter" OnClick="btnClearFilter_Click"/>

        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 420px; position: absolute"></asp:Label>
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 310px; top: 381px; position: absolute" Text="Return to Main Menu" />
    </form>
</body>
</html>
