<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterMerchant.aspx.cs" Inherits="TermProject.RegisterMerchant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="stylesheets/Registration.css" rel="stylesheet" />
</head>
<body style="height: 719px; width: 1059px; margin-top: 21px; margin-bottom: 39px;">
    <form id="form1" runat="server">
       
  &nbsp;<div class ="content">

      <div >
          <asp:Button ID="btnCancel" runat="server" CssClass="cancelbtn" Text="X" BackColor="#FF3300" Font-Bold="True" Height="31px" OnClick="btnCancel_Click" Width="38px"  />
         
      </div> 
       <h1>Register as a Business </h1>
     
            <div class="floating-box">
                
                <asp:Label ID="Label1" runat="server" Text="Email" CssClass="FBlabel"></asp:Label>
               <asp:TextBox ID="txtEmail" runat="server" Width="438px" style="margin-left: 6px" CssClass="FBtxtbox" Height="23px"></asp:TextBox>
            </div>
     
        <div class="floating-box">
           
            <asp:Label ID="lbl" runat="server" Text="Company Name" CssClass="FBlabel"></asp:Label>

            <asp:TextBox ID="txtName" runat="server" Width="441px" Height="23px" style="margin-left: 4px; margin-top: 11px; margin-bottom: 0px;" CssClass="FBtxtbox"></asp:TextBox>
            <br />
      
        </div>
           
       <div class="floating-box">
            <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server" Width="445px" style="margin-left: 0px" CssClass="FBtxtbox" Height="26px"></asp:TextBox>

        </div>
      <div class ="floating-box">
          <asp:Label ID="lblURL" runat="server" Text="Site URL"></asp:Label>
           <asp:TextBox ID="txtURL" runat="server" Width="445px" style="margin-left: 0px" CssClass="FBtxtbox" Height="26px"></asp:TextBox>
      </div>


       
       
         <div class="floating-boxxx">

          
             <asp:Button ID="btnRegister" runat="server" Height="47px" OnClick="btnContinue_Click" Text="Register Business" Width="650px" Font-Names="Century Gothic" Font-Size="Medium" />
             &nbsp;<asp:Label ID="lblGeneralError" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
&nbsp;<br />
              </div>

                    
         </div>                                                                           
    </form>
</body>
</html>
