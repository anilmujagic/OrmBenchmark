using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine002Map : EntityTypeConfiguration<OrderLine002>
    {
        public OrderLine002Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine002ID);

            // Properties
            this.Property(t => t.Item002ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine002");
            this.Property(t => t.OrderLine002ID).HasColumnName("OrderLine002ID");
            this.Property(t => t.Order002ID).HasColumnName("Order002ID");
            this.Property(t => t.Item002ID).HasColumnName("Item002ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item002)
                .WithMany(t => t.OrderLine002)
                .HasForeignKey(d => d.Item002ID);
            this.HasRequired(t => t.Order002)
                .WithMany(t => t.OrderLine002)
                .HasForeignKey(d => d.Order002ID);

        }
    }
}
