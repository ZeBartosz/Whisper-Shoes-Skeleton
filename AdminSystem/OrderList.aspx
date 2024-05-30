<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" Height="243px" Width="488px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnAddNew" runat="server" OnClick="btnAddNew_Click" style="z-index: 1; left: 14px; top: 303px; position: absolute; width: 148px;" Text="ADD" />
        <asp:Label ID="lblShippingAddress" runat="server" style="z-index: 1; left: 15px; top: 359px; position: absolute; width: 233px;" Text="Enter a Shipping Address"></asp:Label>
        <asp:TextBox ID="txtShippingAddress" runat="server" style="z-index: 1; left: 275px; top: 358px; position: absolute; width: 219px;"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 38px; top: 468px; position: absolute; height: 16px; right: 525px;"></asp:Label>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 19px; top: 405px; position: absolute; width: 233px;" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 272px; top: 403px; position: absolute; width: 230px;" Text="Clear Filter" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 346px; top: 302px; position: absolute; width: 150px;" Text="DELETE" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 177px; top: 303px; position: absolute; width: 154px;" Text="EDIT" />
    </form>
</body>
</html>
