using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine064Map : EntityTypeConfiguration<OrderLine064>
    {
        public OrderLine064Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine064ID);

            // Properties
            this.Property(t => t.Item064ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine064");
            this.Property(t => t.OrderLine064ID).HasColumnName("OrderLine064ID");
            this.Property(t => t.Order064ID).HasColumnName("Order064ID");
            this.Property(t => t.Item064ID).HasColumnName("Item064ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item064)
                .WithMany(t => t.OrderLine064)
                .HasForeignKey(d => d.Item064ID);
            this.HasRequired(t => t.Order064)
                .WithMany(t => t.OrderLine064)
                .HasForeignKey(d => d.Order064ID);

        }
    }
}
