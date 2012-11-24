using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order020Map : EntityTypeConfiguration<Order020>
    {
        public Order020Map()
        {
            // Primary Key
            this.HasKey(t => t.Order020ID);

            // Properties
            this.Property(t => t.Customer020ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order020");
            this.Property(t => t.Order020ID).HasColumnName("Order020ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer020ID).HasColumnName("Customer020ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer020)
                .WithMany(t => t.Order020)
                .HasForeignKey(d => d.Customer020ID);

        }
    }
}
