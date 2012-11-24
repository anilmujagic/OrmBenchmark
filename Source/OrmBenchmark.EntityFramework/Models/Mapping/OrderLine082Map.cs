using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine082Map : EntityTypeConfiguration<OrderLine082>
    {
        public OrderLine082Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine082ID);

            // Properties
            this.Property(t => t.Item082ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine082");
            this.Property(t => t.OrderLine082ID).HasColumnName("OrderLine082ID");
            this.Property(t => t.Order082ID).HasColumnName("Order082ID");
            this.Property(t => t.Item082ID).HasColumnName("Item082ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item082)
                .WithMany(t => t.OrderLine082)
                .HasForeignKey(d => d.Item082ID);
            this.HasRequired(t => t.Order082)
                .WithMany(t => t.OrderLine082)
                .HasForeignKey(d => d.Order082ID);

        }
    }
}
