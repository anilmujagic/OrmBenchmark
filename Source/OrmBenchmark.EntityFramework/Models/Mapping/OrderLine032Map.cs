using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine032Map : EntityTypeConfiguration<OrderLine032>
    {
        public OrderLine032Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine032ID);

            // Properties
            this.Property(t => t.Item032ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine032");
            this.Property(t => t.OrderLine032ID).HasColumnName("OrderLine032ID");
            this.Property(t => t.Order032ID).HasColumnName("Order032ID");
            this.Property(t => t.Item032ID).HasColumnName("Item032ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item032)
                .WithMany(t => t.OrderLine032)
                .HasForeignKey(d => d.Item032ID);
            this.HasRequired(t => t.Order032)
                .WithMany(t => t.OrderLine032)
                .HasForeignKey(d => d.Order032ID);

        }
    }
}
