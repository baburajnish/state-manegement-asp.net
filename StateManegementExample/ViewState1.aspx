<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState1.aspx.cs" Inherits="StateManegementExample.ViewState1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
