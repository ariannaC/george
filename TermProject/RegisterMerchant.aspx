﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterMerchant.aspx.cs" Inherits="TermProject.RegisterMerchant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="stylesheets/Registration.css" rel="stylesheet" />
</head>
<body style="height: 1357px; width: 1059px; margin-top: 21px; margin-bottom: 39px;">
    <form id="form1" runat="server">
       
  &nbsp;<div class ="content">

      <div class ="statusbar">
          <asp:Button ID="btnCancel" runat="server" CssClass="cancelbtn" Text="X" BackColor="#FF3300" Font-Bold="True" Height="31px" OnClick="btnCancel_Click" Width="37px" />
          <asp:Button ID="Button1" runat="server" Height="33px" OnClick="Button1_Click" Text="&lt;" Width="33px" />
      </div> 
       <h1>Register as a Business </h1>
     
            <div class="floating-box">
                
                <asp:Label ID="Label1" runat="server" Text="Email" CssClass="FBlabel"></asp:Label>
               <asp:TextBox ID="txtEmail" runat="server" Width="491px" style="margin-left: 6px" CssClass="FBtxtbox" Height="23px"></asp:TextBox>
            </div>
     
        <div class="floating-box">
           
            <asp:Label ID="lbl" runat="server" Text="Group" CssClass="FBlabel"></asp:Label>

            <asp:TextBox ID="txtName" runat="server" Width="486px" Height="30px" style="margin-left: 4px; margin-top: 11px; margin-bottom: 0px;" CssClass="FBtxtbox"></asp:TextBox>
            <br />
            <asp:Label ID="lblInvalidName" runat="server"></asp:Label>
        </div>
           
       <div class="floating-box">
            <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server" Width="451px" style="margin-left: 0px" CssClass="FBtxtbox" Height="26px"></asp:TextBox>
        </div>


       
       
         <div class="floating-boxxx">

          
             <asp:Button ID="btnRegister" runat="server" Height="35px" OnClick="btnContinue_Click" Text="Register Business" Width="481px" Font-Names="Century Gothic" Font-Size="Medium" />
             &nbsp;
             <asp:Label ID="lblGeneralError" runat="server"></asp:Label>
             <br />
              </div>

                    
             <asp:CheckBox ID="chkbxRemeberMe" runat="server"  Text="Remember Me at Login" />

                    
         </div>                                                                           
    </form>
</body>
</html>
