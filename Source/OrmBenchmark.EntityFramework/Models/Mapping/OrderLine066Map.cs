using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine066Map : EntityTypeConfiguration<OrderLine066>
    {
        public OrderLine066Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine066ID);

            // Properties
            this.Property(t => t.Item066ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine066");
            this.Property(t => t.OrderLine066ID).HasColumnName("OrderLine066ID");
            this.Property(t => t.Order066ID).HasColumnName("Order066ID");
            this.Property(t => t.Item066ID).HasColumnName("Item066ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item066)
                .WithMany(t => t.OrderLine066)
                .HasForeignKey(d => d.Item066ID);
            this.HasRequired(t => t.Order066)
                .WithMany(t => t.OrderLine066)
                .HasForeignKey(d => d.Order066ID);

        }
    }
}
