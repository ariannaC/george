<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="TermProject.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheets/ProductStyle.css" rel="stylesheet" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <label>Please select a p<div id="productData">   
        <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblShortDescription" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblLongDescription" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblUnitPrice" runat="server" Text="Label"></asp:Label>
        <label id="lblQuantity">Quantity&nbsp;</label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>   
         <%-- // <asp:RequiredFieldValidator ID="rfvQuantity" runat="server" ErrorMessage="Quantity is required." ControlToValidate="txtQuantity" CssClass="validator" Display="Dynamic"></asp:RequiredFieldValidator>       
       // <asp:RangeValidator ID="rgvQuantity" runat="server" ErrorMessage="Must be between 1 and 500." ControlToValidate="txtQuantity" CssClass="validator" Display="Dynamic" MaximumValue="500" MinimumValue="1" Type="Integer"></asp:RangeValidator>
        <br />--%>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add to Cart" CssClass="button" />
        <asp:Button ID="btnCart" runat="server" CausesValidation="False" PostBackUrl="~/Cart.aspx" Text="Go to Cart" CssClass="button" />
    </div>
     roduct&nbsp;</label>
     <%-- <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource" DataTextField="Name" DataValueField="ProductID">
    </asp:DropDownList>--%>
    <asp:Image ID="imgProduct" runat="server" Height="224px" Width="203px" /> 





     <asp:DropDownList ID="ddlProduct" runat="server" Height="19px" Width="254px">
     </asp:DropDownList>





</asp:Content>
