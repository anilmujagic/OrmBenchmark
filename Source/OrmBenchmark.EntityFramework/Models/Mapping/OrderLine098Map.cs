using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine098Map : EntityTypeConfiguration<OrderLine098>
    {
        public OrderLine098Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine098ID);

            // Properties
            this.Property(t => t.Item098ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine098");
            this.Property(t => t.OrderLine098ID).HasColumnName("OrderLine098ID");
            this.Property(t => t.Order098ID).HasColumnName("Order098ID");
            this.Property(t => t.Item098ID).HasColumnName("Item098ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item098)
                .WithMany(t => t.OrderLine098)
                .HasForeignKey(d => d.Item098ID);
            this.HasRequired(t => t.Order098)
                .WithMany(t => t.OrderLine098)
                .HasForeignKey(d => d.Order098ID);

        }
    }
}
