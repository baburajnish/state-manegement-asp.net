<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenField1.aspx.cs" Inherits="StateManegementExample.HiddenField1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="scripts/jquery-3.2.1.min.js"></script>
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                Enter Employee Name :
                <asp:TextBox ID="txtEname" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                Enter Salary :
                <asp:TextBox ID="txtEsal" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </div>

            <asp:Label ID="lblHiddenValue" runat="server"></asp:Label>

            <br />
            <asp:HiddenField ID="hdn" runat="server" />

        </div>
        <div id="output">
        </div>

    </form>
     <script type="text/javascript">
         $(function () {

             var employee = JSON.parse($("#hdn").val());
            
            $("#output").html("Id: " + employee.Id + "" + "Name: " + employee.Name + "" + "Salary: " + employee.Salary);
            
        });
    </script>
</body>
</html>
