using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine058Map : EntityTypeConfiguration<OrderLine058>
    {
        public OrderLine058Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine058ID);

            // Properties
            this.Property(t => t.Item058ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine058");
            this.Property(t => t.OrderLine058ID).HasColumnName("OrderLine058ID");
            this.Property(t => t.Order058ID).HasColumnName("Order058ID");
            this.Property(t => t.Item058ID).HasColumnName("Item058ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item058)
                .WithMany(t => t.OrderLine058)
                .HasForeignKey(d => d.Item058ID);
            this.HasRequired(t => t.Order058)
                .WithMany(t => t.OrderLine058)
                .HasForeignKey(d => d.Order058ID);

        }
    }
}
