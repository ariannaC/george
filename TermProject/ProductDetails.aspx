<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="TermProject.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheets/ProductStyle.css" rel="stylesheet" />
    <style type="text/css">
        .button {
            margin-left: 17px;
            margin-top: 10px;
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

         <div id="productData">  
             <h2 style="width: 297px; margin-left: 38px; margin-right: 17px; margin-bottom: 25px">Product Details</h2> 
        <asp:Label ID="lblprodDesc" runat="server" Text="Label" Width="278px" Height="25px" style="margin-left: 7px; margin-top: 17px; margin-bottom: 16px"></asp:Label><br />
             <asp:Label ID="lblprice" runat="server" Text="Price" CssClass="lblName" Width="51px"></asp:Label> 
              <asp:Label ID="lblUnitPrice" runat="server" Text="Label" CssClass="lblUnitPrice" Width="288px"></asp:Label>

       
    <div style="margin-top: 12px">

             <asp:Label ID="lblQuantity" runat="server" Text="Quantity" CssClass="lblName" Height="19px"></asp:Label>
         <asp:TextBox ID="txtQuantity" runat="server" OnTextChanged="txtQuantity_TextChanged" style="margin-left: 0px; margin-right: 158px; margin-top: 13px; margin-bottom: 26px"></asp:TextBox>   
       
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add to Cart" CssClass="button" />
        <asp:Button ID="btnCart" runat="server" CausesValidation="False" PostBackUrl="~/Cart.aspx" Text="Go to Cart" CssClass="button" OnClick="btnCart_Click" />
    </div> 
    </div>

    <asp:Image ID="imgProduct" runat="server" Height="244px" Width="332px" OnLoad="imgProduct_Load"   /> 





     </asp:Content>
