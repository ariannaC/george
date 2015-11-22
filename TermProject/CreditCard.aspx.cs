using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Utilities;
using TermProjectWS;


namespace TermProject
{
    public partial class CreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["emailSession"] == null)
                {
                    Response.Redirect("Login.aspx");
                    return;
                }

                //DBConnect objdb = new DBConnect();
                //SqlCommand command = new SqlCommand();
                //command.CommandType = CommandType.StoredProcedure;
                //command.CommandText = "TPgetCustomerCard";
                //DataSet ds = objdb.GetDataSetUsingCmdObj(command);
                //gvCreditCards.DataSource = ds;
                //gvCreditCards.DataBind();


                string email = Session["emailSession"].ToString();

                loadCreditCards(email);
            }
        }


        public void loadCreditCards(string email)
        {
            DBConnect objdb = new DBConnect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "TPgetCustomerCard";
            sqlCommand.Parameters.AddWithValue("@email",email);
            DataSet dataset = objdb.GetDataSetUsingCmdObj(sqlCommand);

            if (dataset.Tables[0].Rows.Count > 0)
            {
               // gvCreditCards.DataSource = dataset;
               // gvCreditCards.DataBind();
                GridView1.DataSource = dataset;
                GridView1.DataBind();
            }
        }

        protected void btnAddNewCard_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NewCardApplication.aspx");
        }

        protected void btnEditCard_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < GridView1.Rows.Count; row++)
            {
                CheckBox cb = (CheckBox)GridView1.Rows[row].FindControl("cbEdit");

                if (cb.Checked == true)
                {
                    Response.Redirect("NewCardApplication.aspx?cardID=" + GridView1.Rows[row].Cells[1].Text);
                }
            }
        } 
           // showAccounts();
        
    

    }//end of class
}//edn of namespace
