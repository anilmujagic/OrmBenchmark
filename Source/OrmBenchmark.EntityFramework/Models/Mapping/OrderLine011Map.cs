using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine011Map : EntityTypeConfiguration<OrderLine011>
    {
        public OrderLine011Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine011ID);

            // Properties
            this.Property(t => t.Item011ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine011");
            this.Property(t => t.OrderLine011ID).HasColumnName("OrderLine011ID");
            this.Property(t => t.Order011ID).HasColumnName("Order011ID");
            this.Property(t => t.Item011ID).HasColumnName("Item011ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item011)
                .WithMany(t => t.OrderLine011)
                .HasForeignKey(d => d.Item011ID);
            this.HasRequired(t => t.Order011)
                .WithMany(t => t.OrderLine011)
                .HasForeignKey(d => d.Order011ID);

        }
    }
}
