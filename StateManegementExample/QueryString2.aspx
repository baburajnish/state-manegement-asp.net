<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryString2.aspx.cs" Inherits="StateManegementExample.QueryString2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblEno" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblEname" runat="server"></asp:Label>
        <br />
        <asp:LinkButton ID="LinkPrev" runat="server" OnClick="LinkPrev_Click">Prev</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
