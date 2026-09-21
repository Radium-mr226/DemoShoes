namespace DemoShoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_User { get; set; }

        [Required]
        [StringLength(100)]
        public string Last_Name { get; set; }

        [Required]
        [StringLength(100)]
        public string First_Name { get; set; }

        [StringLength(100)]
        public string Middle_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        public int Id_Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        public virtual Roles Roles { get; set; }
    }
}
