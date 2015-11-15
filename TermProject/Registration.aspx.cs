using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TermProject
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Register Button
        protected void btnContinue_Click(object sender, EventArgs e)
        {
            //if "Remember Me" is checked, store userName in cookie
            if (chkbxRemeberMe.Checked)
            {
                HttpCookie myCookie = new HttpCookie("Login_Cookie");
                myCookie.Values["email"] = txtEmail.Text;
                myCookie.Values["LastVisited"] = DateTime.Now.ToString();
                myCookie.Expires = new DateTime(2025, 1, 1);

                Response.Cookies.Add(myCookie);
            }
            else
            {
                //remove user's email from username textbox
                Response.Cookies.Remove("mycookie");
            }



        }//end of Registerbutton click event


        public bool ValidFields()
        {
            bool validInput;

            if (txtEmail.Text.IndexOf("@") == -1 || txtEmail.Text.IndexOf(".") == -1)
            {
                return false;
            }

           // if (  bool passwordsEqual = String.Equals(textBox1.ToString(), textBox2.ToString())) 
            else 
            {
                return true;
            }



        }

    
    
    
    
    }//end of class




}//end of namespace

