using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Amazon_ClassLibrary
{
    public class Cart
    {
            //internal list of items and constructor which instantiates it
            private List<CartItem> cartItems;
            public Cart()
            {
                cartItems = new List<CartItem>();
            }

            //readonly property that returns the number of items in internal list
            public int Count
            {
                get { return cartItems.Count; }
            }

            //indexers - locate items in internal list by index or product id
            public CartItem this[int index]
            {
                get { return cartItems[index]; }
                set { cartItems[index] = value; }
            }
            public CartItem this[string id]
            {
                get
                {
                    return cartItems.FirstOrDefault(c => c.Product.ProductID == id);
                }
            }

            public void AddItem(CartItem Item)
            {
                cartItems.Add(Item);
                
            }

            
        








    }//end of Cart class






}//end of namespace
