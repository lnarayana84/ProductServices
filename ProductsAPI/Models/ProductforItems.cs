using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsAPI.Models
{
    public class ProductforItems
    {
        public int productid { get; set; }

        public string productDesc { get; set; }

        public string productName { get; set; }

        public int quantity { get; set; }

        public int unitPrice { get; set; }

        public char Active { get; set;}

        public string Productlocation { get; set; }
    }
}