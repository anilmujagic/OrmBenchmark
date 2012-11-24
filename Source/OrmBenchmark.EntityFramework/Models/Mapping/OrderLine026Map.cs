using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine026Map : EntityTypeConfiguration<OrderLine026>
    {
        public OrderLine026Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine026ID);

            // Properties
            this.Property(t => t.Item026ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine026");
            this.Property(t => t.OrderLine026ID).HasColumnName("OrderLine026ID");
            this.Property(t => t.Order026ID).HasColumnName("Order026ID");
            this.Property(t => t.Item026ID).HasColumnName("Item026ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item026)
                .WithMany(t => t.OrderLine026)
                .HasForeignKey(d => d.Item026ID);
            this.HasRequired(t => t.Order026)
                .WithMany(t => t.OrderLine026)
                .HasForeignKey(d => d.Order026ID);

        }
    }
}
