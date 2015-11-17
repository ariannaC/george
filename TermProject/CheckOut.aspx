<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="CheckOut.aspx.cs" Inherits="TermProject.CheckOut" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="contentHolderco">
    <h2 style="margin-bottom: 10px">SHIPPING ADDRESS </h2>
     <div class="floating-box">
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server" Width="459px" style="margin-left: 7px" CssClass="FBtxtbox" Height="26px"></asp:TextBox>
        </div>
            <div class="floating-box">
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCity" runat="server" style="margin-left: 0px" Width="461px" CssClass="FBtxtbox" Height="26px"></asp:TextBox>
        </div>

            <div class="floating-box">
            &nbsp;<asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtState" runat="server" Height="26px" Width="461px" MaxLength="2" style="margin-left: 11px"></asp:TextBox>
        </div>
        <div class="floating-box">
            <asp:Label ID="lblZip" runat="server" Text="Zipcode"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="465px" Height="27px" MaxLength="5" style="margin-left: 13px"></asp:TextBox>
        </div>


    <br />
    <br />


    <br />
    <h2 style="margin-bottom: 10px">BILLING ADDRESS</h2>
    <asp:CheckBox ID="chkbxSameAsShippingAddress" runat="server" Text="same as shipping address" />
        <div class="floating-box">
            <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="459px" style="margin-left: 7px" CssClass="FBtxtbox" Height="26px"></asp:TextBox>
        </div>
            <div class="floating-box">
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="City"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 7px" Width="461px" CssClass="FBtxtbox" Height="30px"></asp:TextBox>
        </div>

            <div class="floating-box">
            &nbsp;<asp:Label ID="Label4" runat="server" Text="State"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Height="26px" Width="461px" MaxLength="2" style="margin-left: 7px"></asp:TextBox>
        </div>
        <div class="floating-box">
            <asp:Label ID="Label5" runat="server" Text="Zipcode"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" Width="465px" Height="27px" MaxLength="5" style="margin-left: 13px"></asp:TextBox>
        </div>


    <br />

    <br />

    <h2>PAYMENT</h2>
    <div>
    <asp:Label ID="Label1" runat="server" Text="Select Existing Card"></asp:Label>
    &nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" Height="27px" Width="378px" style="margin-left: 14px; margin-right: 10px; margin-bottom: 0px">
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnAddCreditCard" runat="server" Text="ADD NEW CREDIT CARD" style="margin-bottom: 0px" OnClick="btnAddCreditCard_Click" />
    <br />
    <asp:CheckBox ID="chkbxSaveCard" runat="server" Text="Save Card" />
        </div>
    <br />

       </div>
</asp:Content>
