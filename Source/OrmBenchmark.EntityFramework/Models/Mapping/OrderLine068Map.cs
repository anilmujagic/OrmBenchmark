using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine068Map : EntityTypeConfiguration<OrderLine068>
    {
        public OrderLine068Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine068ID);

            // Properties
            this.Property(t => t.Item068ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine068");
            this.Property(t => t.OrderLine068ID).HasColumnName("OrderLine068ID");
            this.Property(t => t.Order068ID).HasColumnName("Order068ID");
            this.Property(t => t.Item068ID).HasColumnName("Item068ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item068)
                .WithMany(t => t.OrderLine068)
                .HasForeignKey(d => d.Item068ID);
            this.HasRequired(t => t.Order068)
                .WithMany(t => t.OrderLine068)
                .HasForeignKey(d => d.Order068ID);

        }
    }
}
