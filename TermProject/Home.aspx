<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TermProject.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div style="width: 1083px">
    <asp:Label ID="lblselectDep" runat="server" Text="Select a Department"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddlDepartments" runat="server" Height="24px" Width="420px" AutoPostBack="True">
    </asp:DropDownList>
    </div>

    <br />
    <br />
   <br />

    

     <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False" Height="232px" style="margin-right: 21px; margin-top: 6px; margin-left: 29px;" Width="999px" OnSelectedIndexChanged="gvProducts_SelectedIndexChanged">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Label ID="lblProductName" runat="server" Text="Label"></asp:Label>
                    <br />
                    <asp:Image ID="ProductImage" runat="server" Height="180px" Width="236px" />
                    <br />
                    <asp:Button ID="btnViewProduct" runat="server" style="margin-left: 0px" Text="View" Width="112px" OnClick="btnViewProduct_Click" />
                    <asp:Button ID="btnAddtoWishList" runat="server" Height="26px" style="margin-left: 10px" Text=" + WishList" Width="109px" />
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Label ID="lblProductName" runat="server" Text="Label"></asp:Label>
                    <br />
                    <asp:Image ID="ProductImage" runat="server" Height="180px" Width="236px" />
                    <br />
                    <asp:Button ID="btnViewProduct" runat="server" style="margin-left: 0px" Text="View" Width="112px" OnClick="btnViewProduct_Click" />
                    <asp:Button ID="btnAddtoWishList" runat="server" Height="26px" style="margin-left: 10px" Text=" + WishList" Width="109px" />
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Label ID="lblProductName" runat="server" Text="Label"></asp:Label>
                    <br />
                    <asp:Image ID="ProductImage" runat="server" Height="180px" Width="236px" />
                    <br />
                    <asp:Button ID="btnViewProduct" runat="server" style="margin-left: 0px" Text="View" Width="112px" OnClick="btnViewProduct_Click" />
                    <asp:Button ID="btnAddtoWishList" runat="server" Height="26px" style="margin-left: 10px" Text=" + WishList" Width="109px" />
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:BoundField />
        </Columns>
    </asp:GridView>
</asp:Content>
