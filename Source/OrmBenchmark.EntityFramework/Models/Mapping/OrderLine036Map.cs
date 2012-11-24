using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine036Map : EntityTypeConfiguration<OrderLine036>
    {
        public OrderLine036Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine036ID);

            // Properties
            this.Property(t => t.Item036ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine036");
            this.Property(t => t.OrderLine036ID).HasColumnName("OrderLine036ID");
            this.Property(t => t.Order036ID).HasColumnName("Order036ID");
            this.Property(t => t.Item036ID).HasColumnName("Item036ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item036)
                .WithMany(t => t.OrderLine036)
                .HasForeignKey(d => d.Item036ID);
            this.HasRequired(t => t.Order036)
                .WithMany(t => t.OrderLine036)
                .HasForeignKey(d => d.Order036ID);

        }
    }
}
