using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine078Map : EntityTypeConfiguration<OrderLine078>
    {
        public OrderLine078Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine078ID);

            // Properties
            this.Property(t => t.Item078ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine078");
            this.Property(t => t.OrderLine078ID).HasColumnName("OrderLine078ID");
            this.Property(t => t.Order078ID).HasColumnName("Order078ID");
            this.Property(t => t.Item078ID).HasColumnName("Item078ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item078)
                .WithMany(t => t.OrderLine078)
                .HasForeignKey(d => d.Item078ID);
            this.HasRequired(t => t.Order078)
                .WithMany(t => t.OrderLine078)
                .HasForeignKey(d => d.Order078ID);

        }
    }
}
