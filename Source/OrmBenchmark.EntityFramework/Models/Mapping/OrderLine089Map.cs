using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine089Map : EntityTypeConfiguration<OrderLine089>
    {
        public OrderLine089Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine089ID);

            // Properties
            this.Property(t => t.Item089ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine089");
            this.Property(t => t.OrderLine089ID).HasColumnName("OrderLine089ID");
            this.Property(t => t.Order089ID).HasColumnName("Order089ID");
            this.Property(t => t.Item089ID).HasColumnName("Item089ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item089)
                .WithMany(t => t.OrderLine089)
                .HasForeignKey(d => d.Item089ID);
            this.HasRequired(t => t.Order089)
                .WithMany(t => t.OrderLine089)
                .HasForeignKey(d => d.Order089ID);

        }
    }
}
