using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine046Map : EntityTypeConfiguration<OrderLine046>
    {
        public OrderLine046Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine046ID);

            // Properties
            this.Property(t => t.Item046ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine046");
            this.Property(t => t.OrderLine046ID).HasColumnName("OrderLine046ID");
            this.Property(t => t.Order046ID).HasColumnName("Order046ID");
            this.Property(t => t.Item046ID).HasColumnName("Item046ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item046)
                .WithMany(t => t.OrderLine046)
                .HasForeignKey(d => d.Item046ID);
            this.HasRequired(t => t.Order046)
                .WithMany(t => t.OrderLine046)
                .HasForeignKey(d => d.Order046ID);

        }
    }
}
