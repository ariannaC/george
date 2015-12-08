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
                    //bind departments to dropdown using webservice method
                    MunchieServiceRef.TheWebService pxy = new MunchieServiceRef.TheWebService();
                    ApocalypseWebRef.TP_WebService apocProxy = new ApocalypseWebRef.TP_WebService();
                    JungleServiceRef.MerchantStore jungProxy = new JungleServiceRef.MerchantStore();
                    DataSet munchieDS = pxy.GetDepartments();
                    DataSet apocDS = apocProxy.getDepartment();
                    DataSet jungDS = jungProxy.GetDepartments();

                    for (int i = 0; i < munchieDS.Tables[0].Rows.Count; i++)
                    {
                        ddlDepartments.Items.Add(new ListItem(munchieDS.Tables[0].Rows[i]["DepartmentName"].ToString() + " - OSMS", munchieDS.Tables[0].Rows[i]["DepartmentNumber"].ToString()));
                    }

                    for (int i = 0; i < apocDS.Tables[0].Rows.Count; i++)
                    {
                        ddlDepartments.Items.Add(new ListItem(apocDS.Tables[0].Rows[i][apocDS.Tables[0].Columns[1].ColumnName].ToString() + " - ACO", apocDS.Tables[0].Rows[i][apocDS.Tables[0].Columns[0].ColumnName].ToString()));
                    }

                    for (int i = 0; i < jungDS.Tables[0].Rows.Count; i++)
                    {
                        ddlDepartments.Items.Add(new ListItem(jungDS.Tables[0].Rows[i][jungDS.Tables[0].Columns[1].ColumnName].ToString() + " - Jungle", jungDS.Tables[0].Rows[i][jungDS.Tables[0].Columns[0].ColumnName].ToString() + " - Jungle"));
                    }



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
            if (ddlDepartments.SelectedItem.Text.EndsWith("- OSMS"))
            {
                MunchieServiceRef.TheWebService pxy = new MunchieServiceRef.TheWebService();
                string department = ddlDepartments.SelectedIndex.ToString();
                DataSet ds = pxy.GetProductCatalog(department);
                rptProducts.DataSource = ds;
                rptProducts.DataBind();
            }
            else if (ddlDepartments.SelectedItem.Text.EndsWith("- ACO"))
            {
                ApocalypseWebRef.TP_WebService apocProxy = new ApocalypseWebRef.TP_WebService();
                DataSet apocDS = apocProxy.getCatalog(int.Parse(ddlDepartments.SelectedValue));
                apocDS.Tables[0].Columns[0].ColumnName = "ProductID";
                apocDS.Tables[0].Columns[1].ColumnName = "Description";
                apocDS.Tables[0].Columns[2].ColumnName = "Price";
                apocDS.Tables[0].Columns[3].ColumnName = "QuantityOnHand";
                apocDS.Tables[0].Columns[4].ColumnName = "DepartmentNumber";
                apocDS.Tables[0].Columns[5].ColumnName = "URL";
                rptProducts.DataSource = apocDS;
                rptProducts.DataBind();
            }
            else
            {
                string value = ddlDepartments.SelectedValue.Replace(" - Jungle", "");
                JungleServiceRef.MerchantStore jungProxy = new JungleServiceRef.MerchantStore();
                DataSet jungDS = jungProxy.GetProductCatalog(value);
                jungDS.Tables[0].Columns[0].ColumnName = "ProductID";
                jungDS.Tables[0].Columns[1].ColumnName = "Description";
                jungDS.Tables[0].Columns[2].ColumnName = "Price";
                jungDS.Tables[0].Columns[3].ColumnName = "QuantityOnHand";
                jungDS.Tables[0].Columns[4].ColumnName = "DepartmentNumber";
                jungDS.Tables[0].Columns[5].ColumnName = "URL";
                rptProducts.DataSource = jungDS;
                rptProducts.DataBind();
            }


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

            if (ddlDepartments.SelectedItem.Text.EndsWith("- OSMS"))
            {
                Session["sessionProdMerch"] = "One Stop Munchie Shop";
            }
            else if (ddlDepartments.SelectedItem.Text.EndsWith("- ACO"))
            {
                Session["sessionProdMerch"] = "Apocalypse Trading Co.";
            }

            else
            {
                Session["sessionProdMerch"] = "Jungle Store";
            }

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