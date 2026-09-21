namespace DemoShoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            Order_Items = new HashSet<Order_Items>();
            Product_Size_Range = new HashSet<Product_Size_Range>();
            Product_Stock = new HashSet<Product_Stock>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Product { get; set; }

        public int Id_Category { get; set; }

        public int Id_Subcategory { get; set; }

        public int Id_Factory { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        [Required]
        [StringLength(255)]
        public string Product_Name { get; set; }

        public string Description { get; set; }

        public string Composition { get; set; }

        public decimal Price { get; set; }

        public virtual Categories Categories { get; set; }

        public virtual Factories Factories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Items> Order_Items { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Size_Range> Product_Size_Range { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Stock> Product_Stock { get; set; }

        public virtual Subcategories Subcategories { get; set; }
    }
}
