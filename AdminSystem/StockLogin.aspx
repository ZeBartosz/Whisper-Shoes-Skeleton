<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="StockLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lbltitle" runat="server" Text="Stock LoginPage" ></asp:Label>   
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 12px; top: 44px; position: absolute; right: 1430px" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 121px; top: 44px; position: absolute"></asp:TextBox>        
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 121px; top: 71px; position: absolute" TextMode="Password"></asp:TextBox>       
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 38px; top: 102px; position: absolute; " Text="Login" OnClick="btnLogin_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 120px; top: 102px; position: absolute; " Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 12px; top: 71px; position: absolute; right: 1435px" Text="Password:"></asp:Label>    
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 73px; top: 139px; position: absolute; right: 1211px" ></asp:Label>       

    </form>
</body>
</html>
