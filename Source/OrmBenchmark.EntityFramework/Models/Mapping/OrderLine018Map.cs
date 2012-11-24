using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine018Map : EntityTypeConfiguration<OrderLine018>
    {
        public OrderLine018Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine018ID);

            // Properties
            this.Property(t => t.Item018ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine018");
            this.Property(t => t.OrderLine018ID).HasColumnName("OrderLine018ID");
            this.Property(t => t.Order018ID).HasColumnName("Order018ID");
            this.Property(t => t.Item018ID).HasColumnName("Item018ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item018)
                .WithMany(t => t.OrderLine018)
                .HasForeignKey(d => d.Item018ID);
            this.HasRequired(t => t.Order018)
                .WithMany(t => t.OrderLine018)
                .HasForeignKey(d => d.Order018ID);

        }
    }
}
