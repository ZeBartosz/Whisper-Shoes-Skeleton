<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label ID="lblStockId" runat="server" style="z-index: 1; left: 10px; top: 39px; position: absolute; right: 608px" Text="Stock ID"></asp:Label>
        <asp:TextBox ID="txtStockId" runat="server" style="z-index: 1; left: 172px; top: 38px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" Style="z-index: 1; left: 375px; top: 38px; position: absolute" Text="FIND" OnClick="btnFind_Click" />


        <asp:Label ID="lblStockName" runat="server" style="z-index: 1; left: 11px; top: 67px; position: absolute; height: 19px" Text="Stock Name" width="154px"></asp:Label>
        <asp:TextBox ID="txtStockName" runat="server" style="z-index: 1; left: 172px; top: 65px; position: absolute"></asp:TextBox>

        <asp:Label ID="lblStockDescription" runat="server" style="z-index: 1; left: 11px; top: 93px; position: absolute" Text="Stock Description" width="154px"></asp:Label>
        <asp:TextBox ID="txtStockDescription" runat="server" style="z-index: 1; left: 7px; top: 117px; position: absolute; height: 94px; width: 272px"></asp:TextBox>
        <asp:Label ID="lblstockQuantity" runat="server" style="z-index: 1; left: 10px; top: 224px; position: absolute" Text="Stock Quantity" width="154px"></asp:Label>

        <asp:Label ID="lblStockRestockThreshold" runat="server" style="z-index: 1; left: 10px; top: 285px; position: absolute" Text="Stock Restock Threshold"></asp:Label>
        <asp:TextBox ID="txtStockRestockThreshold" runat="server" style="z-index: 1; left: 171px; top: 283px; position: absolute"></asp:TextBox>

        <asp:TextBox ID="txtStockQuantity" runat="server" style="z-index: 1; left: 171px; top: 225px; position: absolute; margin-bottom: 0px"></asp:TextBox>
        <asp:TextBox ID="txtStockLastRestocked" runat="server" style="z-index: 1; left: 171px; top: 255px; position: absolute"></asp:TextBox>

        <asp:CheckBox ID="chkStockAutoRestock" runat="server" style="z-index: 1; left: 69px; top: 317px; position: absolute" Text="Stock Auto Restock " />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 94px; top: 345px; position: absolute"></asp:Label>

        <asp:Label ID="lblStockLastRestocked" runat="server" style="z-index: 1; left: 10px; top: 255px; position: absolute" Text="Stock Last Restocked" width="154px"></asp:Label>

        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 66px; top: 390px; position: absolute" Text="OK" OnClick="btnAdd_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 133px; top: 390px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
