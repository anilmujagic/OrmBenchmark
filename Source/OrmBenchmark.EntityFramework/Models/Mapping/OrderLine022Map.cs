using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine022Map : EntityTypeConfiguration<OrderLine022>
    {
        public OrderLine022Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine022ID);

            // Properties
            this.Property(t => t.Item022ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine022");
            this.Property(t => t.OrderLine022ID).HasColumnName("OrderLine022ID");
            this.Property(t => t.Order022ID).HasColumnName("Order022ID");
            this.Property(t => t.Item022ID).HasColumnName("Item022ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item022)
                .WithMany(t => t.OrderLine022)
                .HasForeignKey(d => d.Item022ID);
            this.HasRequired(t => t.Order022)
                .WithMany(t => t.OrderLine022)
                .HasForeignKey(d => d.Order022ID);

        }
    }
}
