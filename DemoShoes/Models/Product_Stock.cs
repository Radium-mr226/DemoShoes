namespace DemoShoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product_Stock
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Product { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal Size { get; set; }

        public int Quantity { get; set; }

        public virtual Products Products { get; set; }
    }
}
