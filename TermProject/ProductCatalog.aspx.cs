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
            if (!IsPostBack)
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
                        loadProducts();
                }
            }
        }//end of pageload


        protected void btnViewProduct_Click(object sender, EventArgs e)
        {


        }

        public void loadProducts()
        {
            //display data from each item in Product DB into correct template feilds
            //display product name into label
            //display product url image into image

            DBConnect dbobj = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetAllProducts";
            DataSet ds = dbobj.GetDataSetUsingCmdObj(objCommand);
            rptProducts.DataSource = ds;
            rptProducts.DataBind();
        }

        protected void ddlDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void rptProducts_ItemCommand(Object sender, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
        {
            int rowIndex = e.Item.ItemIndex;
            // Retrieve a value from a control in the Repeater's Items collection

            Label prodDescLabel = (Label)rptProducts.Items[rowIndex].FindControl("lblProductDesc");
            string productDesc = prodDescLabel.Text;

            HiddenField prodPriceLabel = (HiddenField)rptProducts.Items[rowIndex].FindControl("hidPrice");
            string prodPrice = prodPriceLabel.Value;

            HiddenField QOHLabel = (HiddenField)rptProducts.Items[rowIndex].FindControl("hidQOH");
            string QOH = QOHLabel.Value;

            HiddenField imgURLLabel = (HiddenField)rptProducts.Items[rowIndex].FindControl("hidImgURL");
            string imgURL = imgURLLabel.Value;

            HiddenField prodIDlabel = (HiddenField)rptProducts.Items[rowIndex].FindControl("hidProdID");
            string productID = prodIDlabel.Value;

            Session["sessionProdDesc"] = productDesc;
            Session["sessionProdPrice"] = prodPrice;
            Session["sessionProdID"] = productID;
            Session["sessionQOH"] = QOH;
            Session["sessionImgURL"] = imgURL;
            Response.Redirect("ProductDetails.aspx");


            //save productdesc in session to bring to next page 

            //stored procedure to get product info where productdesc = ""
 
        }

        //protected void rptProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
        //{
        //    int rowIndex = e.Item.ItemIndex;
        //    // Retrieve a value from a control in the Repeater's Items collection
        //    string productDesc = rptProducts.Items[rowIndex].FindControl("lblProductDesc").ToString();
        //    string prodPrice = rptProducts.Items[rowIndex].FindControl("hidPrice").ToString();
        //    string QOH = rptProducts.Items[rowIndex].FindControl("hidQOH").ToString();
        //    string imgURL = rptProducts.Items[rowIndex].FindControl("hidImgURL").ToString();

        //    Session["sessionProdDesc"] = productDesc;
        //    Session["sessionProdPrice"] = prodPrice;
        //    Session["sessionQOH"] = QOH;
        //    Session["sessionImgURL"] = imgURL;
        //    Response.Redirect("ProductDetails.aspx");
            

        //    //save productdesc in session to bring to next page 

        //    //stored procedure to get product info where productdesc = ""
        //}




    }//end of class

}//end of namespace