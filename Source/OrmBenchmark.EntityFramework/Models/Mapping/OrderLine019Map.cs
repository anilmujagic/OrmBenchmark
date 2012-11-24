using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine019Map : EntityTypeConfiguration<OrderLine019>
    {
        public OrderLine019Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine019ID);

            // Properties
            this.Property(t => t.Item019ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine019");
            this.Property(t => t.OrderLine019ID).HasColumnName("OrderLine019ID");
            this.Property(t => t.Order019ID).HasColumnName("Order019ID");
            this.Property(t => t.Item019ID).HasColumnName("Item019ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item019)
                .WithMany(t => t.OrderLine019)
                .HasForeignKey(d => d.Item019ID);
            this.HasRequired(t => t.Order019)
                .WithMany(t => t.OrderLine019)
                .HasForeignKey(d => d.Order019ID);

        }
    }
}
