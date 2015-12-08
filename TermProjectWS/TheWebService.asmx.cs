﻿using System;
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
            DepDS.Tables[0].Columns[0].ColumnName = "DepartmentNumber";
            DepDS.Tables[0].Columns[1].ColumnName = "DepartmentName";
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
            ProdDS.Tables[0].Columns[0].ColumnName = "ProductID";
            ProdDS.Tables[0].Columns[1].ColumnName = "Description";
            ProdDS.Tables[0].Columns[2].ColumnName = "Price";
            ProdDS.Tables[0].Columns[3].ColumnName = "QuantityOnHand";
            ProdDS.Tables[0].Columns[4].ColumnName = "DepartmentNumber";
            ProdDS.Tables[0].Columns[5].ColumnName = "URL";

            return ProdDS;

        }

        [WebMethod]
        public Boolean RegisterSite(String SiteID, String GroupName, String APIKey, String email, string Address)
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
            command.Parameters.AddWithValue("@GroupName", GroupName);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Address", Address);
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

        [WebMethod]
        public Boolean Purchase(String ProductID, int Quantity, String APIKey, string[] customercardinfo)
        {
            //copied and pasted code from project3ws and modiefied to work with this project
            //my verify method was super weird and very specific to the previous project
            //however i still use the basic functionality with the verifyinfo stored procedure
            DBConnect db = new DBConnect();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateProduct";
            command.Parameters.AddWithValue("@productID", int.Parse(ProductID.ToString()));
            command.Parameters.AddWithValue("@quantity", Quantity);
            command.Parameters.AddWithValue("@API", APIKey);
            db.DoUpdateUsingCmdObj(command);
            //-------------------------update product-------------------------------------------------

            //-------------------------------update customer--------------------------------------------
            SqlCommand hank = new SqlCommand();
            hank.CommandType = CommandType.StoredProcedure;
            hank.CommandText = "UpdateCustomer";
            hank.Parameters.AddWithValue("@Email", customercardinfo[0]);
            hank.Parameters.AddWithValue("@productID", int.Parse(ProductID.ToString()));
            hank.Parameters.AddWithValue("@Quantity", Quantity);
            hank.Parameters.AddWithValue("@Name", customercardinfo[1]);
            hank.Parameters.AddWithValue("@ShippingAddress", customercardinfo[2]);
            hank.Parameters.AddWithValue("@ShippingCity", customercardinfo[3]);
            hank.Parameters.AddWithValue("@ShippingState", customercardinfo[4]);
            hank.Parameters.AddWithValue("@ShippingCountry", customercardinfo[5]);
            hank.Parameters.AddWithValue("@ShippingZipCode", customercardinfo[6]);
            hank.Parameters.AddWithValue("@BillingAddress", customercardinfo[7]);
            hank.Parameters.AddWithValue("@BillingCity", customercardinfo[8]);
            hank.Parameters.AddWithValue("@BillingState", customercardinfo[9]);
            hank.Parameters.AddWithValue("@BillingZip", customercardinfo[10]);
         
           // int RETVAL = 0;
           // string tempTest = command.Parameters["@RETVAL"].Value.ToString();
            //RETVAL = int.Parse(tempTest);
           
            //SqlCommand c = new SqlCommand();
            //c.CommandType = CommandType.StoredProcedure;
            //c.CommandText = "TPVerifyInfo";
            //c.Parameters.AddWithValue("@CreditCardNum", customercardinfo[11]);
            //c.Parameters.AddWithValue("@CVV", customercardinfo[12]);
            //db.DoUpdateUsingCmdObj(c);

            if (db.DoUpdateUsingCmdObj(hank) > 0)
            {
                return true;
            }
            return true;
        }

//wtf------------------------------------------------------------------------------
        //[WebMethod]
        //public void updateName(string name, int AccountID)
        //{
        //    DBConnect objdb = new DBConnect();
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.CommandText = "UpdateAccountName";
        //    sqlCommand.Parameters.AddWithValue("@Name", name);
        //    sqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
        //    objdb.DoUpdateUsingCmdObj(sqlCommand);
        //}

        //[WebMethod]
        //public void updateCardNumber(float cardNumber, int AccountID)
        //{
        //    DBConnect objdb = new DBConnect();
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.CommandText = "UpdateCardNumber";
        //    sqlCommand.Parameters.AddWithValue("@CardNumber", cardNumber);
        //    sqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
        //    objdb.DoUpdateUsingCmdObj(sqlCommand);
        //}

        //[WebMethod]
        //public void UpdateExpMonth(int expMonth, int AccountID)
        //{
        //    DBConnect objdb = new DBConnect();
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.CommandText = "UpdateExpMonth";
        //    sqlCommand.Parameters.AddWithValue("@ExpMonth", expMonth);
        //    sqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
        //    objdb.DoUpdateUsingCmdObj(sqlCommand);
        //}

        //[WebMethod]
        //public void UpdateExpYear(int expYear, int AccountID)
        //{
        //    DBConnect objdb = new DBConnect();
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.CommandText = "UpdateExpYear";
        //    sqlCommand.Parameters.AddWithValue("@ExpYear", expYear);
        //    sqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
        //    objdb.DoUpdateUsingCmdObj(sqlCommand);
        //}

        //[WebMethod]
        //public void UpdateCSV(int CSV, int AccountID)
        //{
        //    DBConnect objdb = new DBConnect();
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.CommandText = "UpdateCSV";
        //    sqlCommand.Parameters.AddWithValue("@CSV", CSV);
        //    sqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
        //    objdb.DoUpdateUsingCmdObj(sqlCommand);
        //}




//------------------------------------project3ws stuff---------------------------------------------------------------
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
