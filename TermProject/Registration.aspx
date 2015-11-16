<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="TermProject.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 1323px;
            width: 901px;
            margin-right: 62px;
            margin-bottom: 39px;
            margin-left: 37px;
        }
    </style>
    <link href="stylesheets/Registration.css" rel="stylesheet" />
</head>
<body style="height: 1357px; width: 1059px; margin-top: 21px; margin-bottom: 39px; margin-right: 10px;">
    <form id="form1" runat="server">
       
  &nbsp;<div class ="content">
       <asp:Button ID="btnCancel" runat="server" CssClass="cancelbtn" Text="X" BackColor="#FF3300" Font-Bold="True" Height="23px" OnClick="btnCancel_Click" Width="30px" />
       <h1>Register </h1>
     
            <div class="floating-box">
                
                <asp:Label ID="Label1" runat="server" Text="Email" CssClass="FBlabel"></asp:Label>
               <asp:TextBox ID="txtEmail" runat="server"   CssClass="FBtxtbox" Height="23px" Width="454px"></asp:TextBox>
            </div>
     
        <div class="floating-box">
           
            <asp:Label ID="lbl" runat="server" Text="Name" CssClass="FBlabel"></asp:Label>

            <asp:TextBox ID="txtName" runat="server" Height="23px" style="  margin-bottom: 0px;" CssClass="FBtxtbox" Width="454px"></asp:TextBox>
           
            <asp:Label ID="lblInvalidName" runat="server" CssClass="FBlabel"></asp:Label>
        </div>
           
      <div class="floating-box">
                <asp:Label ID="Label2" runat="server" Text="Password" CssClass="FBlabel"></asp:Label>        
                <asp:TextBox ID="txtpassword" runat="server" Height="22px" TextMode="Password" CssClass="FBtxtbox" Width="454px" ></asp:TextBox>
                 <asp:Label ID="lblPasswordsDontmatch" runat="server"></asp:Label>
           </div>
                <div class="floating-box">
               
                    <asp:Label ID="Label3" runat="server" Text="Re-enter Password" CssClass="FBlabel"></asp:Label>
                    <asp:TextBox ID="txtReenterPassword" runat="server" CssClass="FBtxtbox" Height="23px"  TextMode="Password" Width="453px"></asp:TextBox>
&nbsp;</div>
       <div class="floating-box">
            <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server"  style="margin-left: 0px" CssClass="FBtxtbox" Height="26px" Width="454px"></asp:TextBox>
        </div>
            <div class="floating-box">
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCity" runat="server" style="margin-left: 0px"  CssClass="FBtxtbox" Height="30px" Width="454px"></asp:TextBox>
        </div>

            <div class="floating-box">
            &nbsp;<asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtState" runat="server" Height="26px" MaxLength="2" CssClass="FBtxtbox" Width="454px"></asp:TextBox>
        </div>
        <div class="floating-box">
            <asp:Label ID="lblZip" runat="server" Text="Zipcode"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Height="22px" MaxLength="5" CssClass="FBtxtbox" Width="454px"></asp:TextBox>
        </div>


       
       
         <div class="floating-boxxx" Height="50px">

          
             <asp:Button ID="btnRegister" runat="server" Height="42px" OnClick="btnContinue_Click" Text="Register" Width="649px" Font-Names="Century Gothic" Font-Size="Medium" />
             &nbsp;
             <asp:Label ID="lblGeneralError" runat="server"></asp:Label>
             <br />
             <asp:CheckBox ID="chkbxRemeberMe" runat="server"  Text="Remember Me at Login" />
              </div>
      <div class="floating-box">


          <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="WANT TO REGISTER AS A BUSINESS?"></asp:Label>
          <br />
          <br />
          <asp:Button ID="btnRegisterforBusinessAccount" runat="server" Font-Names="Century Gothic" Height="49px" style="margin-top: 0px" Text="Register for business account" Width="651px" OnClick="btnRegisterforBusinessAccount_Click" />


      </div>

                    
         </div>                                                                           
    </form>
</body>
</html>
