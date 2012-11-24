using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine069Map : EntityTypeConfiguration<OrderLine069>
    {
        public OrderLine069Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine069ID);

            // Properties
            this.Property(t => t.Item069ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine069");
            this.Property(t => t.OrderLine069ID).HasColumnName("OrderLine069ID");
            this.Property(t => t.Order069ID).HasColumnName("Order069ID");
            this.Property(t => t.Item069ID).HasColumnName("Item069ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item069)
                .WithMany(t => t.OrderLine069)
                .HasForeignKey(d => d.Item069ID);
            this.HasRequired(t => t.Order069)
                .WithMany(t => t.OrderLine069)
                .HasForeignKey(d => d.Order069ID);

        }
    }
}
