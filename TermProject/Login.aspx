<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="stylesheets/CreditCardStyle.css" rel="stylesheet" />
    <style type="text/css">
        #form1 {
            height: 431px;
            width: 556px;
            margin-left: 68px;
            margin-bottom: 39px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
         <br />

        <div class="content" style="height: 400px; width: 543px; margin-top: 0px;">
                     <h1>Login</h1>
            <div class="floating-box">
                <asp:Label ID="Label1" runat="server" Text="Email:" Font-Bold="True"></asp:Label> &nbsp; 
                <asp:TextBox ID="txtEmail" runat="server" Width="292px" style="margin-left: 32px"></asp:TextBox>
            *</div> 


             <div class="floating-box">
                 <asp:Label ID="Label2" runat="server" Text="Password:" Font-Bold="True"></asp:Label>&nbsp;
                 <asp:TextBox ID="txtPassword" runat="server" Width="299px" TextMode="Password"></asp:TextBox>
             *<br />
            </div>

            <div class="floating-box" style="height: 65px; margin-top: 16px">
             <asp:CheckBox ID="chkbxRemeberMe" runat="server"  Text="Remember Me" />
            <br />
            <asp:Label ID="lblLoginErrorMessage" runat="server"></asp:Label>
                </div>

            <br />
            <div class="box">
                <asp:Button ID="btnLogin" runat="server" Height="35px" Text="Login" Width="100px" Font-Names="Century Gothic" OnClick="btnLogin_Click" />
            </div>
              <div class="box">
                     <asp:Button ID="btnNewUser" runat="server" Height="37px" style="margin-top: 0px" Text="Register" Width="102px" Font-Names="Century Gothic" OnClick="btnNewUser_Click" />
              </div>
               
          
           
               
          
        </div>




    </form>
</body>
</html>
