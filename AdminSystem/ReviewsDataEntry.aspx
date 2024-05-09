<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the Review Data Entry Page
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblReviewId" runat="server" style="z-index: 1; left: 12px; top: 82px; position: absolute" Text="Review ID"></asp:Label>
        </div>
        <p>
            <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 8px; top: 110px; position: absolute" Text="Customer Name"></asp:Label>
        </p>
        <asp:TextBox ID="txtReviewID" runat="server" style="z-index: 1; left: 135px; top: 79px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 135px; top: 109px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtRating" runat="server" style="z-index: 1; left: 137px; top: 139px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblDateSubmitted" runat="server" style="z-index: 1; left: 8px; top: 177px; position: absolute" Text="Date Submitted"></asp:Label>
            <asp:TextBox ID="txtDateSubmitted" runat="server" style="z-index: 1; left: 141px; top: 176px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblReviewDescription" runat="server" style="z-index: 1; left: 8px; top: 207px; position: absolute" Text="Review Description"></asp:Label>
            <asp:TextBox ID="txtReviewDescription" runat="server" style="z-index: 1; left: 137px; top: 203px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 12px; top: 142px; position: absolute" Text="Rating"></asp:Label>
            <asp:Label ID="lblReviewTitle" runat="server" style="z-index: 1; left: 13px; top: 240px; position: absolute" Text="Review Title"></asp:Label>
            <asp:TextBox ID="txtReviewTitle" runat="server" style="z-index: 1; left: 136px; top: 239px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 149px; top: 320px; position: absolute" Text="Active" />
        </p>
        <asp:Label ID="lblIsApproved" runat="server" style="z-index: 1; left: 16px; top: 271px; position: absolute" Text="Is Approved"></asp:Label>
        <asp:TextBox ID="txtIsApproved" runat="server" style="z-index: 1; left: 135px; top: 269px; position: absolute"></asp:TextBox>
        <asp:Label ID="IblError" runat="server" style="z-index: 1; left: 18px; top: 358px; position: absolute"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 125px; top: 413px; position: absolute" Text="Cancel" />
        </p>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 10px; top: 414px; position: absolute" Text="OK" />
    </form>
</body>
</html>
