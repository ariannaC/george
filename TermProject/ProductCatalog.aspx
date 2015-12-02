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
        <asp:Repeater ID="rptProducts" runat="server" OnItemCommand="rptProducts_ItemCommand"  >
             <ItemTemplate>
                <div class="col-3">
                               <asp:Label ID="lblProductDesc" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                                <asp:HiddenField ID="hidPrice" runat="server" Value='<% #Eval("Price", "{0:c}")%>' />
                                <asp:HiddenField ID="hidQOH" runat="server" Value='<% #Eval("QuantityOnHand")%>' />
                                <asp:HiddenField ID="hidImgURL" runat="server" Value ='<% #Eval("URL").ToString() + ".jpg" %>>'/>
                                <br />
                    <asp:Image ID="imgProduct" ImageUrl='<% #Eval("URL") %>' CssClass="imgProduct" runat="server" /> 
                               <asp:Button ID="btnViewProduct" runat="server" Text="View" CssClass="btnViewProduct" />
                </div>
             </ItemTemplate>
           
        </asp:Repeater>
        </div>
    </div>

    

    <br />
   <br />

    

     </asp:Content>
