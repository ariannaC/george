<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="ProductCatalog.aspx.cs" Inherits="TermProject.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheets/ProductCatalogStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div style="width: 1017px; margin-right: 0px;">
        <asp:Label ID="lblselectDep" runat="server" Text="Select a Department"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlDepartments" runat="server" Height="24px" Width="420px" AutoPostBack="True" OnSelectedIndexChanged="ddlDepartments_SelectedIndexChanged">
        </asp:DropDownList>
    </div>
    <br />
    <div style="width:100%">
        <div class="row">
        <asp:Repeater ID="rptProducts" runat="server" OnItemCommand="rptProducts_ItemCommand">
             <ItemTemplate>
                <div class="col-3">
                               <asp:Label ID="lblName" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                               <br />
                               <asp:Image ID="imgProduct" ImageUrl='<%#Eval("URL").ToString() + ".jpg" %>>'  CssClass="imgProduct" runat="server" /><br />
                               <asp:Button ID="btnViewProduct" runat="server" Text="View" CssClass="btnViewProduct" />
                </div>
             </ItemTemplate>
           
        </asp:Repeater>
        </div>
    </div>

    

    <br />
   <br />

    

     </asp:Content>
