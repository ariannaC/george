<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuntFreida.aspx.cs" Inherits="TermProject.AuntFreida" %>
<%@ Register src="MerchantInfo.ascx" tagname="MerchantInfo" tagprefix="uc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:lightpink">
    <form id="form1" runat="server">
        <h1 style="text-align:center; color:deeppink;">MERCHANT ACCOUNT PAGE :)</h1>
        <br />
        <asp:GridView ID="gvMerchAccount" runat="server" ></asp:GridView>
        <asp:Button ID="btnLogout" runat="server" Text="Log Out" ForeColor="DeepPink" OnClick="btnLogout_Click" />
        <asp:Button ID="btnEditAccount" runat="server" Text="Edit Account Information" ForeColor="DeepPink" OnClick="btnEditAccount_Click" />
        <asp:Button ID="btnChangePassword" runat="server" Text="Change Password" ForeColor="DeepPink" />
        <uc1:MerchantInfo ID="ucMerch" runat="server" Visible="false"></uc1:MerchantInfo>
    </form>
</body>
</html>
