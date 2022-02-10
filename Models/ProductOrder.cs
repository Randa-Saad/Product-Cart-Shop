using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_Cart_Shop_Task.Models
{
    public partial class ProductOrder
    {
        public int ProductID { get; set; }
        public int ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
    }
}