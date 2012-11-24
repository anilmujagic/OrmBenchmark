using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine007Map : EntityTypeConfiguration<OrderLine007>
    {
        public OrderLine007Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine007ID);

            // Properties
            this.Property(t => t.Item007ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine007");
            this.Property(t => t.OrderLine007ID).HasColumnName("OrderLine007ID");
            this.Property(t => t.Order007ID).HasColumnName("Order007ID");
            this.Property(t => t.Item007ID).HasColumnName("Item007ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item007)
                .WithMany(t => t.OrderLine007)
                .HasForeignKey(d => d.Item007ID);
            this.HasRequired(t => t.Order007)
                .WithMany(t => t.OrderLine007)
                .HasForeignKey(d => d.Order007ID);

        }
    }
}
