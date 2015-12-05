<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuntFreida.aspx.cs" Inherits="TermProject.AuntFreida" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:lightpink">
    <form id="form1" runat="server">
        <h1 style="text-align:center; color:deeppink;">MERCHANT ACCOUNT PAGE :)</h1>
        <asp:Button ID="btnLogout" runat="server" Text="Log Out" ForeColor="DeepPink" OnClick="btnLogout_Click" />
        <asp:Button ID="btnEditAccount" runat="server" Text="Edit Account Information" ForeColor="DeepPink" />
        <asp:Button ID="btnChangePassword" runat="server" Text="Change Password" ForeColor="DeepPink" />
    </form>
</body>
</html>
