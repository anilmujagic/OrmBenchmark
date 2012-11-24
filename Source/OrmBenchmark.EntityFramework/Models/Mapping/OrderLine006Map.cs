using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine006Map : EntityTypeConfiguration<OrderLine006>
    {
        public OrderLine006Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine006ID);

            // Properties
            this.Property(t => t.Item006ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine006");
            this.Property(t => t.OrderLine006ID).HasColumnName("OrderLine006ID");
            this.Property(t => t.Order006ID).HasColumnName("Order006ID");
            this.Property(t => t.Item006ID).HasColumnName("Item006ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item006)
                .WithMany(t => t.OrderLine006)
                .HasForeignKey(d => d.Item006ID);
            this.HasRequired(t => t.Order006)
                .WithMany(t => t.OrderLine006)
                .HasForeignKey(d => d.Order006ID);

        }
    }
}
