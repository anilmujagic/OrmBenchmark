using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine092Map : EntityTypeConfiguration<OrderLine092>
    {
        public OrderLine092Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine092ID);

            // Properties
            this.Property(t => t.Item092ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine092");
            this.Property(t => t.OrderLine092ID).HasColumnName("OrderLine092ID");
            this.Property(t => t.Order092ID).HasColumnName("Order092ID");
            this.Property(t => t.Item092ID).HasColumnName("Item092ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item092)
                .WithMany(t => t.OrderLine092)
                .HasForeignKey(d => d.Item092ID);
            this.HasRequired(t => t.Order092)
                .WithMany(t => t.OrderLine092)
                .HasForeignKey(d => d.Order092ID);

        }
    }
}
