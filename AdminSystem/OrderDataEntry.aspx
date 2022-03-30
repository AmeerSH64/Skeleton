<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <asp:Label ID="lblOrderNumber" runat="server" Text="OrderNumber" width="138px"></asp:Label>
        <asp:TextBox ID="txtOrderNumber" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <br />
        <asp:Label ID="lblTrackingNumber" runat="server" Text="Tracking Number"></asp:Label>
        <asp:TextBox ID="txtTrackingNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblProductName" runat="server" Text="Product Name" width="138px"></asp:Label>
        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="138px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name" width="138px"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="138px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkConfirmOrder" runat="server" Text="Confirm Order" />
        <br />
        <br />
        [<asp:Label runat="server" Text="lblError"></asp:Label>
        ]<br />
        <br />
        <asp:Button ID="btnOK" runat="server" Height="25px" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>