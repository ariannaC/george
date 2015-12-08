using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace TermProject
{
    public partial class Validate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["email"] != null)
            {
                // check email validity
                string email = Request["email"].ToString();
                //check if email is unique w stored procedure 
                DataSet myDS = new DataSet();
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_ValidLogin";
                objCommand.Parameters.AddWithValue("@Email", email);
                objCommand.Parameters.AddWithValue("@password", "");
                DBConnect objDB = new DBConnect();
                myDS = objDB.GetDataSetUsingCmdObj(objCommand);

                if (myDS.Tables[0].Rows.Count > 0)
                {
                    Response.Write("Email already exists!");
                }
                else
                {
                    Response.Write("Ok");
                }
            }
            else if (Request["name"] != null)
            {
                // check everything else
                string name = Request["name"].ToString();
                if (name.Length > 0)
                {
                    Response.Write("Ok");
                }
                else
                {
                    Response.Write("Nope");
                }

            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }//end of page load







    }//end of class
}//end of namespace