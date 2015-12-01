<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="
    .aspx.cs" Inherits="TermProject.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Repeater ID="rptCart" runat="server">
        <ItemTemplate>
            <asp:Label ID="lblProdName" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
            <asp:Label ID="lblPrice" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
            <asp:Label ID="lblQuantOrdered" runat="server" Text='<%# Eval("Quantity") %>'></asp:Label>
            <asp:Label ID="lblSubtotal" runat="server" Text='<%# Eval("Subtotal") %>'></asp:Label>
            <asp:Label ID="lblMerch" runat="server" Text='<%# Eval("MerchantName") %>'></asp:Label>
            <asp:TextBox ID="txtQuantity" type="number" runat="server"></asp:TextBox>
        </ItemTemplate>
    </asp:Repeater>
    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
    <asp:Button ID="btnDelete" runat="server" Text="Button" />
</asp:Content>
