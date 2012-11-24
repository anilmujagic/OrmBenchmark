using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine030Map : EntityTypeConfiguration<OrderLine030>
    {
        public OrderLine030Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine030ID);

            // Properties
            this.Property(t => t.Item030ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine030");
            this.Property(t => t.OrderLine030ID).HasColumnName("OrderLine030ID");
            this.Property(t => t.Order030ID).HasColumnName("Order030ID");
            this.Property(t => t.Item030ID).HasColumnName("Item030ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item030)
                .WithMany(t => t.OrderLine030)
                .HasForeignKey(d => d.Item030ID);
            this.HasRequired(t => t.Order030)
                .WithMany(t => t.OrderLine030)
                .HasForeignKey(d => d.Order030ID);

        }
    }
}
