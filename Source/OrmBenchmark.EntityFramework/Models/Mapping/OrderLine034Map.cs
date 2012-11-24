using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine034Map : EntityTypeConfiguration<OrderLine034>
    {
        public OrderLine034Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine034ID);

            // Properties
            this.Property(t => t.Item034ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine034");
            this.Property(t => t.OrderLine034ID).HasColumnName("OrderLine034ID");
            this.Property(t => t.Order034ID).HasColumnName("Order034ID");
            this.Property(t => t.Item034ID).HasColumnName("Item034ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item034)
                .WithMany(t => t.OrderLine034)
                .HasForeignKey(d => d.Item034ID);
            this.HasRequired(t => t.Order034)
                .WithMany(t => t.OrderLine034)
                .HasForeignKey(d => d.Order034ID);

        }
    }
}
