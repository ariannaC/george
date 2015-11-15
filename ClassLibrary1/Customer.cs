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
        public string name;
        public string email;
        public string password;

        //Shipping Addresss Variables
        public string shippingAddress;
        public string shippingCity;
        public string shippingState;
        private int shippingZipcode;
        public string shippingCountry;

        //Billing Address Variables
        public string billingAddress;
        public string billingCity;
        public string billingState;
        public string billingZipcode;
        public string billingCountry;

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

        public string ShippingAddress
        {
            get{return shippingAddress;}
            set { shippingAddress = value; }
        }

        public string ShippingCity
        {
            get { return shippingCity; }
            set { shippingCity = value; }
        }


    }//end of class


}//end of namespace
