using TP_Amazon_ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;



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
            Customer newCustomer = new Customer();
          
            bool loginWorked = register.ValidLogin(txtEmail.Text, txtPassword.Text);     
            
            //if session exists, load cookie value into txtbx
            if (Session["email"] !=null)
            {
                HttpCookie emailCookie = Request.Cookies["Login_Cookie"];
                txtEmail.Text = emailCookie.Values["email"].ToString();
                chkbxRemeberMe.Checked = true;
            }

            //if user enters a valid username and password
            if (loginWorked)
            {
                Serialize objSerialize = new Serialize();
               TP_Amazon_ClassLibrary.Cart cart = (TP_Amazon_ClassLibrary.Cart)objSerialize.ReadCartFromDB(txtEmail.Text);
                if (cart != null)
                {
                    Session["Cart"] = cart;
                }
                else
                {
                    Session["Cart"] = new TP_Amazon_ClassLibrary.Cart();
                }
                //store email in session then redirect  
                Session["emailSession"] = txtEmail.Text;
                Response.Redirect("ProductCatalog.aspx");

                    //if "Remember Me" is checked, store userName in cookie
                    if (chkbxRemeberMe.Checked)
                    {
                        HttpCookie emailCookie = new HttpCookie("Login_Cookie");//cookie's name
                        emailCookie.Values["email"] = txtEmail.Text;           //set cookies value

                        emailCookie.Values["LastVisited"] = DateTime.Now.ToString();
                        emailCookie.Expires = DateTime.Now.AddYears(1);
                        Response.Cookies.Add(emailCookie);
                    }
                    else 
                    {
                        //remove user's email from username textbox
                        Response.Cookies.Remove("mycookie"); 
                    }
                
                //gets or sets a new serialized cart object
                   

                    
           

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



