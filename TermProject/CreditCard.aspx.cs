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

               

                string email = Session["emailSession"].ToString();

                loadCreditCards(email);
                loadCustomerAccountSettings();
            }
        }


        public void loadCreditCards(string email)
        {
            DBConnect dbobj = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPgetCustomerCard";
            objCommand.Parameters.AddWithValue("@email", email);
            DataSet ds = dbobj.GetDataSetUsingCmdObj(objCommand);
            rptPaymentOptions.DataSource = ds;
            rptPaymentOptions.DataBind();
        }

        protected void btnAddNewCard_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NewCardApplication.aspx");
        }

        protected void btnEditCard_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < gvCreditCard.Rows.Count; row++)
            {
                CheckBox cb = (CheckBox)gvCreditCard.Rows[row].FindControl("cbEdit");

                if (cb.Checked == true)
                {
                    Response.Redirect("NewCardApplication.aspx?cardID=" + gvCreditCard.Rows[row].Cells[1].Text);
                }
            }
        }

        protected void btnEditName_Click(object sender, EventArgs e)
        {

        } 
           // showAccounts();
        public void loadCustomerAccountSettings()
        {
           string email = Session["emailSession"].ToString();
           string customerName = lblCustomerName.Text;
           string customerEmail = lblEmail.Text;
           string password = lblpassword.Text;

           DBConnect dbobj = new DBConnect();
           SqlCommand objCommand = new SqlCommand();
           objCommand.CommandType = CommandType.StoredProcedure;
           objCommand.CommandText = "TP_GetCustNameEmailPw";
           objCommand.Parameters.AddWithValue("@email", email);
           DataSet ds = dbobj.GetDataSetUsingCmdObj(objCommand);
           lblCustomerName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
           lblEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
        }

        protected void rptPaymentOptions_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int rowIndex = e.Item.ItemIndex;
            // Retrieve a value from a control in the Repeater's Items collection
        }
    

    }//end of class
}//edn of namespace
