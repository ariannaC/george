using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Utilities;
using TermProjectWS;


namespace TermProject
{
    public partial class CreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["emailSession"] == null)
                {
                    Response.Redirect("Login.aspx");
                    return;
                }
                string email = Session["emailSession"].ToString();
                loadCreditCards(email);
                loadCustomerAccountSettings();
            }
        }

        //load customer info into Account Settings Field
        public void loadCustomerAccountSettings()
        {
            string email = Session["emailSession"].ToString();
            string customerName = lblCustomerName.Text;
            string customerEmail = lblEmail.Text;
            string password = lblpassword.Text;

            DBConnect dbobj = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_GetCustNameEmailPw";
            objCommand.Parameters.AddWithValue("@email", email);
            DataSet ds = dbobj.GetDataSetUsingCmdObj(objCommand);

            //Set label values equal to appropriate values from dataset
            lblCustomerName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            lblEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
            lblpassword.Text = ds.Tables[0].Rows[0]["password"].ToString();
        }

        //REPEATER METHODS
                //load Credit Cards into Repeater [will be removed]
                public void loadCreditCards(string email)
                {
                    DBConnect dbobj = new DBConnect();
                    SqlCommand objCommand = new SqlCommand();
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.CommandText = "TPgetCustomerCard";
                    objCommand.Parameters.AddWithValue("@email", email);
                    DataSet ds = dbobj.GetDataSetUsingCmdObj(objCommand);
                    rptPaymentOptions.DataSource = ds;
                    rptPaymentOptions.DataBind();
                }

        //Edit Credit Card Methods
        protected void btnAddNewCard_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NewCardApplication.aspx");
        }

        //Edit Account Settings
            //Modify Name Events
            protected void btnEditName_Click(object sender, EventArgs e)
            {
                btnEditName.Visible = false;      //hide edit button
                lblCustomerName.Visible = false; //hide name label

                btnUpdateName.Visible = true;     //show update button
                txtName.Visible = true;         //show text box       
            }
            protected void btnUpdateName_Click(object sender, EventArgs e)
            {
                string name = txtName.Text;

                if (name != "")//if entry is not blank
                {
                    updateName(name); //do DB update

                    txtName.Visible = false; //hide textbox
                    lblCustomerName.Visible = true; //show name label
                    lblNameError.Visible = false;   //hide error label
                    btnEditName.Visible = true;     //show edit name button
                    btnUpdateName.Visible = false;  //hide update button
                    loadCustomerAccountSettings();
                }
                else
                {
                    lblNameError.Text = "Name cannot be blank";
                }
            }

            //Modify Email Events
            protected void btnEditEmail_Click(object sender, EventArgs e)
            {
                btnEditEmail.Visible = false;
                lblEmail.Visible = false;

                txtEmail.Visible = true;
                btnUpdateEmail.Visible = true;

            }
            protected void btnUpdateEmail_Click(object sender, EventArgs e)
            {
                string email = txtEmail.Text; //get email from textbox 

                if (email != "")
                {
                    updateEmail(email);
                    txtEmail.Visible = false;
                    lblEmailError.Visible = false;
                    lblEmail.Visible = true;
                    btnEditEmail.Visible = true;
                    btnUpdateEmail.Visible = false;

                    Session["emailSession"] = email;

                    loadCustomerAccountSettings();
                }
                else 
                {
                    lblEmailError.Text = "Email cannot be blank";
                }
            }

            //Modify Password Events
            protected void btnEditPassword_Click(object sender, EventArgs e)
            {
                btnEditPassword.Visible = false;
                lblpassword.Visible = false;
                txtPassword.Visible = true;
                btnUpdatePassword.Visible = true;
            }
            protected void btnUpdatePassword_Click(object sender, EventArgs e)
            {
                string email = lblEmail.Text;
                string password = txtPassword.Text;

                if (password != "")
                {
                    updatePassword(password);

                    txtPassword.Visible = false;
                    lblPasswordError.Visible = false;
                    btnUpdatePassword.Visible = false;

                    btnEditPassword.Visible = true;
                    lblpassword.Visible = true;
                    loadCustomerAccountSettings();
                }
                else 
                {
                    lblPasswordError.Text = "Password cannot be blank";
                }
            }


            //update name method
            public void updateName(string name)
            {
                string email = lblEmail.Text;
                DBConnect dbobj = new DBConnect();
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_UpdateCustName";
                objCommand.Parameters.AddWithValue("@name", name);
                objCommand.Parameters.AddWithValue("@email", email);
                dbobj.DoUpdateUsingCmdObj(objCommand);
            }
            //update Email method
            public void updateEmail(string email)
            {
                string name = lblCustomerName.Text; //get customer name from label

                DBConnect dbobj = new DBConnect();
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_UpdateCustEmail";
                objCommand.Parameters.AddWithValue("@name", name);
                objCommand.Parameters.AddWithValue("@email", email);
                dbobj.DoUpdateUsingCmdObj(objCommand);
            }
            //update password method
            public void updatePassword(string password)
            {
                string email = lblEmail.Text; //parm for stored procedure

                DBConnect dbobj = new DBConnect();
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_UpdateCustPassword";
                objCommand.Parameters.AddWithValue("@password", password);
                objCommand.Parameters.AddWithValue("@email", email);
                dbobj.DoUpdateUsingCmdObj(objCommand);
            }

        protected void rptPaymentOptions_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int rowIndex = e.Item.ItemIndex;
            // Retrieve a value from a control in the Repeater's Items collection
            HiddenField hdnCardID = (HiddenField)rptPaymentOptions.Items[rowIndex].FindControl("hdnCardID");
            Response.Redirect("NewCardApplication.aspx?cardID=" + hdnCardID.Value);
        }

    }//end of class
}//edn of namespace
