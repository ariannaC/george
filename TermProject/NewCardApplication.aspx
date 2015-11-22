<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="NewCardApplication.aspx.cs" Inherits="TermProject.NewCardApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheets/NewCreditCard.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1 id ="pageHeader" runat ="server">ADD NEW CREDIT CARD
        </h1>

    </div>           
     <div class ="floating-box">
            <asp:Label ID="Label1" runat="server" Text="Name on Card"></asp:Label>&nbsp;
            <asp:TextBox ID="txtNameOnCard" runat="server" Width="366px" Height="24px"></asp:TextBox>
            </div>

            <div class="floating-box">
                &nbsp;
                <asp:Label ID="lblcardNumber" runat="server" Text="Card Number"></asp:Label>
                &nbsp; &nbsp;<asp:TextBox ID="txtCardNumber" runat="server" Width="251px" TextMode="Number" MaxLength="16" Height="24px"></asp:TextBox>
                &nbsp;
            </div>

            <div class="floating-box">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
                <asp:Label ID="lblCity" runat="server" Text="Expires"></asp:Label>
                &nbsp;
                <asp:DropDownList ID="ddlExpMonth" runat="server" Height="24px" Width="83px" Font-Names="Century Gothic">
                    <asp:ListItem Value="01"></asp:ListItem>
                    <asp:ListItem Value="02"></asp:ListItem>
                    <asp:ListItem Value="03"></asp:ListItem>
                    <asp:ListItem Value="04"></asp:ListItem>
                    <asp:ListItem Value="05"></asp:ListItem>
                    <asp:ListItem Value="06"></asp:ListItem>
                    <asp:ListItem Value="07"></asp:ListItem>
                    <asp:ListItem Value="08"></asp:ListItem>
                    <asp:ListItem Value="09"></asp:ListItem>
                    <asp:ListItem Value="10"></asp:ListItem>
                    <asp:ListItem Value="11"></asp:ListItem>
                    <asp:ListItem Value="12"></asp:ListItem>
                </asp:DropDownList>&nbsp;&nbsp;

                <asp:DropDownList ID="ddlExpYear" runat="server" Width="96px" Font-Names="Century Gothic" Height="24px">
                    <asp:ListItem Value="2015"></asp:ListItem>
                    <asp:ListItem Value="2016"></asp:ListItem>
                    <asp:ListItem Value="2017"></asp:ListItem>
                    <asp:ListItem Value="2018"></asp:ListItem>
                    <asp:ListItem Value="2019"></asp:ListItem>
                    <asp:ListItem Value="2020"></asp:ListItem>
                    <asp:ListItem Value="2021"></asp:ListItem>
                    <asp:ListItem Value="2022"></asp:ListItem>
                    <asp:ListItem Value="2023"></asp:ListItem>
                    <asp:ListItem Value="2024"></asp:ListItem>
                    <asp:ListItem Value="2025"></asp:ListItem>
                    <asp:ListItem Value="2026"></asp:ListItem>
                    <asp:ListItem Value="2027"></asp:ListItem>
                    <asp:ListItem Value="2028"></asp:ListItem>
                    <asp:ListItem Value="2029"></asp:ListItem>
                    <asp:ListItem Value="2030"></asp:ListItem>
                    <asp:ListItem Value="2031"></asp:ListItem>
                    <asp:ListItem Value="2032"></asp:ListItem>
                    <asp:ListItem Value="2033"></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
             </div>

            <div class="floating-box">
                &nbsp;&nbsp;Security Code
                <asp:TextBox ID="txtCSV" runat="server" Height="24px" Width="70px"></asp:TextBox>
            </div>
    <div class="floating-box">

    </div>
     <div class="floating-box">

                <asp:Button ID="Button1" runat="server" Text="ADD CARD" CssClass="button" Height="39px" OnClick="Button1_Click" Width="154px" />

    </div>

</asp:Content>
