using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine097Map : EntityTypeConfiguration<OrderLine097>
    {
        public OrderLine097Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine097ID);

            // Properties
            this.Property(t => t.Item097ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine097");
            this.Property(t => t.OrderLine097ID).HasColumnName("OrderLine097ID");
            this.Property(t => t.Order097ID).HasColumnName("Order097ID");
            this.Property(t => t.Item097ID).HasColumnName("Item097ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item097)
                .WithMany(t => t.OrderLine097)
                .HasForeignKey(d => d.Item097ID);
            this.HasRequired(t => t.Order097)
                .WithMany(t => t.OrderLine097)
                .HasForeignKey(d => d.Order097ID);

        }
    }
}
