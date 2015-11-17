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
    public partial class CreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void loadCreditCards()
        {
            DBConnect objdb = new DBConnect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "GetAllCC";
            DataSet dataset = objdb.GetDataSetUsingCmdObj(sqlCommand);
            gvCreditCards.DataSource = ds;
            gvCreditCards.DataBind();
 
 

        }





    }
}