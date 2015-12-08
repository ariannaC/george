using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using TP_Amazon_ClassLibrary;

namespace TermProject
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["emailSession"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                //retrieve the product info selected
                string prodDesc = Session["sessionProdDesc"].ToString();
                string prodPrice = Session["sessionProdPrice"].ToString();
                string QOH = Session["sessionQOH"].ToString();
                //int QOH = (int)Session["sessionQOH"];
                string imgURL = Session["sessionImgURL"].ToString();

                lblprodDesc.Text = prodDesc;
                lblUnitPrice.Text = prodPrice;
                //lblQuantity.Text = "";
                imgProduct.ImageUrl = imgURL;
 
            }



            

        }//pageload

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                // Response.Redirect("~/Cart.aspx");
                TP_Amazon_ClassLibrary.Cart cart = (TP_Amazon_ClassLibrary.Cart)Session["Cart"];
                TP_Amazon_ClassLibrary.Product product = new TP_Amazon_ClassLibrary.Product();
                product.ProductID = Session["sessionProdID"].ToString();
                product.Description = Session["sessionProdDesc"].ToString();
                product.Price = decimal.Parse(lblUnitPrice.Text.Substring(1));
                product.merchantName = "One Stop Munchie Shop";
                product.URL = Session["sessionImgURL"].ToString();
                CartItem Item = new CartItem(product, int.Parse(txtQuantity.Text));
                cart.AddItem(Item);
                Session["Cart"] = cart;
                lblQOHError.Text = "";
            }
            else 
            {
                lblQOHError.Text = "Select a Quantity!";
            }
           
        }

        protected void imgProduct_Load(object sender, EventArgs e)
        {
            
        }

        //protected void txtQuantity_TextChanged(object sender, EventArgs e)
        //{
        //   // txtQuantity.Text = "1";
        //}

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }



    
    
    
    
    
    }//end of class
}//end of namespace