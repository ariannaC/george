<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="TermProject.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 739px;
            width: 930px;
            margin-right: 62px;
            margin-bottom: 39px;
            margin-left: 37px;
        }
    </style>
    <link href="stylesheets/Registration.css" rel="stylesheet" />
</head>
<body style="height: 795px; width: 1058px; margin-top: 21px; margin-bottom: 39px;">
    <form id="form1" runat="server">
       
  &nbsp;<div class ="content">
       <asp:Button ID="btnCancel" runat="server" CssClass="cancelbtn" Text="X" BackColor="#FF3300" Font-Bold="True" Height="31px" OnClick="btnCancel_Click" Width="37px" />
       <h1>Register </h1>
     
            <div class="floating-box">
                
                <asp:Label ID="Label1" runat="server" Text="Email" CssClass="FBlabel"></asp:Label>
               <asp:TextBox ID="txtEmail" runat="server" Width="423px" style="margin-left: 6px" CssClass="FBtxtbox" Height="21px"></asp:TextBox>
            </div>
     
        <div class="floating-box">
           
            <asp:Label ID="lbl" runat="server" Text="Name" CssClass="FBlabel"></asp:Label>

            <asp:TextBox ID="txtName" runat="server" Width="412px" Height="18px" style="margin-left: 4px; margin-top: 11px; margin-bottom: 0px;" CssClass="FBtxtbox"></asp:TextBox>
            <br />
            <asp:Label ID="lblInvalidName" runat="server"></asp:Label>
        </div>
           
      <div class="floating-box">
               
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Password" CssClass="FBlabel"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtpassword" runat="server" Height="22px" TextMode="Password" Width="324px"></asp:TextBox>
&nbsp;<br />
                <asp:Label ID="lblPasswordsDontmatch" runat="server"></asp:Label>
            </div>
                <div class="floating-box">
               
                    <asp:Label ID="Label3" runat="server" Text="Re-enter Password" CssClass="FBlabel"></asp:Label>
                    <asp:TextBox ID="txtReenterPassword" runat="server" CssClass="FBtxtbox" Height="23px" Width="314px" TextMode="Password"></asp:TextBox>
&nbsp;</div>


       
       
         <div class="floating-box">

          
             <asp:Button ID="btnRegister" runat="server" Height="40px" OnClick="btnContinue_Click" Text="Register" Width="481px" Font-Names="Century Gothic" Font-Size="Medium" />
             &nbsp;
             <asp:Label ID="lblGeneralError" runat="server"></asp:Label>
             <br />
             <asp:CheckBox ID="chkbxRemeberMe" runat="server"  Text="Remember Me at Login" />
              </div>
      <div class="floating-box">


          <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="WANT TO REGISTER AS A BUSINESS?"></asp:Label>
          <br />
          <br />
          <asp:Button ID="btnRegisterforBusinessAccount" runat="server" Font-Names="Century Gothic" Height="49px" style="margin-top: 0px" Text="Register for business account" Width="484px" />


      </div>

                    
         </div>                                                                           
    </form>
</body>
</html>
