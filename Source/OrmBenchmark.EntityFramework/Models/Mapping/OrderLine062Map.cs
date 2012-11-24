using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine062Map : EntityTypeConfiguration<OrderLine062>
    {
        public OrderLine062Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine062ID);

            // Properties
            this.Property(t => t.Item062ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine062");
            this.Property(t => t.OrderLine062ID).HasColumnName("OrderLine062ID");
            this.Property(t => t.Order062ID).HasColumnName("Order062ID");
            this.Property(t => t.Item062ID).HasColumnName("Item062ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item062)
                .WithMany(t => t.OrderLine062)
                .HasForeignKey(d => d.Item062ID);
            this.HasRequired(t => t.Order062)
                .WithMany(t => t.OrderLine062)
                .HasForeignKey(d => d.Order062ID);

        }
    }
}
