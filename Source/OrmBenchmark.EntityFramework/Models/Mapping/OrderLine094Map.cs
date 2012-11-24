using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine094Map : EntityTypeConfiguration<OrderLine094>
    {
        public OrderLine094Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine094ID);

            // Properties
            this.Property(t => t.Item094ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine094");
            this.Property(t => t.OrderLine094ID).HasColumnName("OrderLine094ID");
            this.Property(t => t.Order094ID).HasColumnName("Order094ID");
            this.Property(t => t.Item094ID).HasColumnName("Item094ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item094)
                .WithMany(t => t.OrderLine094)
                .HasForeignKey(d => d.Item094ID);
            this.HasRequired(t => t.Order094)
                .WithMany(t => t.OrderLine094)
                .HasForeignKey(d => d.Order094ID);

        }
    }
}
