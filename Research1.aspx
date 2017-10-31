<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Research1.aspx.cs" Inherits="Research1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <p style="margin-left: 440px">
        SELECT AN OPTION :</p>
    <form id="form1" runat="server">
        <p style="margin-left: 400px">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="20px" Width="365px">
                <asp:ListItem>SHOW PROJECTS / PUBLICATIONS</asp:ListItem>
                <asp:ListItem>UPDATE INFORMATION</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p style="margin-left: 400px">
            &nbsp;</p>
        <p style="margin-left: 440px">
            <asp:Button ID="Button1" runat="server" Text="SUBMIT" Width="105px" OnClick="Button1_Click" />
        </p>
        <div>
        </div>
    </form>
</body>
</html>
