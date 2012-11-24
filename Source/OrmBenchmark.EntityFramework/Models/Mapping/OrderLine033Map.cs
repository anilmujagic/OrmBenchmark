using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine033Map : EntityTypeConfiguration<OrderLine033>
    {
        public OrderLine033Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine033ID);

            // Properties
            this.Property(t => t.Item033ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine033");
            this.Property(t => t.OrderLine033ID).HasColumnName("OrderLine033ID");
            this.Property(t => t.Order033ID).HasColumnName("Order033ID");
            this.Property(t => t.Item033ID).HasColumnName("Item033ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item033)
                .WithMany(t => t.OrderLine033)
                .HasForeignKey(d => d.Item033ID);
            this.HasRequired(t => t.Order033)
                .WithMany(t => t.OrderLine033)
                .HasForeignKey(d => d.Order033ID);

        }
    }
}
