using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine050Map : EntityTypeConfiguration<OrderLine050>
    {
        public OrderLine050Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine050ID);

            // Properties
            this.Property(t => t.Item050ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine050");
            this.Property(t => t.OrderLine050ID).HasColumnName("OrderLine050ID");
            this.Property(t => t.Order050ID).HasColumnName("Order050ID");
            this.Property(t => t.Item050ID).HasColumnName("Item050ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item050)
                .WithMany(t => t.OrderLine050)
                .HasForeignKey(d => d.Item050ID);
            this.HasRequired(t => t.Order050)
                .WithMany(t => t.OrderLine050)
                .HasForeignKey(d => d.Order050ID);

        }
    }
}
