using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Catalog1.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [DisplayName("Product Name")]
        public string Name { get; set; }

        public int Quantity { get; set; }

        public int OrderMaximumQuantity { get; set; }

        public Decimal Price { get; set; }

        public string Description { get; set; }

        public string ImageSmall { get; set; }

        public string ImageLarge { get; set; }

        public Decimal PriceModifier { get; set; }

        public virtual ICollection<ProductReview> Reviews { get; set; }
    }
}