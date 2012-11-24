using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine021Map : EntityTypeConfiguration<OrderLine021>
    {
        public OrderLine021Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine021ID);

            // Properties
            this.Property(t => t.Item021ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine021");
            this.Property(t => t.OrderLine021ID).HasColumnName("OrderLine021ID");
            this.Property(t => t.Order021ID).HasColumnName("Order021ID");
            this.Property(t => t.Item021ID).HasColumnName("Item021ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item021)
                .WithMany(t => t.OrderLine021)
                .HasForeignKey(d => d.Item021ID);
            this.HasRequired(t => t.Order021)
                .WithMany(t => t.OrderLine021)
                .HasForeignKey(d => d.Order021ID);

        }
    }
}
