using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data.SqlClient;
using System.Data;

namespace TermProject
{
    public partial class AuntFreida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DBConnect db = new DBConnect();
                string merchEmail = Session["emailSession"].ToString();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetMerchAccount";
                command.Parameters.AddWithValue("@email", merchEmail);
                DataSet ds = db.GetDataSetUsingCmdObj(command);
                gvMerchAccount.DataSource = ds;
                gvMerchAccount.DataBind();
            }

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void btnEditAccount_Click(object sender, EventArgs e)
        {
            ucMerch.Visible = true;
        }
    }
}