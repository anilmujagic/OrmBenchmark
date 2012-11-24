using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine027Map : EntityTypeConfiguration<OrderLine027>
    {
        public OrderLine027Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine027ID);

            // Properties
            this.Property(t => t.Item027ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine027");
            this.Property(t => t.OrderLine027ID).HasColumnName("OrderLine027ID");
            this.Property(t => t.Order027ID).HasColumnName("Order027ID");
            this.Property(t => t.Item027ID).HasColumnName("Item027ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item027)
                .WithMany(t => t.OrderLine027)
                .HasForeignKey(d => d.Item027ID);
            this.HasRequired(t => t.Order027)
                .WithMany(t => t.OrderLine027)
                .HasForeignKey(d => d.Order027ID);

        }
    }
}
