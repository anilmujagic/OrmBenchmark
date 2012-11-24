using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine013Map : EntityTypeConfiguration<OrderLine013>
    {
        public OrderLine013Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine013ID);

            // Properties
            this.Property(t => t.Item013ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine013");
            this.Property(t => t.OrderLine013ID).HasColumnName("OrderLine013ID");
            this.Property(t => t.Order013ID).HasColumnName("Order013ID");
            this.Property(t => t.Item013ID).HasColumnName("Item013ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item013)
                .WithMany(t => t.OrderLine013)
                .HasForeignKey(d => d.Item013ID);
            this.HasRequired(t => t.Order013)
                .WithMany(t => t.OrderLine013)
                .HasForeignKey(d => d.Order013ID);

        }
    }
}
