using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine060Map : EntityTypeConfiguration<OrderLine060>
    {
        public OrderLine060Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine060ID);

            // Properties
            this.Property(t => t.Item060ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine060");
            this.Property(t => t.OrderLine060ID).HasColumnName("OrderLine060ID");
            this.Property(t => t.Order060ID).HasColumnName("Order060ID");
            this.Property(t => t.Item060ID).HasColumnName("Item060ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item060)
                .WithMany(t => t.OrderLine060)
                .HasForeignKey(d => d.Item060ID);
            this.HasRequired(t => t.Order060)
                .WithMany(t => t.OrderLine060)
                .HasForeignKey(d => d.Order060ID);

        }
    }
}
