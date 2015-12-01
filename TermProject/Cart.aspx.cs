using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP_Amazon_ClassLibrary;

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
                    //TEST CODE
                    TP_Amazon_ClassLibrary.Product testProduct = new TP_Amazon_ClassLibrary.Product();
                    testProduct.Description = "Test Product";
                    testProduct.Price = 20;
                    testProduct.merchantName = "Princess Bubblegum";
                    CartItem testItem = new CartItem(testProduct, 5);

                    TP_Amazon_ClassLibrary.Product testProduct2 = new TP_Amazon_ClassLibrary.Product();
                    testProduct2.Description = "Test Product2";
                    testProduct2.Price = 20;
                    testProduct2.merchantName = "Murderface";
                    CartItem testItem2 = new CartItem(testProduct2, 5);

                    TP_Amazon_ClassLibrary.Cart cart = (TP_Amazon_ClassLibrary.Cart)Session["Cart"];
                    cart.AddItem(testItem);
                    cart.AddItem(testItem2);
                    rptCart.DataSource = cart.cartItems;
                    rptCart.DataBind();
                }
            }
        }
    }
}