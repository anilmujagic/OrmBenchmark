using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine010Map : EntityTypeConfiguration<OrderLine010>
    {
        public OrderLine010Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine010ID);

            // Properties
            this.Property(t => t.Item010ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine010");
            this.Property(t => t.OrderLine010ID).HasColumnName("OrderLine010ID");
            this.Property(t => t.Order010ID).HasColumnName("Order010ID");
            this.Property(t => t.Item010ID).HasColumnName("Item010ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item010)
                .WithMany(t => t.OrderLine010)
                .HasForeignKey(d => d.Item010ID);
            this.HasRequired(t => t.Order010)
                .WithMany(t => t.OrderLine010)
                .HasForeignKey(d => d.Order010ID);

        }
    }
}
