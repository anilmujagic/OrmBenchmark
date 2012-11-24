using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine085Map : EntityTypeConfiguration<OrderLine085>
    {
        public OrderLine085Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine085ID);

            // Properties
            this.Property(t => t.Item085ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine085");
            this.Property(t => t.OrderLine085ID).HasColumnName("OrderLine085ID");
            this.Property(t => t.Order085ID).HasColumnName("Order085ID");
            this.Property(t => t.Item085ID).HasColumnName("Item085ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item085)
                .WithMany(t => t.OrderLine085)
                .HasForeignKey(d => d.Item085ID);
            this.HasRequired(t => t.Order085)
                .WithMany(t => t.OrderLine085)
                .HasForeignKey(d => d.Order085ID);

        }
    }
}
