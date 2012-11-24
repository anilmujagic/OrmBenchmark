using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine095Map : EntityTypeConfiguration<OrderLine095>
    {
        public OrderLine095Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine095ID);

            // Properties
            this.Property(t => t.Item095ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine095");
            this.Property(t => t.OrderLine095ID).HasColumnName("OrderLine095ID");
            this.Property(t => t.Order095ID).HasColumnName("Order095ID");
            this.Property(t => t.Item095ID).HasColumnName("Item095ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item095)
                .WithMany(t => t.OrderLine095)
                .HasForeignKey(d => d.Item095ID);
            this.HasRequired(t => t.Order095)
                .WithMany(t => t.OrderLine095)
                .HasForeignKey(d => d.Order095ID);

        }
    }
}
