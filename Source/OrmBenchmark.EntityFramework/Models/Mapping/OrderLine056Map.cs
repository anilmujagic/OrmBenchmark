using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine056Map : EntityTypeConfiguration<OrderLine056>
    {
        public OrderLine056Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine056ID);

            // Properties
            this.Property(t => t.Item056ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine056");
            this.Property(t => t.OrderLine056ID).HasColumnName("OrderLine056ID");
            this.Property(t => t.Order056ID).HasColumnName("Order056ID");
            this.Property(t => t.Item056ID).HasColumnName("Item056ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item056)
                .WithMany(t => t.OrderLine056)
                .HasForeignKey(d => d.Item056ID);
            this.HasRequired(t => t.Order056)
                .WithMany(t => t.OrderLine056)
                .HasForeignKey(d => d.Order056ID);

        }
    }
}
