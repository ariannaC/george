using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP_Amazon_ClassLibrary;
using Utilities;

namespace TermProject
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["Cart"] != null)
                {
                    
                    //TP_Amazon_ClassLibrary.Product testProduct = new TP_Amazon_ClassLibrary.Product();
                    //testProduct.Description = "Test Product";
                    //testProduct.Price = 20;
                    //testProduct.merchantName = "Princess Bubblegum";
                    //CartItem testItem = new CartItem(testProduct, 5);

                   

                    TP_Amazon_ClassLibrary.Cart cart = (TP_Amazon_ClassLibrary.Cart)Session["Cart"];
                    //cart.AddItem(testItem);
                    //cart.AddItem(testItem2);
                    rptCart.DataSource = cart.cartItems;
                    rptCart.DataBind();
                   // Session["Cart"] = cart;
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            TP_Amazon_ClassLibrary.Cart cart = (TP_Amazon_ClassLibrary.Cart)Session["Cart"];
            for (int i = 0; i < rptCart.Items.Count; i++)
            {
                CheckBox cb = (CheckBox)rptCart.Items[i].FindControl("chkSelect");
                if (cb.Checked == true)
                {
                    TextBox txtQ = (TextBox)rptCart.Items[i].FindControl("txtQuantity");
                    cart.cartItems[i].Quantity += int.Parse(txtQ.Text);
                }
            }
            rptCart.DataSource = cart.cartItems;
            rptCart.DataBind();
            Session["Cart"] = cart;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            TP_Amazon_ClassLibrary.Cart cart = (TP_Amazon_ClassLibrary.Cart)Session["Cart"];
            for (int i = 0; i < rptCart.Items.Count; i++)
            {
                CheckBox cb = (CheckBox)rptCart.Items[i].FindControl("chkSelect");
                if (cb.Checked == true)
                {
                    TP_Amazon_ClassLibrary.CartItem item = cart.cartItems[i];
                    cart.RemoveItem(item);
                }
            }
            rptCart.DataSource = cart.cartItems;
            rptCart.DataBind();
            Session["Cart"] = cart;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            TP_Amazon_ClassLibrary.Cart cart = (TP_Amazon_ClassLibrary.Cart)Session["Cart"];
            cart.ClearCart();
            rptCart.DataSource = cart.cartItems;
            rptCart.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            TP_Amazon_ClassLibrary.Cart cart = (TP_Amazon_ClassLibrary.Cart)Session["Cart"];
            TP_Amazon_ClassLibrary.Product testProduct2 = new TP_Amazon_ClassLibrary.Product();
            testProduct2.Description = "Test Product2";
            testProduct2.Price = 20;
            testProduct2.merchantName = "Murderface";
            CartItem testItem2 = new CartItem(testProduct2, 5);
            cart.AddItem(testItem2);
            Session["Cart"] = cart;
            rptCart.DataSource = cart.cartItems;
            rptCart.DataBind();
        }
    }
}
