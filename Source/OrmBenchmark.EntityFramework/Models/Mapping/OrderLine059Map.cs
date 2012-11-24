using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine059Map : EntityTypeConfiguration<OrderLine059>
    {
        public OrderLine059Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine059ID);

            // Properties
            this.Property(t => t.Item059ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine059");
            this.Property(t => t.OrderLine059ID).HasColumnName("OrderLine059ID");
            this.Property(t => t.Order059ID).HasColumnName("Order059ID");
            this.Property(t => t.Item059ID).HasColumnName("Item059ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item059)
                .WithMany(t => t.OrderLine059)
                .HasForeignKey(d => d.Item059ID);
            this.HasRequired(t => t.Order059)
                .WithMany(t => t.OrderLine059)
                .HasForeignKey(d => d.Order059ID);

        }
    }
}
