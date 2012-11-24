using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class OrderLine029Map : EntityTypeConfiguration<OrderLine029>
    {
        public OrderLine029Map()
        {
            // Primary Key
            this.HasKey(t => t.OrderLine029ID);

            // Properties
            this.Property(t => t.Item029ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderLine029");
            this.Property(t => t.OrderLine029ID).HasColumnName("OrderLine029ID");
            this.Property(t => t.Order029ID).HasColumnName("Order029ID");
            this.Property(t => t.Item029ID).HasColumnName("Item029ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Item029)
                .WithMany(t => t.OrderLine029)
                .HasForeignKey(d => d.Item029ID);
            this.HasRequired(t => t.Order029)
                .WithMany(t => t.OrderLine029)
                .HasForeignKey(d => d.Order029ID);

        }
    }
}
