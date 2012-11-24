using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine063Map : EntityTypeConfiguration<OrderLine063>
    {
        public OrderLine063Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine063ID);

            // Properties
            this.Property(t => t.Item063ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine063");
            this.Property(t => t.OrderLine063ID).HasColumnName("OrderLine063ID");
            this.Property(t => t.Order063ID).HasColumnName("Order063ID");
            this.Property(t => t.Item063ID).HasColumnName("Item063ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item063)
                .WithMany(t => t.OrderLine063)
                .HasForeignKey(d => d.Item063ID);
            this.HasRequired(t => t.Order063)
                .WithMany(t => t.OrderLine063)
                .HasForeignKey(d => d.Order063ID);

        }
    }
}
