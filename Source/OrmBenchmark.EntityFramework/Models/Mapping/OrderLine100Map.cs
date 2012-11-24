using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine100Map : EntityTypeConfiguration<OrderLine100>
    {
        public OrderLine100Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine100ID);

            // Properties
            this.Property(t => t.Item100ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine100");
            this.Property(t => t.OrderLine100ID).HasColumnName("OrderLine100ID");
            this.Property(t => t.Order100ID).HasColumnName("Order100ID");
            this.Property(t => t.Item100ID).HasColumnName("Item100ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item100)
                .WithMany(t => t.OrderLine100)
                .HasForeignKey(d => d.Item100ID);
            this.HasRequired(t => t.Order100)
                .WithMany(t => t.OrderLine100)
                .HasForeignKey(d => d.Order100ID);

        }
    }
}
