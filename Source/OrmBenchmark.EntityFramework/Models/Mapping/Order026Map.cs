using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order026Map : EntityTypeConfiguration<Order026>
    {
        public Order026Map()
        {
            // Primary Key
            this.HasKey(t => t.Order026ID);

            // Properties
            this.Property(t => t.Customer026ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order026");
            this.Property(t => t.Order026ID).HasColumnName("Order026ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer026ID).HasColumnName("Customer026ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer026)
                .WithMany(t => t.Order026)
                .HasForeignKey(d => d.Customer026ID);

        }
    }
}
