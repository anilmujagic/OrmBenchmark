using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order048Map : EntityTypeConfiguration<Order048>
    {
        public Order048Map()
        {
            // Primary Key
            this.HasKey(t => t.Order048ID);

            // Properties
            this.Property(t => t.Customer048ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order048");
            this.Property(t => t.Order048ID).HasColumnName("Order048ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer048ID).HasColumnName("Customer048ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer048)
                .WithMany(t => t.Order048)
                .HasForeignKey(d => d.Customer048ID);

        }
    }
}
