using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine075Map : EntityTypeConfiguration<OrderLine075>
    {
        public OrderLine075Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine075ID);

            // Properties
            this.Property(t => t.Item075ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine075");
            this.Property(t => t.OrderLine075ID).HasColumnName("OrderLine075ID");
            this.Property(t => t.Order075ID).HasColumnName("Order075ID");
            this.Property(t => t.Item075ID).HasColumnName("Item075ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item075)
                .WithMany(t => t.OrderLine075)
                .HasForeignKey(d => d.Item075ID);
            this.HasRequired(t => t.Order075)
                .WithMany(t => t.OrderLine075)
                .HasForeignKey(d => d.Order075ID);

        }
    }
}
