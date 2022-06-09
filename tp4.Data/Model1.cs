using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace tp4.Data
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=NorthwindConnection")
        {
        }

        public virtual DbSet<Order_Details> Order_Details { get; set; }
        public virtual DbSet<Shippers> Shippers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order_Details>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);
        }
    }
}
