using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order024Map : EntityTypeConfiguration<Order024>
    {
        public Order024Map()
        {
            // Primary Key
            this.HasKey(t => t.Order024ID);

            // Properties
            this.Property(t => t.Customer024ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order024");
            this.Property(t => t.Order024ID).HasColumnName("Order024ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer024ID).HasColumnName("Customer024ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer024)
                .WithMany(t => t.Order024)
                .HasForeignKey(d => d.Customer024ID);

        }
    }
}
