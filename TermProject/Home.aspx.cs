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
            }
        }

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
         //  for(int i = 0; i <   ; i++)
            {
                //Label lblProductName = (Label)gvRow.FindControl("lblProductName"); 
               // Label productName = (Label)gvProducts.Rows[i].FindControl("lblProductName");
            }
  
        }




    }//end of class

}//end of namespace