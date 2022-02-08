namespace Product_Cart_Shop_Task.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Serializable]
    public partial class ProductDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        [Required]
        [StringLength(10)]
        public string ProductName { get; set; }

        public int ProductPrice { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
