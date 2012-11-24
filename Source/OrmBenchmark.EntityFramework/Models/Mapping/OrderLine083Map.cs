using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine083Map : EntityTypeConfiguration<OrderLine083>
    {
        public OrderLine083Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine083ID);

            // Properties
            this.Property(t => t.Item083ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine083");
            this.Property(t => t.OrderLine083ID).HasColumnName("OrderLine083ID");
            this.Property(t => t.Order083ID).HasColumnName("Order083ID");
            this.Property(t => t.Item083ID).HasColumnName("Item083ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item083)
                .WithMany(t => t.OrderLine083)
                .HasForeignKey(d => d.Item083ID);
            this.HasRequired(t => t.Order083)
                .WithMany(t => t.OrderLine083)
                .HasForeignKey(d => d.Order083ID);

        }
    }
}
