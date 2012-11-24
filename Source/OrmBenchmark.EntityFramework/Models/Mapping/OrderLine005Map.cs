using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine005Map : EntityTypeConfiguration<OrderLine005>
    {
        public OrderLine005Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine005ID);

            // Properties
            this.Property(t => t.Item005ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine005");
            this.Property(t => t.OrderLine005ID).HasColumnName("OrderLine005ID");
            this.Property(t => t.Order005ID).HasColumnName("Order005ID");
            this.Property(t => t.Item005ID).HasColumnName("Item005ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item005)
                .WithMany(t => t.OrderLine005)
                .HasForeignKey(d => d.Item005ID);
            this.HasRequired(t => t.Order005)
                .WithMany(t => t.OrderLine005)
                .HasForeignKey(d => d.Order005ID);

        }
    }
}
