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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            Register register = new Register();
           // Merchant newMerchant = new Merchant();

            //newMerchant.Name = txtName.Text;
            //newMerchant.Email = txtEmail.Text;
            //newMerchant.Password = txtpassword.Text;

            //Stored procedure to insert new merchant into a merchant table
        }
    }
}