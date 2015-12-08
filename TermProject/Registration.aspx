<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="TermProject.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 1095px;
            width: 934px;
            margin-right: 62px;
            margin-bottom: 12px;
            margin-left: 37px;
            margin-top: 30px;
        }
    </style>
    <link href="stylesheets/Registration.css" rel="stylesheet" />
    <script type="text/javascript">
        var xmlhttp;

        try {
            // Code for IE7+, Firefox, Chrome, Opera, Safari
            xmlhttp = new XMLHttpRequest();
        }
        catch (try_older_microsoft) {
            try {
                // Code for IE6, IE5
                xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
            }
            catch (other) {
                xmlhttp = false;
                alert("Your browser doesn't support AJAX!");
            }
        }

        function getValidationforEmail() {
            // Open a new asynchronous request, set the callback function, and send the request.
            var email = document.getElementById("txtEmail").value;
            xmlhttp.open("POST", "Validate.aspx", true);
            xmlhttp.onreadystatechange = onCompleteEmail;
            xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xmlhttp.send("email=" + email);
            console.log(email);
        }

        function getValidationforAllFields() {
            // Open a new asynchronous request, set the callback function, and send the request.
            var name = document.getElementById("txtName").value;
            xmlhttp.open("POST", "Validate.aspx?=everything", true);
            xmlhttp.onreadystatechange = onCompleteEverythingElse;
            xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xmlhttp.send("name=" + name);
        }

        // Callback function used to update the page when the server completes a response
        // to an asynchronous request.
        function onCompleteEmail() {
            //Response is READY and Status is OK
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                if (xmlhttp.responseText == "Email already exists!") {
                    document.getElementById("txtEmail").style.backgroundColor = 'red';
                }
                else {
                    document.getElementById("txtEmail").style.backgroundColor = '';
                }
            }



        }

        function onCompleteEverythingElse() {
            //Response is READY and Status is OK
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                if (xmlhttp.responseText == "Nope"){
                    document.getElementById("txtName").style.backgroundColor = 'red';
                }
                else {
                    document.getElementById("txtName").style.backgroundColor = '';
                }
            }



        }

    </script>


</head>

<body style="height: 1202px; width: 1134px; margin-top: 23px; margin-bottom: 39px; margin-right: 10px;">
    <form id="form1" runat="server">



        <div class="laurenscontent" style="top: 500px; margin-top: 14px;">
            <asp:Button ID="btnCancel" runat="server" CssClass="cancelbtn" Text="X" BackColor="#FF3300" Font-Bold="True" Height="23px" OnClick="btnCancel_Click" Width="30px" />
            <h1>Register </h1>

            <div class="floating-box">

                <asp:Label ID="Label1" runat="server" Text="Email" CssClass="FBlabel"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="FBtxtbox" Height="23px" AutoCompleteType="Email" Width="454px" onchange="getValidationforEmail()"></asp:TextBox>



            </div>

            <div class="floating-box">

                <asp:Label ID="lbl" runat="server" Text="Name" CssClass="FBlabel"></asp:Label>

                <asp:TextBox ID="txtName" runat="server" Height="23px" Style="margin-bottom: 0px;" CssClass="FBtxtbox" Width="454px" onchange="getValidationforAllFields()"></asp:TextBox>

                <asp:Label ID="lblInvalidName" runat="server" CssClass="FBlabel"></asp:Label>
            </div>

            <div class="floating-box">
                <asp:Label ID="Label2" runat="server" Text="Password" CssClass="FBlabel"></asp:Label>
                <asp:TextBox ID="txtpassword" runat="server" Height="22px" TextMode="Password" CssClass="FBtxtbox" Width="454px"></asp:TextBox>
                <asp:Label ID="lblPasswordsDontmatch" runat="server"></asp:Label>
            </div>
            <div class="floating-box">

                <asp:Label ID="Label3" runat="server" Text="Re-enter Password" CssClass="FBlabel"></asp:Label>
                <asp:TextBox ID="txtReenterPassword" runat="server" CssClass="FBtxtbox" Height="23px" TextMode="Password" Width="453px"></asp:TextBox>
                &nbsp;
            </div>
            <div class="floating-box">
                <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server" Style="margin-left: 0px" CssClass="FBtxtbox" Height="26px" Width="454px"></asp:TextBox>
            </div>
            <div class="floating-box">
                &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCity" runat="server" Style="margin-left: 0px" CssClass="FBtxtbox" Height="30px" Width="454px"></asp:TextBox>
            </div>

            <div class="floating-box">
                &nbsp;<asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtState" runat="server" Height="26px" MaxLength="2" CssClass="FBtxtbox" Width="454px"></asp:TextBox>
            </div>
            <div class="floating-box">
                <asp:Label ID="lblZip" runat="server" Text="Zipcode"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtZipcode" runat="server" Height="22px" MaxLength="5" CssClass="FBtxtbox" Width="454px"></asp:TextBox>
            </div>




            <div class="floating-boxxx" height="50px">


                <asp:Button ID="btnRegister" runat="server" Height="42px" OnClick="btnContinue_Click" Text="Register" Width="649px" Font-Names="Century Gothic" Font-Size="Medium" />
                &nbsp;
             <asp:Label ID="lblGeneralError" runat="server"></asp:Label>
                <br />
                <asp:CheckBox ID="chkbxRemeberMe" runat="server" Text="Remember Me at Login" />
            </div>
            <div class="floating-box">


                <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="WANT TO REGISTER AS A BUSINESS?"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnRegisterforBusinessAccount" runat="server" Font-Names="Century Gothic" Height="49px" Style="margin-top: 0px" Text="Register for business account" Width="651px" OnClick="btnRegisterforBusinessAccount_Click" />


            </div>


        </div>
    </form>
</body>
</html>
