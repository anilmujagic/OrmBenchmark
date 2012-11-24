using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine065Map : EntityTypeConfiguration<OrderLine065>
    {
        public OrderLine065Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine065ID);

            // Properties
            this.Property(t => t.Item065ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine065");
            this.Property(t => t.OrderLine065ID).HasColumnName("OrderLine065ID");
            this.Property(t => t.Order065ID).HasColumnName("Order065ID");
            this.Property(t => t.Item065ID).HasColumnName("Item065ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item065)
                .WithMany(t => t.OrderLine065)
                .HasForeignKey(d => d.Item065ID);
            this.HasRequired(t => t.Order065)
                .WithMany(t => t.OrderLine065)
                .HasForeignKey(d => d.Order065ID);

        }
    }
}
