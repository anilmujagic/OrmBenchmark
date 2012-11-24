using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine044Map : EntityTypeConfiguration<OrderLine044>
    {
        public OrderLine044Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine044ID);

            // Properties
            this.Property(t => t.Item044ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine044");
            this.Property(t => t.OrderLine044ID).HasColumnName("OrderLine044ID");
            this.Property(t => t.Order044ID).HasColumnName("Order044ID");
            this.Property(t => t.Item044ID).HasColumnName("Item044ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item044)
                .WithMany(t => t.OrderLine044)
                .HasForeignKey(d => d.Item044ID);
            this.HasRequired(t => t.Order044)
                .WithMany(t => t.OrderLine044)
                .HasForeignKey(d => d.Order044ID);

        }
    }
}
