using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine038Map : EntityTypeConfiguration<OrderLine038>
    {
        public OrderLine038Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine038ID);

            // Properties
            this.Property(t => t.Item038ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine038");
            this.Property(t => t.OrderLine038ID).HasColumnName("OrderLine038ID");
            this.Property(t => t.Order038ID).HasColumnName("Order038ID");
            this.Property(t => t.Item038ID).HasColumnName("Item038ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item038)
                .WithMany(t => t.OrderLine038)
                .HasForeignKey(d => d.Item038ID);
            this.HasRequired(t => t.Order038)
                .WithMany(t => t.OrderLine038)
                .HasForeignKey(d => d.Order038ID);

        }
    }
}
