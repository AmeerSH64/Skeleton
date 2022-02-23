<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSupplierNo" runat="server" Text="Supplier No." width="119px"></asp:Label>
            <asp:TextBox ID="txtSupplierNo" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblProductName" runat="server" Text="Product Name" width="119px"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblProductPrice" runat="server" Text="Product Price" width="119px"></asp:Label>
        <asp:TextBox ID="txtProductPrice" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateAvailable" runat="server" Text="Date Avaiable" width="119px"></asp:Label>
            <asp:TextBox ID="txtDateAvailable" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkIsAvaiable" runat="server" Text="Is Available" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
