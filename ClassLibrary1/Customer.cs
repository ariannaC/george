using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Amazon_ClassLibrary
{
    public class Customer
    {
        //Personal Customer Variables 
        private string name;
        private string email;
        private string password;

        //Shipping Addresss Variables
        private string shippingAddress;
        private string shippingCity;
        private string shippingState;
        private int shippingZipcode;
        private string shippingCountry;

        //Billing Address Variables
        private string billingAddress;
        private string billingCity;
        private string billingState;
        private string billingZipcode;
        private string billingCountry;

        //Constructor
        public Customer()
        {
        }


        //Getters and Setters 
        public string Name
        {
            get { return name;} 
            set {name = value;} 
        }

        public string Email 
        { get { return email; } 
          set { email = value; } 
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


    }//end of class


}//end of namespace
