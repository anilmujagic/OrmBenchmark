using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine076Map : EntityTypeConfiguration<OrderLine076>
    {
        public OrderLine076Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine076ID);

            // Properties
            this.Property(t => t.Item076ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine076");
            this.Property(t => t.OrderLine076ID).HasColumnName("OrderLine076ID");
            this.Property(t => t.Order076ID).HasColumnName("Order076ID");
            this.Property(t => t.Item076ID).HasColumnName("Item076ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item076)
                .WithMany(t => t.OrderLine076)
                .HasForeignKey(d => d.Item076ID);
            this.HasRequired(t => t.Order076)
                .WithMany(t => t.OrderLine076)
                .HasForeignKey(d => d.Order076ID);

        }
    }
}
