using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine071Map : EntityTypeConfiguration<OrderLine071>
    {
        public OrderLine071Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine071ID);

            // Properties
            this.Property(t => t.Item071ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine071");
            this.Property(t => t.OrderLine071ID).HasColumnName("OrderLine071ID");
            this.Property(t => t.Order071ID).HasColumnName("Order071ID");
            this.Property(t => t.Item071ID).HasColumnName("Item071ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item071)
                .WithMany(t => t.OrderLine071)
                .HasForeignKey(d => d.Item071ID);
            this.HasRequired(t => t.Order071)
                .WithMany(t => t.OrderLine071)
                .HasForeignKey(d => d.Order071ID);

        }
    }
}
