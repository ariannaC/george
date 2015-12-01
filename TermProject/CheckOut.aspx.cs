using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Utilities;
using TP_Amazon_ClassLibrary;

namespace TermProject
{
    public partial class CheckOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["emailSession"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }


            string email = Session["emailSession"].ToString();



            loadCreditCards(email);


        }

        public void loadCreditCards(string email)
        {
            DBConnect objdb = new DBConnect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "TPgetCustomerCard";
            sqlCommand.Parameters.AddWithValue("@email", email);
            DataSet dataset = objdb.GetDataSetUsingCmdObj(sqlCommand);

            if (dataset.Tables[0].Rows.Count > 0)
            {
                ddlCreditCardList.DataSource = dataset;
                ddlCreditCardList.DataTextField = "CardNumber";
                ddlCreditCardList.DataValueField = "CardNumber";
                ddlCreditCardList.DataBind();
            }
        }


        

        protected void btnAddCreditCard_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewCardApplication.aspx");
        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {
            TP_Amazon_ClassLibrary.CartItem Item = new TP_Amazon_ClassLibrary.CartItem();
            Item.AddQuantity(3);
            TP_Amazon_ClassLibrary.Cart cart = (TP_Amazon_ClassLibrary.Cart)Session["Cart"];
            cart.AddItem(Item);
            Session["Cart"] = cart;
        }
    }
}