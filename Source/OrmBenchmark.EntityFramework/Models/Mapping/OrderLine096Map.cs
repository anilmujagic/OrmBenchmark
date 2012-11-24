using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine096Map : EntityTypeConfiguration<OrderLine096>
    {
        public OrderLine096Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine096ID);

            // Properties
            this.Property(t => t.Item096ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine096");
            this.Property(t => t.OrderLine096ID).HasColumnName("OrderLine096ID");
            this.Property(t => t.Order096ID).HasColumnName("Order096ID");
            this.Property(t => t.Item096ID).HasColumnName("Item096ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item096)
                .WithMany(t => t.OrderLine096)
                .HasForeignKey(d => d.Item096ID);
            this.HasRequired(t => t.Order096)
                .WithMany(t => t.OrderLine096)
                .HasForeignKey(d => d.Order096ID);

        }
    }
}
