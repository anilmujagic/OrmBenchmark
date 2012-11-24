using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine015Map : EntityTypeConfiguration<OrderLine015>
    {
        public OrderLine015Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine015ID);

            // Properties
            this.Property(t => t.Item015ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine015");
            this.Property(t => t.OrderLine015ID).HasColumnName("OrderLine015ID");
            this.Property(t => t.Order015ID).HasColumnName("Order015ID");
            this.Property(t => t.Item015ID).HasColumnName("Item015ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item015)
                .WithMany(t => t.OrderLine015)
                .HasForeignKey(d => d.Item015ID);
            this.HasRequired(t => t.Order015)
                .WithMany(t => t.OrderLine015)
                .HasForeignKey(d => d.Order015ID);

        }
    }
}
