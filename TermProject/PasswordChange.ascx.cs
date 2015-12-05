using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace TermProject
{
    public partial class PasswordChange : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [Category("Misc")]
        public String OldPass
        {
            get { return txtOldPass.Text; }
            set { txtOldPass.Text = value; }
        }

        [Category("Misc")]
        public String NewPass1
        {
            get { return txtNewPass1.Text; }
            set { txtNewPass1.Text = value; }
        }

        [Category("Misc")]
        public String NewPass2
        {
            get { return txtNewPass2.Text; }
            set { txtNewPass2.Text = value; }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            string oldpass = txtOldPass.Text;
            string newpass1 = txtNewPass1.Text;
            string newpass2 = txtNewPass2.Text;
            if (newpass1 == newpass2)
            {
                DBConnect db = new DBConnect();
                
                string email = Session["emailSession"].ToString();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UpdateMerch";
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@oldPass", oldpass);
                command.Parameters.AddWithValue("@newPass1", newpass1);
                command.Parameters.AddWithValue("@newPass2", newpass2);
                db.DoUpdateUsingCmdObj(command);
            }

            else
            {
                Label lblerror = new Label();
                lblerror.Text = "New Passwords do not match please try again";
            }
        }
    }
}