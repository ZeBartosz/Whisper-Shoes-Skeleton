<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 300px; width: 320px"></asp:ListBox>
        <asp:Button ID="btnAddNew" runat="server" OnClick="btnAddNew_Click" style="z-index: 1; left: 95px; top: 345px; position: absolute" Text="ADD" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 145px; top: 345px; position: absolute" Text="EDIT" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 200px; top: 345px; position: absolute" Text="DELETE" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 110px; top: 387px; position: absolute"></asp:Label>
    </form>
</body>
</html>

