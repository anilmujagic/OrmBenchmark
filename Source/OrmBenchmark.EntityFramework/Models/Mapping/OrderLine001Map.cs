using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine001Map : EntityTypeConfiguration<OrderLine001>
    {
        public OrderLine001Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine001ID);

            // Properties
            this.Property(t => t.Item001ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine001");
            this.Property(t => t.OrderLine001ID).HasColumnName("OrderLine001ID");
            this.Property(t => t.Order001ID).HasColumnName("Order001ID");
            this.Property(t => t.Item001ID).HasColumnName("Item001ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item001)
                .WithMany(t => t.OrderLine001)
                .HasForeignKey(d => d.Item001ID);
            this.HasRequired(t => t.Order001)
                .WithMany(t => t.OrderLine001)
                .HasForeignKey(d => d.Order001ID);

        }
    }
}
