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
           // string prodPrice = Session["sessionProdPrice"].ToString();


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
                ddlCreditCardList.DataValueField = "CVV";
                ddlCreditCardList.DataBind();
            }
        }


        
        protected void btnAddCreditCard_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewCardApplication.aspx");
        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {
            string[] purcInfo = new string[15];
            TP_Amazon_ClassLibrary.Cart cart = (TP_Amazon_ClassLibrary.Cart)Session["Cart"];
            string merchantname = "";
            for (int i = 0; i < cart.cartItems.Count; i++)
            {
                merchantname = cart.cartItems[i].Product.merchantName;
                if (merchantname == "One Stop Munchie Shop")
                {
                    string prodID = cart.cartItems[i].Product.ProductID.ToString();
                    int prodQuantity = cart.cartItems[i].Quantity;
                    string apikey = "ef2b1305-07ee-4712-be15-35f82b367a94";
                    MunchieServiceRef.TheWebService prxy = new MunchieServiceRef.TheWebService();
                    purcInfo[0] = Session["emailSession"].ToString();
                    purcInfo[1] = txtCustName.Text;
                    purcInfo[2] = txtAddress.Text;
                    purcInfo[3] = txtCity.Text;
                    purcInfo[4] = txtState.Text;
                    purcInfo[5] = txtCountry.Text;
                    purcInfo[6] = TextBox5.Text;
                    purcInfo[7] = TextBox2.Text;
                    purcInfo[8] = TextBox3.Text;
                    purcInfo[9] = TextBox4.Text;
                    purcInfo[10] = TextBox6.Text;
                    purcInfo[11] = ddlCreditCardList.SelectedItem.Text;
                    purcInfo[12] = ddlCreditCardList.SelectedValue;
                    prxy.Purchase(prodID, prodQuantity, apikey, purcInfo);

                }
                else
                {
                    int prodQuantity = cart.cartItems[i].Quantity;
                    string prodID = cart.cartItems[i].Product.ProductID.ToString();
                    ApocalypseWebRef.TP_WebService apocprxy = new ApocalypseWebRef.TP_WebService();
                    apocprxy.Purchase(prodID, prodQuantity, "Apocalypse Trading Co", "403f3304-f069-485a-b971-f47778dbbc77", purcInfo);
                }
            }
          //  string emailBody = "<p>Works!!</p>s";
           // TP_Amazon_ClassLibrary.Cart cart = (TP_Amazon_ClassLibrary.Cart)Session["Cart"];
            cart.ClearCart();
            //Email emailSender = new Email();
            //emailSender.SendMail("tue69402@temple.edu", "no-reply@munchiestore.com", "Reservation Confirmation", emailBody, "tue69402@temple.edu");
           
        }
    }
}
//ommand.Parameters.AddWithValue("@Email", customercardinfo[0]);
//            command.Parameters.AddWithValue("@Name", customercardinfo[1]);
//            command.Parameters.AddWithValue("@ShippingAddress", customercardinfo[2]);
//            command.Parameters.AddWithValue("@ShippingCity", customercardinfo[3]);
//            command.Parameters.AddWithValue("@ShippingState", customercardinfo[4]);
//            command.Parameters.AddWithValue("@ShippingCountry", customercardinfo[5]);
//            command.Parameters.AddWithValue("@ShippingZipCode", customercardinfo[6]);
//            command.Parameters.AddWithValue("@BillingAddress", customercardinfo[7]);
//            command.Parameters.AddWithValue("@BillingCity", customercardinfo[8]);
//            command.Parameters.AddWithValue("@BillingState", customercardinfo[9]);
//            command.Parameters.AddWithValue("@BillingZip", customercardinfo[10]);