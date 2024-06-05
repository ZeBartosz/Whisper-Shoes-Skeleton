<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lbltitle" runat="server" Text="Customer Login Page" style="z-index: 1; left: 50px; top: 58px; position: absolute"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" Text="UserName:" style="z-index: 1; left: 20px; top: 120px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 100px; top: 120px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" Text="Password:" style="z-index: 1; left: 20px; top: 150px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" style="z-index: 1; left: 100px; top: 150px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" style="z-index: 1; left: 100px; top: 180px; position: absolute" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" style="z-index: 1; left: 160px; top: 180px; position: absolute" />
        <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 100px; top: 210px; position: absolute" ForeColor="#FF3300" ></asp:Label>
    </form>
</body>
</html>
