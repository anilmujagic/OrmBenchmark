using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine017Map : EntityTypeConfiguration<OrderLine017>
    {
        public OrderLine017Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine017ID);

            // Properties
            this.Property(t => t.Item017ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine017");
            this.Property(t => t.OrderLine017ID).HasColumnName("OrderLine017ID");
            this.Property(t => t.Order017ID).HasColumnName("Order017ID");
            this.Property(t => t.Item017ID).HasColumnName("Item017ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item017)
                .WithMany(t => t.OrderLine017)
                .HasForeignKey(d => d.Item017ID);
            this.HasRequired(t => t.Order017)
                .WithMany(t => t.OrderLine017)
                .HasForeignKey(d => d.Order017ID);

        }
    }
}
