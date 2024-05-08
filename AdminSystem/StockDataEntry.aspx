<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblStockId" runat="server" style="z-index: 1; left: 10px; top: 39px; position: absolute; right: 608px" Text="Stock ID"></asp:Label>
        <p>
            <asp:TextBox ID="txtStockId" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 141px; top: 38px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblStockName" runat="server" style="z-index: 1; left: 9px; top: 67px; position: absolute; height: 19px" Text="Stock Name"></asp:Label>
        <asp:TextBox ID="txtStockName" runat="server" style="z-index: 1; left: 141px; top: 65px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblStockDescription" runat="server" style="z-index: 1; left: 8px; top: 93px; position: absolute" Text="Stock Description"></asp:Label>
        <asp:TextBox ID="txtStockDescription" runat="server" style="z-index: 1; left: 7px; top: 117px; position: absolute; height: 94px; width: 254px"></asp:TextBox>
        <asp:Label ID="lblstockQuantity" runat="server" style="z-index: 1; left: 7px; top: 226px; position: absolute" Text="Stock Quantity"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtStockQuantity" runat="server" OnTextChanged="txtStockQuantity_TextChanged" style="z-index: 1; left: 141px; top: 225px; position: absolute; margin-bottom: 0px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
