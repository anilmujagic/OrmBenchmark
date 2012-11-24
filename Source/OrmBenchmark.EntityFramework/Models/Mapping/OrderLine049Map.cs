using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine049Map : EntityTypeConfiguration<OrderLine049>
    {
        public OrderLine049Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine049ID);

            // Properties
            this.Property(t => t.Item049ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine049");
            this.Property(t => t.OrderLine049ID).HasColumnName("OrderLine049ID");
            this.Property(t => t.Order049ID).HasColumnName("Order049ID");
            this.Property(t => t.Item049ID).HasColumnName("Item049ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item049)
                .WithMany(t => t.OrderLine049)
                .HasForeignKey(d => d.Item049ID);
            this.HasRequired(t => t.Order049)
                .WithMany(t => t.OrderLine049)
                .HasForeignKey(d => d.Order049ID);

        }
    }
}
