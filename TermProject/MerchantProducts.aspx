<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="MerchantProducts.aspx.cs" Inherits="TermProject.MerchantProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheets/ProductStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
     <br /> 
     <div style="width: 1083px; margin-left: 0px;">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblselectDep" runat="server" Text="Select a Department"></asp:Label>
    
    <asp:DropDownList ID="ddlDepartments" runat="server" Height="34px" Width="438px" AutoPostBack="True" style="margin-left: 54px; margin-right: 15px;">
        <asp:ListItem>All</asp:ListItem>
    </asp:DropDownList>
    </div>
     <br /> <br />

    <div style="margin-bottom: 17px">

        <asp:Label ID="Label1" runat="server" Text="Search by Department Number"  ></asp:Label>
        <asp:TextBox ID="txtDepartmentNumber" runat="server" style="margin-left: 11px" Width="426px"></asp:TextBox>

    </div>
    
    <asp:GridView ID="gvMerchantProducts" runat="server" Height="237px" Width="900px" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="ID" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="Department" HeaderText="Department" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
