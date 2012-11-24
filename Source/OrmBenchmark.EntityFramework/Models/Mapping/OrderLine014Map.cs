using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine014Map : EntityTypeConfiguration<OrderLine014>
    {
        public OrderLine014Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine014ID);

            // Properties
            this.Property(t => t.Item014ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine014");
            this.Property(t => t.OrderLine014ID).HasColumnName("OrderLine014ID");
            this.Property(t => t.Order014ID).HasColumnName("Order014ID");
            this.Property(t => t.Item014ID).HasColumnName("Item014ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item014)
                .WithMany(t => t.OrderLine014)
                .HasForeignKey(d => d.Item014ID);
            this.HasRequired(t => t.Order014)
                .WithMany(t => t.OrderLine014)
                .HasForeignKey(d => d.Order014ID);

        }
    }
}
