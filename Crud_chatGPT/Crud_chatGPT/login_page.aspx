

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
            <h2>Registration</h2>
            Name: <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />
            Address: <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br /><br />
            Email: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br /><br />
            Mobile: <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btnGeneratePassword" Text="Generate Password" runat="server" OnClick="btnGeneratePassword_Click" />
        </div>
    </form>
</body>
</html>
