using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DemoShoes.Models
{
    public partial class WounderShoesDB : DbContext
    {
        public WounderShoesDB()
            : base("name=WounderShoesDB")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Factories> Factories { get; set; }
        public virtual DbSet<Order_Items> Order_Items { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product_Size_Range> Product_Size_Range { get; set; }
        public virtual DbSet<Product_Stock> Product_Stock { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Subcategories> Subcategories { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Categories)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Factories>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Factories)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order_Items>()
                .Property(e => e.Size)
                .HasPrecision(4, 1);

            modelBuilder.Entity<Order_Items>()
                .Property(e => e.Unit_Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.Order_Items)
                .WithRequired(e => e.Orders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product_Size_Range>()
                .Property(e => e.Size)
                .HasPrecision(4, 1);

            modelBuilder.Entity<Product_Stock>()
                .Property(e => e.Size)
                .HasPrecision(4, 1);

            modelBuilder.Entity<Products>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Order_Items)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Product_Size_Range)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Product_Stock)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Roles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subcategories>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Subcategories)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);
        }
    }
}
