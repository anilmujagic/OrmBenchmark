using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine093Map : EntityTypeConfiguration<OrderLine093>
    {
        public OrderLine093Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine093ID);

            // Properties
            this.Property(t => t.Item093ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine093");
            this.Property(t => t.OrderLine093ID).HasColumnName("OrderLine093ID");
            this.Property(t => t.Order093ID).HasColumnName("Order093ID");
            this.Property(t => t.Item093ID).HasColumnName("Item093ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item093)
                .WithMany(t => t.OrderLine093)
                .HasForeignKey(d => d.Item093ID);
            this.HasRequired(t => t.Order093)
                .WithMany(t => t.OrderLine093)
                .HasForeignKey(d => d.Order093ID);

        }
    }
}
