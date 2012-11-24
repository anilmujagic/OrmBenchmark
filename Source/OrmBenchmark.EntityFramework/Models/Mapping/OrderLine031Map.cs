using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine031Map : EntityTypeConfiguration<OrderLine031>
    {
        public OrderLine031Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine031ID);

            // Properties
            this.Property(t => t.Item031ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine031");
            this.Property(t => t.OrderLine031ID).HasColumnName("OrderLine031ID");
            this.Property(t => t.Order031ID).HasColumnName("Order031ID");
            this.Property(t => t.Item031ID).HasColumnName("Item031ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item031)
                .WithMany(t => t.OrderLine031)
                .HasForeignKey(d => d.Item031ID);
            this.HasRequired(t => t.Order031)
                .WithMany(t => t.OrderLine031)
                .HasForeignKey(d => d.Order031ID);

        }
    }
}
