using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine079Map : EntityTypeConfiguration<OrderLine079>
    {
        public OrderLine079Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine079ID);

            // Properties
            this.Property(t => t.Item079ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine079");
            this.Property(t => t.OrderLine079ID).HasColumnName("OrderLine079ID");
            this.Property(t => t.Order079ID).HasColumnName("Order079ID");
            this.Property(t => t.Item079ID).HasColumnName("Item079ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item079)
                .WithMany(t => t.OrderLine079)
                .HasForeignKey(d => d.Item079ID);
            this.HasRequired(t => t.Order079)
                .WithMany(t => t.OrderLine079)
                .HasForeignKey(d => d.Order079ID);

        }
    }
}
