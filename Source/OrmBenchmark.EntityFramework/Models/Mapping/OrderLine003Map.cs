using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine003Map : EntityTypeConfiguration<OrderLine003>
    {
        public OrderLine003Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine003ID);

            // Properties
            this.Property(t => t.Item003ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine003");
            this.Property(t => t.OrderLine003ID).HasColumnName("OrderLine003ID");
            this.Property(t => t.Order003ID).HasColumnName("Order003ID");
            this.Property(t => t.Item003ID).HasColumnName("Item003ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item003)
                .WithMany(t => t.OrderLine003)
                .HasForeignKey(d => d.Item003ID);
            this.HasRequired(t => t.Order003)
                .WithMany(t => t.OrderLine003)
                .HasForeignKey(d => d.Order003ID);

        }
    }
}
