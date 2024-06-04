<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 38px; top: 14px; position: absolute; height: 23px; width: 105px" Text="Staff Login Page"></asp:Label>
        </p>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 43px; top: 63px; position: absolute; width: 73px" Text="UserName:"></asp:Label>
        <p>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 46px; top: 97px; position: absolute; height: 21px" Text="Password:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 127px; top: 64px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 127px; top: 98px; position: absolute" TextMode="Password"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 303px; top: 82px; position: absolute; height: 21px; width: 98px"></asp:Label>
        </p>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 58px; top: 141px; position: absolute" Text="Login" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 185px; top: 142px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>
