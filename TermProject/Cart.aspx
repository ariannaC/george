<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="TermProject.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="padding: 15px; width: 100%;">
        <asp:Repeater ID="rptCart" runat="server">
            <ItemTemplate>
                <div style="text-align: center; border: solid; border-color: #98bf21; border-width: 2px; margin-bottom: 15px; width: 30%; float: left; margin-right: 15px; border-radius: 5px;">
                    <asp:CheckBox ID="chkSelect" runat="server" style="color:deeppink" /> Select
                    <br />
                    <img style="height:100px" src="<%# Eval("URL") %>"/>
                     <h3> <b>Name: </b>
                        <asp:Label ID="lblProdName" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label></h3>
                    <h4><b>Price: $</b><asp:Label ID="lblPrice" runat="server" Text='<%# Eval("Price") %>'></asp:Label></h4>
                    <p>
                      <b>Quantity Ordered:  </b>  <asp:Label ID="lblQuantOrdered" runat="server" Text='<%# Eval("Quantity") %>'></asp:Label>
                    </p>
                    <p>
                      <b>Subtotal: $</b><asp:Label ID="lblSubtotal" runat="server" Text='<%# Eval("Subtotal") %>'></asp:Label>
                    </p>
                    <p>
                       <b>Supplier: </b> <asp:Label ID="lblMerch" runat="server" Text='<%# Eval("MerchantName") %>'></asp:Label>
                    </p>
                    <p>
                        <asp:TextBox ID="txtQuantity" placeholder="Update Quantity" type="number" runat="server"></asp:TextBox>
                    </p>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <div style="clear: both;"></div>
    </div>

    <div style="text-align:center;">
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />        
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear Cart" OnClick="btnClear_Click" />
        <asp:Button ID="btnCheckOut" runat="server" Text="Proceed to Checkout" OnClick="btnAdd_Click" />
    </div>
</asp:Content>
