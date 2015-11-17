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

        }


        public void loadCreditCards()
        {
            DBConnect objdb = new DBConnect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "GetAllCC";
            DataSet dataset = objdb.GetDataSetUsingCmdObj(sqlCommand);
            gvCreditCards.DataSource = dataset;
            gvCreditCards.DataBind();
        }



        protected void gvCreditCards_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;
            //get accountID value from textbox field
            int accountID = int.Parse(gvCreditCards.Rows[rowIndex].Cells[1].Text);
           // MerchantStore.MerchantStore pxy = new MerchantStore.MerchantStore();
            TPServiceRef.TheWebService pxy = new TPServiceRef.TheWebService();
  
            //string accountNumber = gvAccounts.Rows[rowIndex].Cells[1].Text;

            // Retrieve a reference to the TextBox in the row for the Name
            TextBox TBoxName;
            TBoxName = (TextBox)gvCreditCards.Rows[rowIndex].Cells[2].Controls[0];
            string name = TBoxName.Text;
           // pxy.updateName(name, accountID);

            // Retrieve a reference to the TextBox in the row for the CardNumber
            TextBox TBoxCardNum;
            TBoxCardNum = (TextBox)gvCreditCards.Rows[rowIndex].Cells[3].Controls[0];
            float cardnum = float.Parse(TBoxCardNum.Text);
          //  pxy.updateCardNumber(cardnum, accountID);

            // Retrieve a reference to the TextBox in the row for the expMonth
             TextBox TBoxmonth;
            TBoxmonth = (TextBox)gvCreditCards.Rows[rowIndex].Cells[4].Controls[0];
            int expMonth = int.Parse(TBoxmonth.Text);
            //pxy.UpdateExpMonth(expMonth, accountID);


            // Retrieve a reference to the TextBox in the row for the expYear
            TextBox TBoxYear;
            TBoxYear = (TextBox)gvCreditCards.Rows[rowIndex].Cells[5].Controls[0];
            int expYear = int.Parse(TBoxYear.Text);
           // pxy.UpdateExpYear(expYear, accountID);

            // Retrieve a reference to the TextBox in the row for the CSV
            TextBox TBoxCSV;
            TBoxCSV = (TextBox)gvCreditCards.Rows[rowIndex].Cells[6].Controls[0];
            int csv = int.Parse(TBoxCSV.Text);
           // pxy.UpdateCSV(csv, accountID);

            gvCreditCards.EditIndex = -1;
        
        } 
           // showAccounts();

    

    }//end of class
}//edn of namespace
