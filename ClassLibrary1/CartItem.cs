using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Amazon_ClassLibrary
{
    public class CartItem
    {
        //create empty object or add values on creation
        public CartItem() { }
        public CartItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

        //public properties
        public Product Product { get; set; }
        public int Quantity { get; set; }

        //add to quantity
        public void AddQuantity(int quantity)
        {
            this.Quantity += quantity;
        }

        //display item's property values
        public string Display()
        {
            string display = string.Format("{0} ({1} at {2} each)",
                Product.Description, Quantity.ToString(),
                Product.Price.ToString("c"));
            return display;
        }



    }
}
