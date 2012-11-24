using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine042Map : EntityTypeConfiguration<OrderLine042>
    {
        public OrderLine042Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine042ID);

            // Properties
            this.Property(t => t.Item042ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine042");
            this.Property(t => t.OrderLine042ID).HasColumnName("OrderLine042ID");
            this.Property(t => t.Order042ID).HasColumnName("Order042ID");
            this.Property(t => t.Item042ID).HasColumnName("Item042ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item042)
                .WithMany(t => t.OrderLine042)
                .HasForeignKey(d => d.Item042ID);
            this.HasRequired(t => t.Order042)
                .WithMany(t => t.OrderLine042)
                .HasForeignKey(d => d.Order042ID);

        }
    }
}
