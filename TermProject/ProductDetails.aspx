<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="TermProject.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="stylesheets/ProductStyle.css" rel="stylesheet" />

      
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="floating-boxx">
        <asp:Button ID="Button1" runat="server" Text="Return to Product Catalog" BackColor="#4E5D6C" ForeColor="White" Width="188px" BorderColor="#4E5D6C" Height="30px" />
    </div>
    <br /><br />
    <div>
    <div class="imgbox">
        <asp:Image ID="imgProduct" runat="server" Height="312px"  OnLoad="imgProduct_Load" Width="386px" />

    </div>

     <div style="width: 493px; height: 407px">
                 <div style="height: 406px; width: 503px; margin-right: 8px;" >
                         <div id="productData">  
                             <h2 style="width: 297px; margin-left: 13px; margin-right: 17px; margin-bottom: 25px; margin-top: 22px;">Product Details</h2>
                             <br />
                             <div class="floating-box">
                              <asp:Label ID="Label1" runat="server" CssClass="lblName" Text="Product:" Width="151px" Height="29px"></asp:Label>
                              <asp:Label ID="lblprodDesc" runat="server" Text="Label"  Height="25px" style="margin-left: 7px; margin-top: 4px; margin-bottom: 0px" CssClass="lblUnitPrice"></asp:Label><br />
                            </div><br />
                             <div class="floating-box">
                              <asp:Label ID="lblprice" runat="server" Text="Price" CssClass="lblName" Width="148px" Height="32px" ></asp:Label> 
                              <asp:Label ID="lblUnitPrice" runat="server" Text="Label" CssClass="lblUnitPrice"  Height="26px"></asp:Label>
                             </div><br />
       
                  
                                <br />
                                <div class="floating-box">
                                     <asp:Label ID="lblQuantity" runat="server" Text="Quantity" CssClass="lblName" Height="19px" Width="143px"></asp:Label>
    
                                 <asp:TextBox ID="txtQuantity" runat="server" style="margin-left: 0px; margin-right: 10px; margin-top: 4px; margin-bottom: 5px" CssClass="lblUnitPrice" Width="275px"></asp:TextBox>   
                                </div><br />
                             <br /><br />
                             <div class="floating-box">
                                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add to Cart" CssClass="button" />
                                <asp:Button ID="btnCart" runat="server" CausesValidation="False" PostBackUrl="~/Cart.aspx" Text="Go to Cart" CssClass="button" OnClick="btnCart_Click" />
                          </div>
    
                  
                     </div>
              </div>
     
            
            

                 </div>
        </div>
     </asp:Content>
