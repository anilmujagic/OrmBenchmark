using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine067Map : EntityTypeConfiguration<OrderLine067>
    {
        public OrderLine067Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine067ID);

            // Properties
            this.Property(t => t.Item067ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine067");
            this.Property(t => t.OrderLine067ID).HasColumnName("OrderLine067ID");
            this.Property(t => t.Order067ID).HasColumnName("Order067ID");
            this.Property(t => t.Item067ID).HasColumnName("Item067ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item067)
                .WithMany(t => t.OrderLine067)
                .HasForeignKey(d => d.Item067ID);
            this.HasRequired(t => t.Order067)
                .WithMany(t => t.OrderLine067)
                .HasForeignKey(d => d.Order067ID);

        }
    }
}
