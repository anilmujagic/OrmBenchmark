using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine025Map : EntityTypeConfiguration<OrderLine025>
    {
        public OrderLine025Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine025ID);

            // Properties
            this.Property(t => t.Item025ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine025");
            this.Property(t => t.OrderLine025ID).HasColumnName("OrderLine025ID");
            this.Property(t => t.Order025ID).HasColumnName("Order025ID");
            this.Property(t => t.Item025ID).HasColumnName("Item025ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item025)
                .WithMany(t => t.OrderLine025)
                .HasForeignKey(d => d.Item025ID);
            this.HasRequired(t => t.Order025)
                .WithMany(t => t.OrderLine025)
                .HasForeignKey(d => d.Order025ID);

        }
    }
}
