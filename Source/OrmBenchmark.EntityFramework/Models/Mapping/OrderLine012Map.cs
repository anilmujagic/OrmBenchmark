using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine012Map : EntityTypeConfiguration<OrderLine012>
    {
        public OrderLine012Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine012ID);

            // Properties
            this.Property(t => t.Item012ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine012");
            this.Property(t => t.OrderLine012ID).HasColumnName("OrderLine012ID");
            this.Property(t => t.Order012ID).HasColumnName("Order012ID");
            this.Property(t => t.Item012ID).HasColumnName("Item012ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item012)
                .WithMany(t => t.OrderLine012)
                .HasForeignKey(d => d.Item012ID);
            this.HasRequired(t => t.Order012)
                .WithMany(t => t.OrderLine012)
                .HasForeignKey(d => d.Order012ID);

        }
    }
}
