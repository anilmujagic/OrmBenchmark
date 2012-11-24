using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine048Map : EntityTypeConfiguration<OrderLine048>
    {
        public OrderLine048Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine048ID);

            // Properties
            this.Property(t => t.Item048ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine048");
            this.Property(t => t.OrderLine048ID).HasColumnName("OrderLine048ID");
            this.Property(t => t.Order048ID).HasColumnName("Order048ID");
            this.Property(t => t.Item048ID).HasColumnName("Item048ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item048)
                .WithMany(t => t.OrderLine048)
                .HasForeignKey(d => d.Item048ID);
            this.HasRequired(t => t.Order048)
                .WithMany(t => t.OrderLine048)
                .HasForeignKey(d => d.Order048ID);

        }
    }
}
