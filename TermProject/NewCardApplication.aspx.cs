using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TermProject
{
    public partial class NewCardApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                expMonth = Int32.Parse(ddlExpMonth.SelectedValue);
                expYear = Int32.Parse(ddlExpYear.SelectedValue);
                CSV = Int32.Parse(txtCSV.Text);
               // CreditCardWSRef.CreditCardWS pxy = new CreditCardWSRef.CreditCardWS();
                //pxy.AddCreditCardAccount(name, cardNumber, expMonth, expYear, CSV);
            }


            //CHECK IF CC WAS ADDED SUCCESSFULLY
            //if added successfully redirect
            Response.Redirect("~/CreditCArd.aspx");
        
        
        }//end of clikc event
    }
}