using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine087Map : EntityTypeConfiguration<OrderLine087>
    {
        public OrderLine087Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine087ID);

            // Properties
            this.Property(t => t.Item087ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine087");
            this.Property(t => t.OrderLine087ID).HasColumnName("OrderLine087ID");
            this.Property(t => t.Order087ID).HasColumnName("Order087ID");
            this.Property(t => t.Item087ID).HasColumnName("Item087ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item087)
                .WithMany(t => t.OrderLine087)
                .HasForeignKey(d => d.Item087ID);
            this.HasRequired(t => t.Order087)
                .WithMany(t => t.OrderLine087)
                .HasForeignKey(d => d.Order087ID);

        }
    }
}
