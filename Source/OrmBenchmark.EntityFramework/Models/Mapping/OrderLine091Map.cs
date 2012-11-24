using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine091Map : EntityTypeConfiguration<OrderLine091>
    {
        public OrderLine091Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine091ID);

            // Properties
            this.Property(t => t.Item091ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine091");
            this.Property(t => t.OrderLine091ID).HasColumnName("OrderLine091ID");
            this.Property(t => t.Order091ID).HasColumnName("Order091ID");
            this.Property(t => t.Item091ID).HasColumnName("Item091ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item091)
                .WithMany(t => t.OrderLine091)
                .HasForeignKey(d => d.Item091ID);
            this.HasRequired(t => t.Order091)
                .WithMany(t => t.OrderLine091)
                .HasForeignKey(d => d.Order091ID);

        }
    }
}
