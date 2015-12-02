using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                
 
            }



            

        }//pageload

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cart.aspx");
        }

        protected void imgProduct_Load(object sender, EventArgs e)
        {
            
        }

        protected void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            txtQuantity.Text = "1";
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cart.aspx");
        }



    
    
    
    
    
    }//end of class
}//end of namespace