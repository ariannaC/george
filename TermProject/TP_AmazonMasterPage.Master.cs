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
            TP_Amazon_ClassLibrary.Cart cart = (TP_Amazon_ClassLibrary.Cart)Session["Cart"];
            lnkbtnViewCart.Text = "Cart(" + cart.TotalQuantity + ")";
            if (!IsPostBack)
            {
                if (!(Session["emailSession"] == null))
                {
                    string email = Session["emailSession"].ToString();

                    lblWelcomeUser.Text = "Welcome " + email;
                }
                else 
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void lnkbtnViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cart.aspx");
        }

        protected void lnkbtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ProductCatalog.aspx");
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