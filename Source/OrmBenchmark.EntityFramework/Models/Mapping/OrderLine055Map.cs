using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine055Map : EntityTypeConfiguration<OrderLine055>
    {
        public OrderLine055Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine055ID);

            // Properties
            this.Property(t => t.Item055ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine055");
            this.Property(t => t.OrderLine055ID).HasColumnName("OrderLine055ID");
            this.Property(t => t.Order055ID).HasColumnName("Order055ID");
            this.Property(t => t.Item055ID).HasColumnName("Item055ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item055)
                .WithMany(t => t.OrderLine055)
                .HasForeignKey(d => d.Item055ID);
            this.HasRequired(t => t.Order055)
                .WithMany(t => t.OrderLine055)
                .HasForeignKey(d => d.Order055ID);

        }
    }
}
