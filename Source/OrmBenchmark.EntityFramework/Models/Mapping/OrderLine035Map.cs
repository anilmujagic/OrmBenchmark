using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine035Map : EntityTypeConfiguration<OrderLine035>
    {
        public OrderLine035Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine035ID);

            // Properties
            this.Property(t => t.Item035ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine035");
            this.Property(t => t.OrderLine035ID).HasColumnName("OrderLine035ID");
            this.Property(t => t.Order035ID).HasColumnName("Order035ID");
            this.Property(t => t.Item035ID).HasColumnName("Item035ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item035)
                .WithMany(t => t.OrderLine035)
                .HasForeignKey(d => d.Item035ID);
            this.HasRequired(t => t.Order035)
                .WithMany(t => t.OrderLine035)
                .HasForeignKey(d => d.Order035ID);

        }
    }
}
