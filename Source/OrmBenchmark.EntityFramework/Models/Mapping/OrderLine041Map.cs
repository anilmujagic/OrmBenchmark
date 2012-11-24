using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine041Map : EntityTypeConfiguration<OrderLine041>
    {
        public OrderLine041Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine041ID);

            // Properties
            this.Property(t => t.Item041ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine041");
            this.Property(t => t.OrderLine041ID).HasColumnName("OrderLine041ID");
            this.Property(t => t.Order041ID).HasColumnName("Order041ID");
            this.Property(t => t.Item041ID).HasColumnName("Item041ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item041)
                .WithMany(t => t.OrderLine041)
                .HasForeignKey(d => d.Item041ID);
            this.HasRequired(t => t.Order041)
                .WithMany(t => t.OrderLine041)
                .HasForeignKey(d => d.Order041ID);

        }
    }
}
