using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine073Map : EntityTypeConfiguration<OrderLine073>
    {
        public OrderLine073Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine073ID);

            // Properties
            this.Property(t => t.Item073ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine073");
            this.Property(t => t.OrderLine073ID).HasColumnName("OrderLine073ID");
            this.Property(t => t.Order073ID).HasColumnName("Order073ID");
            this.Property(t => t.Item073ID).HasColumnName("Item073ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item073)
                .WithMany(t => t.OrderLine073)
                .HasForeignKey(d => d.Item073ID);
            this.HasRequired(t => t.Order073)
                .WithMany(t => t.OrderLine073)
                .HasForeignKey(d => d.Order073ID);

        }
    }
}
