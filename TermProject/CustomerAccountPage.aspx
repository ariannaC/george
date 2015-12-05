<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="CustomerAccountPage.aspx.cs" Inherits="TermProject.CustomerAccountPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheets/AccountStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section">

        <asp:Label ID="lblOrders" runat="server" Text="Orders"></asp:Label>

    </div>

    <div class="section">

        <asp:Label ID="Label1" runat="server" Text="Account Settings"></asp:Label>

    </div>
    <div class="section">

        <asp:Label ID="Label2" runat="server" Text="Manage Payment Options"></asp:Label>

    </div>

</asp:Content>
