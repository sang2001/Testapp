using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testapp.Model
{
    public class BookModel
    {
        public string BookName { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double Commission { get; set; }
        public double RoyaltyAmount { get; set; }
        public string ShippingAddress { get; set; }
        public string DepartmentOfRoyalty { get; set; }
    }
}
