using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine052Map : EntityTypeConfiguration<OrderLine052>
    {
        public OrderLine052Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine052ID);

            // Properties
            this.Property(t => t.Item052ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine052");
            this.Property(t => t.OrderLine052ID).HasColumnName("OrderLine052ID");
            this.Property(t => t.Order052ID).HasColumnName("Order052ID");
            this.Property(t => t.Item052ID).HasColumnName("Item052ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item052)
                .WithMany(t => t.OrderLine052)
                .HasForeignKey(d => d.Item052ID);
            this.HasRequired(t => t.Order052)
                .WithMany(t => t.OrderLine052)
                .HasForeignKey(d => d.Order052ID);

        }
    }
}
