<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="lblReviewId" runat="server" style="z-index: 1; left: 10px; top: 80px; position: absolute" Text="Review ID"></asp:Label>
    <asp:TextBox ID="txtReviewId" runat="server" style="z-index: 1; left: 150px; top: 80px; position: absolute"></asp:TextBox>
        
    <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 10px; top: 110px; position: absolute" Text="Customer Name"></asp:Label>
    <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 150px; top: 110px; position: absolute"></asp:TextBox>
        
    <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 10px; top: 140px; position: absolute" Text="Rating"></asp:Label>
    <asp:TextBox ID="txtRating" runat="server" style="z-index: 1; left: 150px; top: 140px; position: absolute"></asp:TextBox>
        
    <asp:Label ID="lblDateSubmitted" runat="server" style="z-index: 1; left: 10px; top: 170px; position: absolute" Text="Date Submitted"></asp:Label>
    <asp:TextBox ID="txtDateSubmitted" runat="server" style="z-index: 1; left: 150px; top: 170px; position: absolute"></asp:TextBox>
        
    <asp:Label ID="lblReviewDescription" runat="server" style="z-index: 1; left: 10px; top: 200px; position: absolute" Text="Review Description"></asp:Label>
    <asp:TextBox ID="txtReviewDescription" runat="server" style="z-index: 1; left: 150px; top: 200px; position: absolute"></asp:TextBox>
        
    <asp:Label ID="lblReviewTitle" runat="server" style="z-index: 1; left: 10px; top: 230px; position: absolute" Text="Review Title"></asp:Label>
    <asp:TextBox ID="txtReviewTitle" runat="server" Style="z-index: 1; left: 150px; top: 230px; position: absolute" ></asp:TextBox>
       
    <asp:CheckBox ID="chkIsApproved" runat="server" style="z-index: 1; left: 150px; top: 290px; position: absolute" Text="IsApproved" />
        
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 330px; position: absolute"></asp:Label>
        
    <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 80px; top: 380px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 10px; top: 380px; position: absolute" Text="OK" OnClick="btnOK_Click" />
    <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 340px; top: 80px; position: absolute" Text="Find" OnClick="btnFind_Click" />
        
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 193px; top: 378px; position: absolute" Text="Return to Main Menu" />
        
    </form>
</body>
</html>