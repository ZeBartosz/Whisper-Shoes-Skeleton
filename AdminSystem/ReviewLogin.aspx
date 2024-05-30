<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewLogin.aspx.cs" Inherits="ReviewLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Review Login Page
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 100px; top: 80px; position: absolute" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 200px; top: 80px; position: absolute; width: 190px;"></asp:TextBox>

        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 100px; top: 110px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 200px; top: 110px; position: absolute; width: 189px;" TextMode="Password"></asp:TextBox>

        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 220px; top: 150px; position: absolute; right: 515px;" Text="Login" OnClick="btnLogin_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 320px; top: 150px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />

        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 250px; position: absolute" ForeColor="#FF3300"></asp:Label>


        </div>
    </form>
</body>
</html>
