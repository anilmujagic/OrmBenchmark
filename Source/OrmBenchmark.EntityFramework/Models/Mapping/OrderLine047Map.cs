using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine047Map : EntityTypeConfiguration<OrderLine047>
    {
        public OrderLine047Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine047ID);

            // Properties
            this.Property(t => t.Item047ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine047");
            this.Property(t => t.OrderLine047ID).HasColumnName("OrderLine047ID");
            this.Property(t => t.Order047ID).HasColumnName("Order047ID");
            this.Property(t => t.Item047ID).HasColumnName("Item047ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item047)
                .WithMany(t => t.OrderLine047)
                .HasForeignKey(d => d.Item047ID);
            this.HasRequired(t => t.Order047)
                .WithMany(t => t.OrderLine047)
                .HasForeignKey(d => d.Order047ID);

        }
    }
}
