using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP_Amazon_ClassLibrary;
using System.Data.SqlClient;
using Utilities;
using System.Data.SqlTypes;

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

            DBConnect DB = new DBConnect();
            Register register = new Register();
            Merchant newMerchant = new Merchant();

            newMerchant.groupName = txtName.Text;
            newMerchant.email = txtEmail.Text;
            newMerchant.address = txtAddress.Text;

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "RegisterMerchant";
            command.Parameters.AddWithValue("@GroupName", newMerchant.groupName);
            command.Parameters.AddWithValue("@Email", newMerchant.email);
            command.Parameters.AddWithValue("@Address", newMerchant.address);
            DB.DoUpdateUsingCmdObj(command);

            SqlCommand key = new SqlCommand();
            key.CommandType = System.Data.CommandType.StoredProcedure;
            key.CommandText = "InsertKey";
            command.Parameters.AddWithValue("@GroupName", newMerchant.groupName);
            string apikey = DB.GetDataSetUsingCmdObj(key).ToString();
            lblGeneralError.Text = "Youe APIKey is " + apikey;
 
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