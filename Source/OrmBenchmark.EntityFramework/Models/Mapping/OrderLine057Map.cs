using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine057Map : EntityTypeConfiguration<OrderLine057>
    {
        public OrderLine057Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine057ID);

            // Properties
            this.Property(t => t.Item057ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine057");
            this.Property(t => t.OrderLine057ID).HasColumnName("OrderLine057ID");
            this.Property(t => t.Order057ID).HasColumnName("Order057ID");
            this.Property(t => t.Item057ID).HasColumnName("Item057ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item057)
                .WithMany(t => t.OrderLine057)
                .HasForeignKey(d => d.Item057ID);
            this.HasRequired(t => t.Order057)
                .WithMany(t => t.OrderLine057)
                .HasForeignKey(d => d.Order057ID);

        }
    }
}
