using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order037Map : EntityTypeConfiguration<Order037>
    {
        public Order037Map()
        {
            // Primary Key
            this.HasKey(t => t.Order037ID);

            // Properties
            this.Property(t => t.Customer037ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order037");
            this.Property(t => t.Order037ID).HasColumnName("Order037ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer037ID).HasColumnName("Customer037ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer037)
                .WithMany(t => t.Order037)
                .HasForeignKey(d => d.Customer037ID);

        }
    }
}
