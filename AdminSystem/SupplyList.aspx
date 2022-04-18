<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstSupplierList" runat="server" Height="251px" Width="344px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        </p>
    </form>
</body>
</html>
