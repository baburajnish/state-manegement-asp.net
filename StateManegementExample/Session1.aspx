<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session1.aspx.cs" Inherits="StateManegementExample.Session1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
        <div>
            User Nme :  <asp:TextBox ID="txtUid" runat="server"></asp:TextBox>
        </div>
        <div>
             Password : <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
             <asp:Label ID="lblError" runat="server"  ForeColor="Red"></asp:Label>
        </div>
       
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
          <asp:Button ID="btnGo" runat="server" Text="GotoUser" OnClick="btnGo_Click"/>
    
    </div>
    </form>
</body>
</html>
