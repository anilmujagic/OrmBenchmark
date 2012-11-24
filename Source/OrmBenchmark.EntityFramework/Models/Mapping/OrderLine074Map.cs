using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine074Map : EntityTypeConfiguration<OrderLine074>
    {
        public OrderLine074Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine074ID);

            // Properties
            this.Property(t => t.Item074ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine074");
            this.Property(t => t.OrderLine074ID).HasColumnName("OrderLine074ID");
            this.Property(t => t.Order074ID).HasColumnName("Order074ID");
            this.Property(t => t.Item074ID).HasColumnName("Item074ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item074)
                .WithMany(t => t.OrderLine074)
                .HasForeignKey(d => d.Item074ID);
            this.HasRequired(t => t.Order074)
                .WithMany(t => t.OrderLine074)
                .HasForeignKey(d => d.Order074ID);

        }
    }
}
