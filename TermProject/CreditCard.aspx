<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="CreditCard.aspx.cs" Inherits="TermProject.CreditCard" EnableViewState="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheets/CreditCardStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Account Information</h1>
        <div class="section">
        <asp:Label ID="lblSettings" runat="server" Text="Account Settings" CssClass="h2"></asp:Label>
           
           
             <div class="sectionSetting">
                 
                 <asp:Label ID="Label1" runat="server" CssClass="sectionLabel" Text="Name:"></asp:Label>
                 
                <asp:Button ID="btnEditName" runat="server" Text="Edit" Width="87px" style="margin-bottom: 3px; margin-top: 12px;" CssClass="sectionBtn" Height="30px" OnClick="btnEditName_Click" />
                  <asp:Label ID="lblCustomerName" runat="server" CssClass="sectionLabel"></asp:Label>
            </div>
             <div class="sectionSetting">
                 
                 <asp:Label ID="lblEmail" runat="server" CssClass="sectionLabel" Text="Email:"></asp:Label>
                 
                <asp:Button ID="btnEditEmail" runat="server" Text="Edit" Width="87px" style="margin-bottom: 3px; margin-top: 12px;" CssClass="sectionBtn" Height="30px" />
                  <asp:Label ID="Label3" runat="server" CssClass="sectionLabel"></asp:Label>
            </div>
             <div class="sectionSetting">
                 
                 <asp:Label ID="Label4" runat="server" CssClass="sectionLabel" Text="Password"></asp:Label>
                 
                <asp:Button ID="btnPassword" runat="server" Text="Edit" Width="87px" style="margin-bottom: 3px; margin-top: 12px;" CssClass="sectionBtn" Height="30px" />
                  <asp:Label ID="Label5" runat="server" CssClass="sectionLabel"></asp:Label>

            </div>
             <div class="sectionSetting">
                 
                 <asp:Label ID="Label6" runat="server" CssClass="sectionLabel" Text="Name:"></asp:Label>
                 
                <asp:Button ID="Button5" runat="server" Text="Edit" Width="87px" style="margin-bottom: 3px; margin-top: 12px;" CssClass="sectionBtn" Height="30px" />
                  <asp:Label ID="Label7" runat="server" CssClass="sectionLabel"></asp:Label>
            </div>
            
    </div>


    <div class="section">
        <asp:Label ID="lblOrders" runat="server" Text="Orders"></asp:Label>
        <div>
        </div>
        <div>
        </div>
    </div>

    <div class="section">
            <h2 style="width: 751px" class="h2">Cards On File
            </h2>
            <br />
            <br />
            <asp:GridView ID="gvCreditCard" runat="server" Height="72px" style="margin-left: 20px; margin-right: 18px; margin-bottom: 21px" Width="725px">
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

            <asp:Button ID="Button2" runat="server"  style=" margin-top: 0px;" Text="APPLY FOR AMAZON CREDIT CARD" Width="237px" CssClass="sectionBtn" />
            <asp:Button ID="btnAddNewCard" runat="server"   Text="ADD NEW CREDIT CARD"  OnClick="btnAddNewCard_Click" CssClass="sectionBtn" />
            <asp:Button ID="btnEditCard" runat="server"   Text="EDIT CREDIT CARD" Width="238px" OnClick="btnEditCard_Click" CssClass="sectionBtn" />
                </div>



    <br />
    <br />
    <br />
    <br />
       <br />
    </asp:Content>
