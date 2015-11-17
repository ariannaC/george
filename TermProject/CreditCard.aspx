<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="CreditCard.aspx.cs" Inherits="TermProject.CreditCard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="width: 775px">Cards On File
    </h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="267px" Width="811px" style="margin-right: 27px">
        <Columns>
            <asp:BoundField DataField="CreditCardID" HeaderText="CreditCardID" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="CardNumber" HeaderText="Card Number" />
            <asp:BoundField DataField="ExpMonth" HeaderText="Exp Month" />
            <asp:BoundField DataField="ExpYear" HeaderText="Exp Year" />
            <asp:BoundField DataField="CSV" HeaderText="CSV" />
            <asp:CommandField ShowEditButton="True" />
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Height="49px" style="margin-left: 117px" Text="APPLY FOR AMAZON CREDIT CARD" Width="357px" />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
