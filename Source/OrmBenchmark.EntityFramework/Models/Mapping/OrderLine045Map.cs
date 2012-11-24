using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine045Map : EntityTypeConfiguration<OrderLine045>
    {
        public OrderLine045Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine045ID);

            // Properties
            this.Property(t => t.Item045ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine045");
            this.Property(t => t.OrderLine045ID).HasColumnName("OrderLine045ID");
            this.Property(t => t.Order045ID).HasColumnName("Order045ID");
            this.Property(t => t.Item045ID).HasColumnName("Item045ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item045)
                .WithMany(t => t.OrderLine045)
                .HasForeignKey(d => d.Item045ID);
            this.HasRequired(t => t.Order045)
                .WithMany(t => t.OrderLine045)
                .HasForeignKey(d => d.Order045ID);

        }
    }
}
