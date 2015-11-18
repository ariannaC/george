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
            if (Session["emailSession"] == null)
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            //Add new Credit Card Methods
            //data fields
            string name = txtNameOnCard.Text;
            float cardNumber;
            int CSV;
            int expMonth;
            int expYear;

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
            db.DoUpdateUsingCmdObj(command);

            //CHECK IF CC WAS ADDED SUCCESSFULLY
            //if added successfully redirect
    Response.Redirect("~/CreditCard.aspx");
        
        
        }//end of clikc event
    }
}