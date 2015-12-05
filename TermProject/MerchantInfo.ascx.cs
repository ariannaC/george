using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;

namespace TermProject
{
    public partial class MerchantInfo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtEmail.Text = Session["emailSession"].ToString();
            }
        }

        [Category("Misc")]
        public String MerchantName
        {
            get { return txtMerchName.Text; }
            set { txtMerchName.Text = value; }
        }

        [Category("Misc")]
        public String Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }

        [Category("Misc")]
        public String Address
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }

        [Category("Misc")]
        public String URL
        {
            get { return txtUrl.Text; }
            set { txtUrl.Text = value; }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            DBConnect db = new DBConnect();
            string name = txtMerchName.Text;
            string addres = txtAddress.Text;
            string url = txtUrl.Text;
            string email = Session["emailSession"].ToString();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateMerch";
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@address", addres);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@url", url);
            db.DoUpdateUsingCmdObj(command);

            txtAddress.Text = "";
            txtEmail.Text = "";
            txtMerchName.Text = "";
            txtUrl.Text = "";

            this.Visible = false;

        }
    }
}