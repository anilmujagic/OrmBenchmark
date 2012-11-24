using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine016Map : EntityTypeConfiguration<OrderLine016>
    {
        public OrderLine016Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine016ID);

            // Properties
            this.Property(t => t.Item016ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine016");
            this.Property(t => t.OrderLine016ID).HasColumnName("OrderLine016ID");
            this.Property(t => t.Order016ID).HasColumnName("Order016ID");
            this.Property(t => t.Item016ID).HasColumnName("Item016ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item016)
                .WithMany(t => t.OrderLine016)
                .HasForeignKey(d => d.Item016ID);
            this.HasRequired(t => t.Order016)
                .WithMany(t => t.OrderLine016)
                .HasForeignKey(d => d.Order016ID);

        }
    }
}
