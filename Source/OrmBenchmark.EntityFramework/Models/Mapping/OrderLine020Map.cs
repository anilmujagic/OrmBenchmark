using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine020Map : EntityTypeConfiguration<OrderLine020>
    {
        public OrderLine020Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine020ID);

            // Properties
            this.Property(t => t.Item020ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine020");
            this.Property(t => t.OrderLine020ID).HasColumnName("OrderLine020ID");
            this.Property(t => t.Order020ID).HasColumnName("Order020ID");
            this.Property(t => t.Item020ID).HasColumnName("Item020ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item020)
                .WithMany(t => t.OrderLine020)
                .HasForeignKey(d => d.Item020ID);
            this.HasRequired(t => t.Order020)
                .WithMany(t => t.OrderLine020)
                .HasForeignKey(d => d.Order020ID);

        }
    }
}
