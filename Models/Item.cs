using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_Cart_Shop_Task.Models
{
    public class Item
    {
        public ProductDetail Product { get; set; }
        public int Quantity { get; set; }

    }
}