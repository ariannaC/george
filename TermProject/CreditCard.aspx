<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="CreditCard.aspx.cs" Inherits="TermProject.CreditCard" EnableViewState="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheets/CreditCardStyle.css" rel="stylesheet" />
    <style type="text/css">
        .row {
            width: 697px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Account Information</h1>
        <div class="section" style=" border: solid; border-color: #98bf21; border-width: 2px;">
        <asp:Label ID="lblSettings" runat="server" Text="Account Settings" CssClass="h2"></asp:Label>
           
           
             <div class="sectionSetting">
               
                 <asp:Label ID="Label1" runat="server" CssClass="sectionLabel" Text="Name:" Width="87px"></asp:Label>
                 <asp:Label ID="lblCustomerName" runat="server" CssClass="sectionLabel"></asp:Label>
                <asp:Button ID="btnEditName" runat="server" Text="Edit" Width="87px" style="margin-bottom: 3px; margin-top: 8px;" CssClass="sectionBtn" Height="30px" OnClick="btnEditName_Click" />
               <asp:Button ID="btnUpdateName" runat="server" Text="Update" Width="87px" style="margin-bottom: 3px; margin-top: 9px;" CssClass="sectionBtn" Height="30px" OnClick="btnUpdateName_Click" Visible="False" />
                 <asp:TextBox ID="txtName" runat="server" style="margin-left: 12px" Width="210px" Visible="False"></asp:TextBox><br/>
                 <asp:Label ID="lblNameError" runat="server"  style="margin-left: px" CssClass="lblError"></asp:Label>
               
            </div>
             <div class="sectionSetting">
                 
                 <asp:Label runat="server" CssClass="sectionLabel" Text="Email:" Width="92px"></asp:Label>
                 
                <asp:Button ID="btnEditEmail" runat="server" Text="Edit" Width="87px" style="margin-bottom: 3px; margin-top: 12px;" CssClass="sectionBtn" Height="30px" OnClick="btnEditEmail_Click" />
                  <asp:Label ID="lblEmail" runat="server" CssClass="sectionLabel" Width="137px"></asp:Label>
                                <asp:Button ID="btnUpdateEmail" runat="server" Text="Update" Width="87px" style="margin-bottom: 3px; margin-top: 12px;" CssClass="sectionBtn" Height="30px" OnClick="btnUpdateEmail_Click" Visible="False" />

                 <asp:TextBox ID="txtEmail" runat="server" style="margin-left: 11px" Width="213px" Visible="False"></asp:TextBox><br />
                 <asp:Label ID="lblEmailError" runat="server" CssClass="lblError"></asp:Label>
            </div>
             <div class="sectionSetting">
                 <asp:Label ID="Label4" runat="server" CssClass="sectionLabel" Text="Password" Width="89px" Height="17px"></asp:Label> 
                <asp:Button ID="btnEditPassword" runat="server" Text="Edit" Width="87px" style="margin-bottom: 3px; margin-top: 12px;" CssClass="sectionBtn" Height="30px" OnClick="btnEditPassword_Click" />
                  <asp:Label ID="lblpassword" runat="server" CssClass="sectionLabel" Height="23px" Width="140px"></asp:Label>
                  <asp:Button ID="btnUpdatePassword" runat="server" Text="Update" Width="87px" style="margin-bottom: 3px; margin-top: 12px;" CssClass="sectionBtn" Height="30px" OnClick="btnUpdatePassword_Click" Visible="False" />
                 <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 9px" Width="214px" Visible="False"></asp:TextBox> 
             
                 <br />
             
                 <asp:Label ID="lblPasswordError" runat="server" CssClass="lblError"></asp:Label>


                 <br/>


            </div>
            
    </div>


    <div class="section"  style="border: solid; border-color: #98bf21; border-width: 2px;">
        <asp:Label ID="lblOrders" runat="server" Text="Orders"></asp:Label>
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="OrderID"></asp:Label>
            <asp:DropDownList ID="ddlPurchaseID" runat="server" style="margin-left: 12px" Width="230px" OnSelectedIndexChanged="ddlPurchaseID_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
        <div>
            <asp:GridView ID="gvPurchasedProducts" runat="server" AutoGenerateColumns="False" Height="102px" ShowFooter="True" style="margin-left: 86px; margin-bottom: 8px" Width="236px">
                <Columns>
                    <asp:BoundField DataField="Products" HeaderText="Products" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

    <div class="section" style=" border: solid; border-color: #98bf21; border-width: 2px;">
            <h2 style="width: 751px" class="h2">Manage Payment Options</h2>

        <div style="width:96%; padding:15px; text-align:center">
            <div class="row">
                <asp:Repeater ID="rptPaymentOptions" runat="server" OnItemCommand="rptPaymentOptions_ItemCommand">
                    <ItemTemplate>
                     <div style="text-align:left; border: solid; border-color: #98bf21; border-width: 2px;">
                        <asp:Label runat="server" Text="Card Number: "></asp:Label>
                        <asp:Label runat="server" Text='<%# Bind("CardNumber") %>' ID="lblCardNumber"></asp:Label><br />
                        <asp:Label ID="Label5" runat="server" Text="Exp Date:"></asp:Label>
                         <asp:Label ID="Label2" runat="server" Text='<%# Bind("ExpMonth") %>'></asp:Label>
                         <asp:Label ID="Label3" runat="server" Text=' <%# Bind("ExpYear") %>'></asp:Label><br />
                        <asp:Label ID="Label8" runat="server" Text="Card Holder Name:"></asp:Label>
                         <asp:Label ID="Label9" runat="server" Text='<%# Bind("NameOnCard") %>'></asp:Label><br /><br />
                         <asp:HiddenField ID="hdnCardID" Value='<%# Bind("CCID") %>' runat="server" />
                         <asp:Button ID="btnEdit" runat="server" Text="Edit" />

                            </div>

                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>

            <asp:GridView ID="GridView1" runat="server" Height="72px" style="margin-left: 20px; margin-right: 18px; margin-bottom: 21px" Width="725px">
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
                </div>



    <br />
    <br />
    <br />
    <br />
       <br />
    </asp:Content>
