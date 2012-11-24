using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine028Map : EntityTypeConfiguration<OrderLine028>
    {
        public OrderLine028Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine028ID);

            // Properties
            this.Property(t => t.Item028ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine028");
            this.Property(t => t.OrderLine028ID).HasColumnName("OrderLine028ID");
            this.Property(t => t.Order028ID).HasColumnName("Order028ID");
            this.Property(t => t.Item028ID).HasColumnName("Item028ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item028)
                .WithMany(t => t.OrderLine028)
                .HasForeignKey(d => d.Item028ID);
            this.HasRequired(t => t.Order028)
                .WithMany(t => t.OrderLine028)
                .HasForeignKey(d => d.Order028ID);

        }
    }
}
