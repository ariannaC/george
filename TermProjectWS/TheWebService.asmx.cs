using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Utilities;
using System.Data.SqlClient;
using TP_Amazon_ClassLibrary;

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
            SqlParameter outputparam = new SqlParameter("@RETVAL", DbType.Int32);
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

        public Boolean Purchase(String ProductID, int Quantity, String APIKey, Customer cust)
             {
                 DBConnect db = new DBConnect();
                 SqlCommand command = new SqlCommand();
                 command.CommandType = CommandType.StoredProcedure;
                 command.CommandText = "PurchaseItem";
                 command.Parameters.AddWithValue("@ProductID", ProductID);
                 command.Parameters.AddWithValue("@Quantity", Quantity);
                 command.Parameters.AddWithValue("@APIKey", APIKey);
                 command.Parameters.AddWithValue("@Email", cust.email);
                 command.Parameters.AddWithValue("@Name", cust.name);
                 command.Parameters.AddWithValue("@ShippingAddress", cust.shippingAddress);
    //        @ShippingCity varchar(MAX),
    //@ShippingState varchar(MAX),
    //@ShippingZipCode int,
    //@ShippingCountry varchar(MAX),
    //@BillingAddress varchar(MAX),
    //@BillingCity varchar(MAX),
    //@BillingState varchar(MAX),
    //@BillingCountry varchar(MAX),
    //@BillingZip varchar(MAX)


                 return true;
             }

        //[WebMethod]
        //public void VerifyCard(Customer fred, CreditCardClass cc, object[] stupid)
        //{
        //    DBConnect DB = new DBConnect();
   
        //    SqlCommand sandy = new SqlCommand();
        //    sandy.CommandType = CommandType.StoredProcedure;
        //    sandy.CommandText = "VerifyInfo";
        //    sandy.Parameters.AddWithValue("@CreditCardNum", cc.CardNumber);
        //    sandy.Parameters.AddWithValue("@CVV", cc.CVV);
        //    sandy.Parameters.AddWithValue("@TransAmnt", float.Parse(stupid[2].ToString()));
        //    sandy.Parameters.AddWithValue("@FirstName", fred.Name);
        //    SqlParameter returnParam = new SqlParameter("@RVAL", DbType.Int32);
        //    returnParam.Direction = ParameterDirection.ReturnValue;
        //    sandy.Parameters.Add(returnParam);

        //    //            DataSet ds = DB.GetDataSetUsingCmdObj(sandy);
        //    DB.GetDataSetUsingCmdObj(sandy);
        //    //meh[1] = sandy.Parameters["@RVAL"].Value.ToString();
        //    //meh[2] = ec.GetErrorCodeMessage(int.Parse(meh[1]));


        //    //return meh;
        //}

        //[WebMethod]
        //public bool AddCard(CreditCardClass cc, Customer matilda)
        //{
        //    DBConnect DB = new DBConnect();
        //    SqlCommand command = new SqlCommand();
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.CommandText = "AddCard";
        //    command.Parameters.AddWithValue("@CreditCardNumber", cc.CardNumber);
        //    command.Parameters.AddWithValue("@CVV", cc.CVV);
        //    command.Parameters.AddWithValue("@AccountNumber", cc.AccountNumber);
        //    command.Parameters.AddWithValue("@CreditLimit", cc.CreditLimit);
        //    command.Parameters.AddWithValue("@AccountBalance", cc.AccountBalance);
        //    command.Parameters.AddWithValue("@Name", matilda.Name);
          
        //    return (DB.DoUpdateUsingCmdObj(command) > 0) ? true : false;

        //}

       
    }
}
