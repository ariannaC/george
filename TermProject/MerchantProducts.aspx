<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="MerchantProducts.aspx.cs" Inherits="TermProject.MerchantProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheets/ProductStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
     <br /> 
     <div style="width: 1083px">
    <asp:Label ID="lblselectDep" runat="server" Text="Select a Department"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddlDepartments" runat="server" Height="24px" Width="420px" AutoPostBack="True">
        <asp:ListItem>All</asp:ListItem>
    </asp:DropDownList>
    </div>
     <br /> <br />
    
    <asp:GridView ID="gvMerchantProducts" runat="server" Height="237px" Width="900px" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="ID" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="Department" HeaderText="Department" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
