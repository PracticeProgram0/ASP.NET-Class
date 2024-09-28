<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_home.aspx.cs" Inherits="Security4.Admin.admin_home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 847px;
        }
        .auto-style3 {
            width: 847px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This is a admin home page...............

        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2"> 
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">About </asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LogOut </asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
            </tr>
        </table>
    </form>
</body>
</html>
