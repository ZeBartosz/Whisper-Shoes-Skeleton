<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 186px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblCustomer_id" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Customer ID"></asp:Label>
            <asp:TextBox ID="txtCustomer_id" runat="server"  style="z-index: 1; left: 161px; top: 17px; position: absolute; height: 14px; width: 198px; margin-bottom: 0px"></asp:TextBox>
            <asp:TextBox ID="txtCustomerFirstName" runat="server" style="z-index: 1; left: 160px; top: 46px; position: absolute; height: 14px; width: 198px"></asp:TextBox>
        </div>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblCustomerFirstName" runat="server" style="z-index: 1; left: 9px; top: 43px; position: absolute" Text="Customer First Name"></asp:Label>
        <asp:Label ID="lblCustomerLastName" runat="server" style="z-index: 1; left: 8px; top: 70px; position: absolute" Text="Customer Last Name"></asp:Label>
        <asp:TextBox ID="txtCustomerLastName" runat="server" style="z-index: 1; left: 160px; top: 71px; position: absolute; width: 198px; height: 14px"></asp:TextBox>
        <asp:Label ID="lblCustomerDOB" runat="server" style="z-index: 1; left: 9px; top: 95px; position: absolute; height: 18px" Text="Date of birth"></asp:Label>
        <asp:TextBox ID="txtCustomerDOB" runat="server" style="z-index: 1; left: 159px; top: 96px; position: absolute; width: 198px; height: 14px"></asp:TextBox>
        <asp:Label ID="lblCustomePhoneNmbr" runat="server" style="z-index: 1; left: 11px; top: 121px; position: absolute" Text="Phone Number"></asp:Label>
        <p>
            <asp:TextBox ID="txtCustomerDOB0" runat="server" style="z-index: 1; left: 160px; top: 96px; position: absolute; width: 198px; height: 14px"></asp:TextBox>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 158px; top: 119px; position: absolute; width: 198px; height: 14px"></asp:TextBox>
        </p>
        <asp:Label ID="lblSavePaymentInfo" runat="server" style="z-index: 1; left: 11px; top: 172px; position: absolute; height: 19px" Text="Save Payment info"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 157px; top: 142px; position: absolute; width: 198px; height: 14px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 160px; top: 172px; position: absolute; width: 22px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 206px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 52px; top: 238px; position: absolute" Text="Cancel" />
        <p>
            <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" style="z-index: 1; left: 6px; top: 237px; position: absolute" Text="OK" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 12px; top: 146px; position: absolute; height: 20px" Text="Address"></asp:Label>
    </form>
</body>
</html>
