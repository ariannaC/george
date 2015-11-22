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
    public partial class NewCardApplication : System.Web.UI.Page
    {

        DBConnect db = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["emailSession"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                if (Request["cardID"] != null)
                {
                    Button1.Text = "EDIT CARD";
                    pageHeader.InnerText = "Edit the Selected Credit Card";
                    int cardID = Int32.Parse(Request["cardID"].ToString());
                    txtCardNumber.Enabled = false;
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "TP_GetCardWithCCID";
                    command.Parameters.AddWithValue("@CCID", cardID);
                    DataSet ds = db.GetDataSetUsingCmdObj(command);
                    txtNameOnCard.Text = ds.Tables[0].Rows[0]["NameOnCard"].ToString();
                    txtCardNumber.Text = ds.Tables[0].Rows[0]["CardNumber"].ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (Request["cardID"] != null)
            {
                // Button1.Text = "EDIT CARD";
                //  pageHeader.InnerText = "Edit the Selected Credit Card";
                int expM = Int32.Parse(ddlExpMonth.SelectedItem.Text);
                int expY = Int32.Parse(ddlExpYear.SelectedItem.Text);
                int cvv = Int32.Parse(txtCSV.Text);
                int cardID = Int32.Parse(Request["cardID"].ToString());
                SqlCommand stacey = new SqlCommand();
                stacey.CommandType = CommandType.StoredProcedure;
                stacey.CommandText = "TP_UpdateCardInfo";
                stacey.Parameters.AddWithValue("@CCID", cardID);
                stacey.Parameters.AddWithValue("@CVV", cvv);
                stacey.Parameters.AddWithValue("@NameOnCard", txtNameOnCard.Text);
                stacey.Parameters.AddWithValue("@ExpMonth", expM);
                stacey.Parameters.AddWithValue("@ExpYear", expY);
                db.DoUpdateUsingCmdObj(stacey);
            }

            //Add new Credit Card Methods

            else
            {   //data fields
                string name = txtNameOnCard.Text;
                float cardNumber;
                int CSV;
                int expMonth;
                int expYear;
                string email = Session["emailSession"].ToString();

                //conditions
                bool validCardNumber = float.TryParse(txtCardNumber.Text, out cardNumber);
                bool validCSV = int.TryParse(txtCSV.Text, out CSV);
                bool validExpMonth = int.TryParse(ddlExpMonth.SelectedValue, out expMonth);
                bool validExpYear = int.TryParse(ddlExpYear.SelectedValue, out expYear);

                if (validCardNumber && validExpMonth && validExpYear && validCSV)
                {
                    cardNumber = float.Parse(txtCardNumber.Text);
                    expMonth = Int32.Parse(ddlExpMonth.SelectedItem.Text);
                    expYear = Int32.Parse(ddlExpYear.SelectedItem.Text);
                    CSV = Int32.Parse(txtCSV.Text);
                    //   // CreditCardWSRef.CreditCardWS pxy = new CreditCardWSRef.CreditCardWS();
                    //    //pxy.AddCreditCardAccount(name, cardNumber, expMonth, expYear, CSV);
                }

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "TP_AddNewCard";
                command.Parameters.AddWithValue("@CreditCardNumber", cardNumber);
                command.Parameters.AddWithValue("@CVV", CSV);
                command.Parameters.AddWithValue("@ExpMonth", expMonth);
                command.Parameters.AddWithValue("@ExpYear", expYear);
                command.Parameters.AddWithValue("@CreditLimit", 1000);
                command.Parameters.AddWithValue("@AccountBalance", 0);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Email", email);
                db.DoUpdateUsingCmdObj(command);
            }
            //CHECK IF CC WAS ADDED SUCCESSFULLY
            //if added successfully redirect
    Response.Redirect("~/CreditCard.aspx");

        
        }//end of clikc event
    }
}