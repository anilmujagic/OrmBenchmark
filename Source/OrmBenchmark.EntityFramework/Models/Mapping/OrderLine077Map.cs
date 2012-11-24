using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine077Map : EntityTypeConfiguration<OrderLine077>
    {
        public OrderLine077Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine077ID);

            // Properties
            this.Property(t => t.Item077ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine077");
            this.Property(t => t.OrderLine077ID).HasColumnName("OrderLine077ID");
            this.Property(t => t.Order077ID).HasColumnName("Order077ID");
            this.Property(t => t.Item077ID).HasColumnName("Item077ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item077)
                .WithMany(t => t.OrderLine077)
                .HasForeignKey(d => d.Item077ID);
            this.HasRequired(t => t.Order077)
                .WithMany(t => t.OrderLine077)
                .HasForeignKey(d => d.Order077ID);

        }
    }
}
