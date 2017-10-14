<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryString1.aspx.cs" Inherits="StateManegementExample.QueryString1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       Employee Number : <asp:TextBox ID="txtEno" runat="server"></asp:TextBox>
        <br />
       Employee Name : <asp:TextBox ID="txtEname" runat="server"></asp:TextBox>
        <br />
       <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </div>
    </form>
</body>
</html>
