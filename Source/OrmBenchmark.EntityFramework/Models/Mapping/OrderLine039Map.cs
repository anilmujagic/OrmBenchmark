using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine039Map : EntityTypeConfiguration<OrderLine039>
    {
        public OrderLine039Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine039ID);

            // Properties
            this.Property(t => t.Item039ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine039");
            this.Property(t => t.OrderLine039ID).HasColumnName("OrderLine039ID");
            this.Property(t => t.Order039ID).HasColumnName("Order039ID");
            this.Property(t => t.Item039ID).HasColumnName("Item039ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item039)
                .WithMany(t => t.OrderLine039)
                .HasForeignKey(d => d.Item039ID);
            this.HasRequired(t => t.Order039)
                .WithMany(t => t.OrderLine039)
                .HasForeignKey(d => d.Order039ID);

        }
    }
}
