<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PasswordChange.ascx.cs" Inherits="TermProject.PasswordChange" %>
<br />
<asp:Label ID="lblOldPass" runat="server" Text="OldPassword"></asp:Label>
<asp:TextBox ID="txtOldPass" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblNewPass1" runat="server" Text="New Password"></asp:Label>
<asp:TextBox ID="txtNewPass1" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblNewPass2" runat="server" Text="Confirm Password"></asp:Label>
<asp:TextBox ID="txtNewPass2" runat="server"></asp:TextBox>
<br />
<asp:Button ID="btnConfirm" runat="server" Text="Confirm Change" OnClick="btnConfirm_Click" />
