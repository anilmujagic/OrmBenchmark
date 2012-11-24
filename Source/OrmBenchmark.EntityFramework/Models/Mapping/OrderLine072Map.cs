using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine072Map : EntityTypeConfiguration<OrderLine072>
    {
        public OrderLine072Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine072ID);

            // Properties
            this.Property(t => t.Item072ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine072");
            this.Property(t => t.OrderLine072ID).HasColumnName("OrderLine072ID");
            this.Property(t => t.Order072ID).HasColumnName("Order072ID");
            this.Property(t => t.Item072ID).HasColumnName("Item072ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item072)
                .WithMany(t => t.OrderLine072)
                .HasForeignKey(d => d.Item072ID);
            this.HasRequired(t => t.Order072)
                .WithMany(t => t.OrderLine072)
                .HasForeignKey(d => d.Order072ID);

        }
    }
}
