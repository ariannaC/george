using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Utilities;
using System.Data.SqlClient;

namespace TermProjectWS
{
    /// <summary>
    /// Summary description for TheWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TheWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet GetDepartments()
        {
            DBConnect DB = new DBConnect();
            //This method returns a list of Department Numbers and Department Names from the Department table in your database. 
            //The Dataset returned by the function consists of 2 columns corresponding to the Department Number and Department Name.

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "GetDepartments";
            DataSet DepDS = DB.GetDataSetUsingCmdObj(command);

            return DepDS;
        }

        [WebMethod]
        public DataSet GetProductCatalog(String DepartmentNumber)
        {
            //This method accepts a Department Number as input and returns a DataSet containing the Product Number, Description, Price, 
            //and image URL for all products in that Department.  Dataset consists of 4 columns corresponding to the Product Number, 
            //Description, Price, and image URL.  
             DBConnect DB = new DBConnect();
             SqlCommand command = new SqlCommand();
             command.CommandType = CommandType.StoredProcedure;
             command.CommandText = "ProductCatalog";
             command.Parameters.AddWithValue("@DepartmentNumber", DepartmentNumber);
             DataSet ProdDS = DB.GetDataSetUsingCmdObj(command);

            return ProdDS;
        }

        [WebMethod]
        public Boolean RegisterSite(String SiteID, String Description, String APIKey, String email, string contactInfo)
        {
           // This method will create a record for a site that will sell products on your behalf. You will need to store the Site’s 
            //ID and it should return true when it successfully registers a site and false when the registration fails. 
            //The APIKey was generated during the Merchant Registration process on the Amazon Site you used to create a Merchant Account 
            //(Term Project Part 1 – Section 4). This APIKey should be a unique value shared between you and the Amazon Site that sells 
            //your products.
            DBConnect DB = new DBConnect();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "RegisterSite";
            command.Parameters.AddWithValue("@APIKey", APIKey);
            command.Parameters.AddWithValue("@Desccription", Description);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Contact", contactInfo);
            SqlParameter outputparam = new SqlParameter("@RETVAL", 0);
            outputparam.Direction = ParameterDirection.Output;
            command.Parameters.Add(outputparam);
            int RETVAL;
            RETVAL = int.Parse(command.Parameters["@RETVAL"].Value.ToString());
            if (RETVAL == 1)
            {
                return true;
            }

            return false;
        }

        public Boolean Purchase(String ProductID, int Quantity, String APIKey /*String[] Customer Information, Customer CreditCard Information*/)
             {
                


                 return true;
             }

        [WebMethod]
        public string[] UpdateCustomer(CustomerClass fred, CreditCardClass cc, object[] stupid)
        {
            DBConnect DB = new DBConnect();
            SqlCommand command = new SqlCommand();
            string[] meh = new string[3];
            ErrorCodes ec = new ErrorCodes();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CustomerUpdate";
            command.Parameters.AddWithValue("@FirstName", fred.Firstname);
            command.Parameters.AddWithValue("@Address", fred.Address);
            command.Parameters.AddWithValue("@City", fred.City);
            command.Parameters.AddWithValue("@State", fred.State);
            command.Parameters.AddWithValue("@ZipCode", fred.ZipCode);
            command.Parameters.AddWithValue("@AccountBalance", cc.AccountBalance);
            meh[0] = (DB.DoUpdateUsingCmdObj(command) > 0) ? "true" : "false";
            SqlCommand sandy = new SqlCommand();
            sandy.CommandType = CommandType.StoredProcedure;
            sandy.CommandText = "VerifyInfo";
            sandy.Parameters.AddWithValue("@CreditCardNum", cc.CardNumber);
            sandy.Parameters.AddWithValue("@CVV", cc.CVV);
            sandy.Parameters.AddWithValue("@TransAmnt", float.Parse(stupid[2].ToString()));
            sandy.Parameters.AddWithValue("@FirstName", fred.Firstname);
            SqlParameter returnParam = new SqlParameter("@RVAL", DbType.Int32);
            returnParam.Direction = ParameterDirection.ReturnValue;
            sandy.Parameters.Add(returnParam);

            //            DataSet ds = DB.GetDataSetUsingCmdObj(sandy);
            DB.GetDataSetUsingCmdObj(sandy);
            meh[1] = sandy.Parameters["@RVAL"].Value.ToString();
            meh[2] = ec.GetErrorCodeMessage(int.Parse(meh[1]));


            return meh;
        }

       
    }
}
