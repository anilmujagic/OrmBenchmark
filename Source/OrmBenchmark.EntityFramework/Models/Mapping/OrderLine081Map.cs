using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine081Map : EntityTypeConfiguration<OrderLine081>
    {
        public OrderLine081Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine081ID);

            // Properties
            this.Property(t => t.Item081ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine081");
            this.Property(t => t.OrderLine081ID).HasColumnName("OrderLine081ID");
            this.Property(t => t.Order081ID).HasColumnName("Order081ID");
            this.Property(t => t.Item081ID).HasColumnName("Item081ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item081)
                .WithMany(t => t.OrderLine081)
                .HasForeignKey(d => d.Item081ID);
            this.HasRequired(t => t.Order081)
                .WithMany(t => t.OrderLine081)
                .HasForeignKey(d => d.Order081ID);

        }
    }
}
