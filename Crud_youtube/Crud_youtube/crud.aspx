<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crud.aspx.cs" Inherits="Crud_youtube.crud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 387px;
        }
        .auto-style3 {
            width: 80px;
        }
        .auto-style4 {
            width: 152px;
        }
        .auto-style5 {
            width: 64px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">ID :</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server" BorderColor="Yellow"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">NAME :&nbsp;</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox2" runat="server" BackColor="#660066" BorderColor="Yellow"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" BackColor="#0033CC" Height="26px" OnClick="Button1_Click" Text="Insert" Width="72px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">PHONE :</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox3" runat="server" BackColor="#660066" BorderColor="Yellow"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" BackColor="#003399" Height="27px" OnClick="Button2_Click" Text="DELETE" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">ADDRESS :</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox4" runat="server" BackColor="#660066" BorderColor="Yellow"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>
                    <asp:Button ID="Button3" runat="server" BackColor="Aqua" OnClick="Button3_Click" style="height: 26px" Text="UPDATE" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
