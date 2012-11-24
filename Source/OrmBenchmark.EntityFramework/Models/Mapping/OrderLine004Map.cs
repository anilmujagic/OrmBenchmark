using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine004Map : EntityTypeConfiguration<OrderLine004>
    {
        public OrderLine004Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine004ID);

            // Properties
            this.Property(t => t.Item004ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine004");
            this.Property(t => t.OrderLine004ID).HasColumnName("OrderLine004ID");
            this.Property(t => t.Order004ID).HasColumnName("Order004ID");
            this.Property(t => t.Item004ID).HasColumnName("Item004ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item004)
                .WithMany(t => t.OrderLine004)
                .HasForeignKey(d => d.Item004ID);
            this.HasRequired(t => t.Order004)
                .WithMany(t => t.OrderLine004)
                .HasForeignKey(d => d.Order004ID);

        }
    }
}
