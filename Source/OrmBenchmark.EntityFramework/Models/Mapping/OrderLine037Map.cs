using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine037Map : EntityTypeConfiguration<OrderLine037>
    {
        public OrderLine037Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine037ID);

            // Properties
            this.Property(t => t.Item037ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine037");
            this.Property(t => t.OrderLine037ID).HasColumnName("OrderLine037ID");
            this.Property(t => t.Order037ID).HasColumnName("Order037ID");
            this.Property(t => t.Item037ID).HasColumnName("Item037ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item037)
                .WithMany(t => t.OrderLine037)
                .HasForeignKey(d => d.Item037ID);
            this.HasRequired(t => t.Order037)
                .WithMany(t => t.OrderLine037)
                .HasForeignKey(d => d.Order037ID);

        }
    }
}
