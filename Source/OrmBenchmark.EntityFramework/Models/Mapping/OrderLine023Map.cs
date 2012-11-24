using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine023Map : EntityTypeConfiguration<OrderLine023>
    {
        public OrderLine023Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine023ID);

            // Properties
            this.Property(t => t.Item023ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine023");
            this.Property(t => t.OrderLine023ID).HasColumnName("OrderLine023ID");
            this.Property(t => t.Order023ID).HasColumnName("Order023ID");
            this.Property(t => t.Item023ID).HasColumnName("Item023ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item023)
                .WithMany(t => t.OrderLine023)
                .HasForeignKey(d => d.Item023ID);
            this.HasRequired(t => t.Order023)
                .WithMany(t => t.OrderLine023)
                .HasForeignKey(d => d.Order023ID);

        }
    }
}
