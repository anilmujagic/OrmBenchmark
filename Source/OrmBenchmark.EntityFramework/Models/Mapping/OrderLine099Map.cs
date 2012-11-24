using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine099Map : EntityTypeConfiguration<OrderLine099>
    {
        public OrderLine099Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine099ID);

            // Properties
            this.Property(t => t.Item099ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine099");
            this.Property(t => t.OrderLine099ID).HasColumnName("OrderLine099ID");
            this.Property(t => t.Order099ID).HasColumnName("Order099ID");
            this.Property(t => t.Item099ID).HasColumnName("Item099ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item099)
                .WithMany(t => t.OrderLine099)
                .HasForeignKey(d => d.Item099ID);
            this.HasRequired(t => t.Order099)
                .WithMany(t => t.OrderLine099)
                .HasForeignKey(d => d.Order099ID);

        }
    }
}
