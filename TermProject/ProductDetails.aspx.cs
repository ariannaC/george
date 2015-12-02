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
                int QOH = Int32.Parse(Session["sessionQOH"].ToString());
                string imgURL = Session["sessionImgURL"].ToString();
 
            }



            

        }//pageload

        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }



    
    
    
    
    
    }//end of class
}//end of namespace