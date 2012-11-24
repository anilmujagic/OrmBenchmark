using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLineMap : EntityTypeConfiguration<OrderLine>
    {
        public OrderLineMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderLineID);

            // Properties
            this.Property(t => t.ItemID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine");
            this.Property(t => t.OrderLineID).HasColumnName("OrderLineID");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item)
                .WithMany(t => t.OrderLines)
                .HasForeignKey(d => d.ItemID);
            this.HasRequired(t => t.Order)
                .WithMany(t => t.OrderLines)
                .HasForeignKey(d => d.OrderID);

        }
    }
}
