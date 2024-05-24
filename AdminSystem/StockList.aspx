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
        <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 17px; top: 35px; position: absolute; height: 300px; width: 320px"></asp:ListBox>
        <asp:Button ID="btnAddNew" runat="server" OnClick="btnAddNew_Click" style="z-index: 1; left: 71px; top: 345px; position: absolute; right: 507px;" Text="ADD" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 133px; top: 345px; position: absolute" Text="EDIT" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 193px; top: 345px; position: absolute" Text="DELETE" />
        <asp:Label ID="lblEnterStockName" runat="server" style="z-index: 1; left: 21px; top: 386px; position: absolute" Text="Enter a Stock Name"></asp:Label>
        <asp:TextBox ID="txtFilterStockName" runat="server" style="z-index: 1; left: 163px; top: 385px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 19px; top: 478px; position: absolute; height: 16px; right: 544px;"></asp:Label>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 45px; top: 424px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 165px; top: 424px; position: absolute" Text="Clear Filter" />
    </form>
</body>
</html>

