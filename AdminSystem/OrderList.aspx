﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" Height="267px" Width="335px"></asp:ListBox>
        </div>
        <asp:Button ID="bntAdd" runat="server" OnClick="bntAdd_Click" Text="Add" />
    </form>
</body>
</html>
