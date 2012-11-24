using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine024Map : EntityTypeConfiguration<OrderLine024>
    {
        public OrderLine024Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine024ID);

            // Properties
            this.Property(t => t.Item024ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine024");
            this.Property(t => t.OrderLine024ID).HasColumnName("OrderLine024ID");
            this.Property(t => t.Order024ID).HasColumnName("Order024ID");
            this.Property(t => t.Item024ID).HasColumnName("Item024ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item024)
                .WithMany(t => t.OrderLine024)
                .HasForeignKey(d => d.Item024ID);
            this.HasRequired(t => t.Order024)
                .WithMany(t => t.OrderLine024)
                .HasForeignKey(d => d.Order024ID);

        }
    }
}
