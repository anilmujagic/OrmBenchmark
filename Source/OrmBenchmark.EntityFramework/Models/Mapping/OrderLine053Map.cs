using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine053Map : EntityTypeConfiguration<OrderLine053>
    {
        public OrderLine053Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine053ID);

            // Properties
            this.Property(t => t.Item053ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine053");
            this.Property(t => t.OrderLine053ID).HasColumnName("OrderLine053ID");
            this.Property(t => t.Order053ID).HasColumnName("Order053ID");
            this.Property(t => t.Item053ID).HasColumnName("Item053ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item053)
                .WithMany(t => t.OrderLine053)
                .HasForeignKey(d => d.Item053ID);
            this.HasRequired(t => t.Order053)
                .WithMany(t => t.OrderLine053)
                .HasForeignKey(d => d.Order053ID);

        }
    }
}
