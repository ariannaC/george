using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.ComponentModel;

namespace TermProject
{
    public partial class MerchantInfo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
    }
}