<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="TermProject.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheets/ProductStyle.css" rel="stylesheet" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

         <div id="productData">   
        <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblShortDescription" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblLongDescription" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblUnitPrice" runat="server" Text="Label"></asp:Label>
        <label id="lblQuantity">Quantity&nbsp;</label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>   
    <div style="margin-top: 16px">
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add to Cart" CssClass="button" />
        <asp:Button ID="btnCart" runat="server" CausesValidation="False" PostBackUrl="~/Cart.aspx" Text="Go to Cart" CssClass="button" />
    </div> 
    </div>

    <asp:Image ID="imgProduct" runat="server" Height="224px" Width="203px" /> 





     </asp:Content>
