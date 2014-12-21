namespace Zen.Towes.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TowesEntity : DbContext
    {
        public TowesEntity()
            : base("name=TowesEntity")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<ExpiryDate> ExpiryDates { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductExpiryDate> ProductExpiryDates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasMany(e => e.ExpiryDates)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);
        }
    }
}
