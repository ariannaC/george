﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Amazon_ClassLibrary
{
    public class Merchant
    {
        //Personal Merchant Variables 
        public string groupName;
        public string email;
        public string apikey;
        public string password;
        public string address;
        public string url;

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

        public Merchant()
        { 
        }

    }//end of class


}//end of namespace
