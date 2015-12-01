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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["emailSession"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {

                DBConnect dbobj = new DBConnect();
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetDepartments";
                ddlDepartments.DataSource = dbobj.GetDataSetUsingCmdObj(objCommand);
                ddlDepartments.DataTextField = "DepartmentName";
                ddlDepartments.DataBind();
              //  loadProductsIntoGrid(); 

               
            }
        }//end of pageload

        protected void gvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnViewProduct_Click(object sender, EventArgs e)
        {


        }

        public void loadProductsIntoGrid()
        {
            DBConnect dbobj = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetAllProducts";
            DataSet ds = dbobj.GetDataSetUsingCmdObj(objCommand);
            DataRow product = ds.Tables[0].Rows[0];

            //display data from each item in Product DB into correct template feilds
            //display product name into label
            //display product url image into image

            foreach(GridViewRow row in gvProducts.Rows)
          {
                
           //     for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
           //     {
           //        lblProductName.Text =  product.ItemArray[2].ToString();


           //        lblProductName = (Label)gvProducts.Rows[i].FindControl("lblProductName"); 
           //        // Label productName = (Label)gvProducts.Rows[i].FindControl("lblProductName");
           //     }
          }
  
        }

        protected void ddlDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }//end of class

}//end of namespace