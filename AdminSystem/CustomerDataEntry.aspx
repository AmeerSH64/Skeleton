<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerNo" runat="server" Text="Customer Number"></asp:Label>
            <asp:TextBox ID="txtCustomerNo" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name" width="113px"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server" style="margin-top: 0px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerAddress" runat="server" Text="Address" width="113px"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
&nbsp;<p>
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth" width="113px"></asp:Label>
            <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price" width="113px"></asp:Label>
            <asp:TextBox ID="txtCustomerTotalPrice" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkOver18" runat="server" Text="Over 18?" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="61px" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
