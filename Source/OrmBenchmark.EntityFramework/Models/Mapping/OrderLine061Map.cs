using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine061Map : EntityTypeConfiguration<OrderLine061>
    {
        public OrderLine061Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine061ID);

            // Properties
            this.Property(t => t.Item061ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine061");
            this.Property(t => t.OrderLine061ID).HasColumnName("OrderLine061ID");
            this.Property(t => t.Order061ID).HasColumnName("Order061ID");
            this.Property(t => t.Item061ID).HasColumnName("Item061ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item061)
                .WithMany(t => t.OrderLine061)
                .HasForeignKey(d => d.Item061ID);
            this.HasRequired(t => t.Order061)
                .WithMany(t => t.OrderLine061)
                .HasForeignKey(d => d.Order061ID);

        }
    }
}
