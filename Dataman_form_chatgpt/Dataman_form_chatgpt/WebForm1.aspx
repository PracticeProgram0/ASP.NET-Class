<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Dataman_form_chatgpt.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:TextBox ID="txtName" runat="server" />
<asp:TextBox ID="txtDob" runat="server" />
<asp:TextBox ID="txtDateOfJoining" runat="server" />
<asp:TextBox ID="txtMobile" runat="server" />
<asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" />
<asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" />
<asp:TextBox ID="txtState" runat="server" ReadOnly="True" />
<asp:TextBox ID="txtCountry" runat="server" ReadOnly="True" />
<asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />

        </div>
    </form>
</body>
</html>
