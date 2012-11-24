using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine009Map : EntityTypeConfiguration<OrderLine009>
    {
        public OrderLine009Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine009ID);

            // Properties
            this.Property(t => t.Item009ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine009");
            this.Property(t => t.OrderLine009ID).HasColumnName("OrderLine009ID");
            this.Property(t => t.Order009ID).HasColumnName("Order009ID");
            this.Property(t => t.Item009ID).HasColumnName("Item009ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item009)
                .WithMany(t => t.OrderLine009)
                .HasForeignKey(d => d.Item009ID);
            this.HasRequired(t => t.Order009)
                .WithMany(t => t.OrderLine009)
                .HasForeignKey(d => d.Order009ID);

        }
    }
}
