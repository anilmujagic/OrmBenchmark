using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine084Map : EntityTypeConfiguration<OrderLine084>
    {
        public OrderLine084Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine084ID);

            // Properties
            this.Property(t => t.Item084ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine084");
            this.Property(t => t.OrderLine084ID).HasColumnName("OrderLine084ID");
            this.Property(t => t.Order084ID).HasColumnName("Order084ID");
            this.Property(t => t.Item084ID).HasColumnName("Item084ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item084)
                .WithMany(t => t.OrderLine084)
                .HasForeignKey(d => d.Item084ID);
            this.HasRequired(t => t.Order084)
                .WithMany(t => t.OrderLine084)
                .HasForeignKey(d => d.Order084ID);

        }
    }
}
