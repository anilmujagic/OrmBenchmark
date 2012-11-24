using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine070Map : EntityTypeConfiguration<OrderLine070>
    {
        public OrderLine070Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine070ID);

            // Properties
            this.Property(t => t.Item070ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine070");
            this.Property(t => t.OrderLine070ID).HasColumnName("OrderLine070ID");
            this.Property(t => t.Order070ID).HasColumnName("Order070ID");
            this.Property(t => t.Item070ID).HasColumnName("Item070ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item070)
                .WithMany(t => t.OrderLine070)
                .HasForeignKey(d => d.Item070ID);
            this.HasRequired(t => t.Order070)
                .WithMany(t => t.OrderLine070)
                .HasForeignKey(d => d.Order070ID);

        }
    }
}
