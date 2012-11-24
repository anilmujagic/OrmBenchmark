using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order061Map : EntityTypeConfiguration<Order061>
    {
        public Order061Map()
        {
            // Primary Key
            this.HasKey(t => t.Order061ID);

            // Properties
            this.Property(t => t.Customer061ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order061");
            this.Property(t => t.Order061ID).HasColumnName("Order061ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer061ID).HasColumnName("Customer061ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer061)
                .WithMany(t => t.Order061)
                .HasForeignKey(d => d.Customer061ID);

        }
    }
}
