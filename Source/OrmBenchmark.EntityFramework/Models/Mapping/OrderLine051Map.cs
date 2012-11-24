using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine051Map : EntityTypeConfiguration<OrderLine051>
    {
        public OrderLine051Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine051ID);

            // Properties
            this.Property(t => t.Item051ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine051");
            this.Property(t => t.OrderLine051ID).HasColumnName("OrderLine051ID");
            this.Property(t => t.Order051ID).HasColumnName("Order051ID");
            this.Property(t => t.Item051ID).HasColumnName("Item051ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item051)
                .WithMany(t => t.OrderLine051)
                .HasForeignKey(d => d.Item051ID);
            this.HasRequired(t => t.Order051)
                .WithMany(t => t.OrderLine051)
                .HasForeignKey(d => d.Order051ID);

        }
    }
}
