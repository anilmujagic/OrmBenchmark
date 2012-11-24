using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine086Map : EntityTypeConfiguration<OrderLine086>
    {
        public OrderLine086Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine086ID);

            // Properties
            this.Property(t => t.Item086ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine086");
            this.Property(t => t.OrderLine086ID).HasColumnName("OrderLine086ID");
            this.Property(t => t.Order086ID).HasColumnName("Order086ID");
            this.Property(t => t.Item086ID).HasColumnName("Item086ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item086)
                .WithMany(t => t.OrderLine086)
                .HasForeignKey(d => d.Item086ID);
            this.HasRequired(t => t.Order086)
                .WithMany(t => t.OrderLine086)
                .HasForeignKey(d => d.Order086ID);

        }
    }
}
