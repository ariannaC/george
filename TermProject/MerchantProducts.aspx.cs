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
    public partial class MerchantProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserName"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                showDepartments();
            }

        }



        public void showDepartments()
        {
            //TPServiceRef.TheWebService pxy = new TPServiceRef.TheWebService();
            //string depNumber = txtDepartmentNumber.Text;
            //DataSet ds = pxy.GetProductCatalog(depNumber);
            //gvMerchantProducts.DataSource = ds;
            //gvMerchantProducts.DataBind();

        }


    }
}