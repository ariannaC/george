using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP_Amazon_ClassLibrary;

namespace TermProject
{
    public partial class RegisterMerchant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Register Merchant Button
        protected void btnContinue_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            Merchant newMerchant = new Merchant();

            newMerchant.name = txtName.Text;
            newMerchant.email = txtEmail.Text;
            newMerchant.password = txtpassword.Text;

            //Stored procedure to insert new merchant into a merchant table

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
            Response.Redirect("Login.aspx");



        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void chkbxRemeberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}