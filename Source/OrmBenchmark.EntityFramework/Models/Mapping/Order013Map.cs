using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order013Map : EntityTypeConfiguration<Order013>
    {
        public Order013Map()
        {
            // Primary Key
            this.HasKey(t => t.Order013ID);

            // Properties
            this.Property(t => t.Customer013ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order013");
            this.Property(t => t.Order013ID).HasColumnName("Order013ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer013ID).HasColumnName("Customer013ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer013)
                .WithMany(t => t.Order013)
                .HasForeignKey(d => d.Customer013ID);

        }
    }
}
