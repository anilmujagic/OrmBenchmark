using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine054Map : EntityTypeConfiguration<OrderLine054>
    {
        public OrderLine054Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine054ID);

            // Properties
            this.Property(t => t.Item054ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine054");
            this.Property(t => t.OrderLine054ID).HasColumnName("OrderLine054ID");
            this.Property(t => t.Order054ID).HasColumnName("Order054ID");
            this.Property(t => t.Item054ID).HasColumnName("Item054ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item054)
                .WithMany(t => t.OrderLine054)
                .HasForeignKey(d => d.Item054ID);
            this.HasRequired(t => t.Order054)
                .WithMany(t => t.OrderLine054)
                .HasForeignKey(d => d.Order054ID);

        }
    }
}
