<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MerchantInfo.ascx.cs" Inherits="TermProject.MerchantInfo" %>
<br />
<asp:Label ID="lblGroupName" runat="server" Text="Merchant Name"></asp:Label>
<asp:TextBox ID="txtMerchName" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
<asp:TextBox ID="txtEmail" runat="server" Enabled="false"></asp:TextBox>
<br />
<asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblURL" runat="server" Text="URL"></asp:Label>
<asp:TextBox ID="txtUrl" runat="server"></asp:TextBox>
<br />
<asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
<br />
