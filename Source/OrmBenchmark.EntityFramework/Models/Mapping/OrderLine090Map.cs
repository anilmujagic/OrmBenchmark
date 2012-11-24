using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine090Map : EntityTypeConfiguration<OrderLine090>
    {
        public OrderLine090Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine090ID);

            // Properties
            this.Property(t => t.Item090ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine090");
            this.Property(t => t.OrderLine090ID).HasColumnName("OrderLine090ID");
            this.Property(t => t.Order090ID).HasColumnName("Order090ID");
            this.Property(t => t.Item090ID).HasColumnName("Item090ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item090)
                .WithMany(t => t.OrderLine090)
                .HasForeignKey(d => d.Item090ID);
            this.HasRequired(t => t.Order090)
                .WithMany(t => t.OrderLine090)
                .HasForeignKey(d => d.Order090ID);

        }
    }
}
