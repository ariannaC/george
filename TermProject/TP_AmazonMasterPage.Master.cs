using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP_Amazon_ClassLibrary;

namespace TermProject
{
    public partial class TP_AmazonMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (!(Request.Cookies["Login_Cookie"] == null))
                {
                    HttpCookie emailCookie = Request.Cookies["Login_Cookie"];
                    lblWelcomeUser.Text = "Welcome " + emailCookie.Values["email"].ToString();   
                }
            }
        }

        protected void lnkbtnViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cart.aspx");
        }

        protected void lnkbtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Product.aspx");
        }

        protected void lnkbtnCheckOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CheckOut.aspx");   
        }

        protected void lnkbtnLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }

        protected void btnAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CreditCard.aspx");
        }
    }
}