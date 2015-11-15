using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Amazon_ClassLibrary
{
    public class Product
    {
        public string ProductID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityOnHand { get; set; }
        public int DepartmentNumber { get; set; }
        public string URL { get; set; }

    }
}
