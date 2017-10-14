<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session2.aspx.cs" Inherits="StateManegementExample.Session2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
    </div>
    </form>
</body>
</html>
