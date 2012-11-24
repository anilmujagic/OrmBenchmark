using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine040Map : EntityTypeConfiguration<OrderLine040>
    {
        public OrderLine040Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine040ID);

            // Properties
            this.Property(t => t.Item040ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine040");
            this.Property(t => t.OrderLine040ID).HasColumnName("OrderLine040ID");
            this.Property(t => t.Order040ID).HasColumnName("Order040ID");
            this.Property(t => t.Item040ID).HasColumnName("Item040ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item040)
                .WithMany(t => t.OrderLine040)
                .HasForeignKey(d => d.Item040ID);
            this.HasRequired(t => t.Order040)
                .WithMany(t => t.OrderLine040)
                .HasForeignKey(d => d.Order040ID);

        }
    }
}
