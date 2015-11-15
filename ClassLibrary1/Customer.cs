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
        public int shippingZipcode;
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
    }//end of class


}//end of namespace
