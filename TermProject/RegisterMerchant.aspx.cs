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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

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
            lblGeneralError.Text = "Your APIKey is " + apikey;
            
 
            //Stored procedure to insert new merchant into a merchant table
        }
    }
}