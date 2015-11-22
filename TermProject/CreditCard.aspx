<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="CreditCard.aspx.cs" Inherits="TermProject.CreditCard" EnableViewState="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheets/CreditCardStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Account Information</h1>
    <h2 style="width: 775px">Cards On File
    </h2>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <asp:CheckBox ID="cbEdit" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EmptyDataTemplate>
            <asp:CheckBox ID="cbEdit" runat="server" />
        </EmptyDataTemplate>
    </asp:GridView>
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" Height="50px" style="margin-left: 55px" Text="APPLY FOR AMAZON CREDIT CARD" Width="238px" />
    <asp:Button ID="btnAddNewCard" runat="server" Height="50px" style="margin-left: 55px" Text="ADD NEW CREDIT CARD" Width="238px" OnClick="btnAddNewCard_Click" />
    <asp:Button ID="btnEditCard" runat="server" Height="50px" style="margin-left: 55px" Text="EDIT CREDIT CARD" Width="238px" OnClick="btnEditCard_Click" />
    <br />
    </asp:Content>
