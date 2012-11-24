using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine043Map : EntityTypeConfiguration<OrderLine043>
    {
        public OrderLine043Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine043ID);

            // Properties
            this.Property(t => t.Item043ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine043");
            this.Property(t => t.OrderLine043ID).HasColumnName("OrderLine043ID");
            this.Property(t => t.Order043ID).HasColumnName("Order043ID");
            this.Property(t => t.Item043ID).HasColumnName("Item043ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item043)
                .WithMany(t => t.OrderLine043)
                .HasForeignKey(d => d.Item043ID);
            this.HasRequired(t => t.Order043)
                .WithMany(t => t.OrderLine043)
                .HasForeignKey(d => d.Order043ID);

        }
    }
}
