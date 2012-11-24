using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine088Map : EntityTypeConfiguration<OrderLine088>
    {
        public OrderLine088Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine088ID);

            // Properties
            this.Property(t => t.Item088ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine088");
            this.Property(t => t.OrderLine088ID).HasColumnName("OrderLine088ID");
            this.Property(t => t.Order088ID).HasColumnName("Order088ID");
            this.Property(t => t.Item088ID).HasColumnName("Item088ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item088)
                .WithMany(t => t.OrderLine088)
                .HasForeignKey(d => d.Item088ID);
            this.HasRequired(t => t.Order088)
                .WithMany(t => t.OrderLine088)
                .HasForeignKey(d => d.Order088ID);

        }
    }
}
