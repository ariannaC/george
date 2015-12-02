<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="ProductCatalog.aspx.cs" Inherits="TermProject.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheets/ProductCatalogStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div style="width: 1017px; margin-right: 0px; margin-top: 0px;">
        <asp:Label ID="lblselectDep" runat="server" Text="Select a Department"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlDepartments" runat="server" Height="56px" Width="420px" AutoPostBack="True" OnSelectedIndexChanged="ddlDepartments_SelectedIndexChanged">
        </asp:DropDownList>
    </div>
    <br />
    <div style="width:100%; height: 613px;">
        <div class="row">
        <asp:Repeater ID="rptProducts" runat="server" OnItemCommand="rptProducts_ItemCommand"  >
             <ItemTemplate>
                 <div style="text-align: center; border: solid; border-color: #98bf21; border-width: 2px; margin-bottom: 15px; width: 30%; float: left; margin-right: 15px; border-radius: 5px;">
               
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

 
     </asp:Content>
