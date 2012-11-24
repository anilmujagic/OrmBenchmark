using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine080Map : EntityTypeConfiguration<OrderLine080>
    {
        public OrderLine080Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine080ID);

            // Properties
            this.Property(t => t.Item080ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine080");
            this.Property(t => t.OrderLine080ID).HasColumnName("OrderLine080ID");
            this.Property(t => t.Order080ID).HasColumnName("Order080ID");
            this.Property(t => t.Item080ID).HasColumnName("Item080ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item080)
                .WithMany(t => t.OrderLine080)
                .HasForeignKey(d => d.Item080ID);
            this.HasRequired(t => t.Order080)
                .WithMany(t => t.OrderLine080)
                .HasForeignKey(d => d.Order080ID);

        }
    }
}
