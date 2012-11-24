using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order008Map : EntityTypeConfiguration<Order008>
    {
        public Order008Map()
        {
            // Primary Key
            this.HasKey(t => t.Order008ID);

            // Properties
            this.Property(t => t.Customer008ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order008");
            this.Property(t => t.Order008ID).HasColumnName("Order008ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer008ID).HasColumnName("Customer008ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer008)
                .WithMany(t => t.Order008)
                .HasForeignKey(d => d.Customer008ID);

        }
    }
}
