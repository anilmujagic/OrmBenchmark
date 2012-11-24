using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order046Map : EntityTypeConfiguration<Order046>
    {
        public Order046Map()
        {
            // Primary Key
            this.HasKey(t => t.Order046ID);

            // Properties
            this.Property(t => t.Customer046ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order046");
            this.Property(t => t.Order046ID).HasColumnName("Order046ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer046ID).HasColumnName("Customer046ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer046)
                .WithMany(t => t.Order046)
                .HasForeignKey(d => d.Customer046ID);

        }
    }
}
