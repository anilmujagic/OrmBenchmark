using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine008Map : EntityTypeConfiguration<OrderLine008>
    {
        public OrderLine008Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine008ID);

            // Properties
            this.Property(t => t.Item008ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine008");
            this.Property(t => t.OrderLine008ID).HasColumnName("OrderLine008ID");
            this.Property(t => t.Order008ID).HasColumnName("Order008ID");
            this.Property(t => t.Item008ID).HasColumnName("Item008ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item008)
                .WithMany(t => t.OrderLine008)
                .HasForeignKey(d => d.Item008ID);
            this.HasRequired(t => t.Order008)
                .WithMany(t => t.OrderLine008)
                .HasForeignKey(d => d.Order008ID);

        }
    }
}
