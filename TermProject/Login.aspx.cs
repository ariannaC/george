using TP_Amazon_ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace TP
{
    public partial class Login : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //1. check against database
            //2. grant access to next page based on successful login
            //GetAccountBy_CustomerEmail Stored Procedure to get the email stored in DB

            //Register object from the Register class in the "TP_Amazon_ClassLibrary"
            Register register = new Register();
            bool loginWorked = register.ValidLogin(txtUserName.Text, txtPassword.Text);            

            //if user enters a valid username and password
            if (loginWorked == true)
            {
                    //if "Remember Me" is checked, store userName in cookie
                    if (chkbxRemeberMe.Checked)
                    {
                        HttpCookie myCookie = new HttpCookie("Login_Cookie");
                        myCookie.Values["userName"] = txtUserName.Text;
                        myCookie.Values["LastVisited"] = DateTime.Now.ToString();
                        myCookie.Expires = new DateTime(2025, 1, 1);

                        Response.Cookies.Add(myCookie);
                    }
                    else 
                    {
                        //remove user's email from username textbox
                        Response.Cookies.Remove("mycookie"); 
                    }

            }//end of loginWorked if statement

            //else not a valid login
            else
            {
                lblLoginErrorMessage.Text = "Invalid Credentials. To create a new account select New User";
            }


        }

        protected void btnNewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }//end of login button click event 
   
    
    }//end of Login class


}//end of namespace