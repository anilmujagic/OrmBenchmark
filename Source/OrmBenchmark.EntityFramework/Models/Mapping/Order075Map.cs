using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order075Map : EntityTypeConfiguration<Order075>
    {
        public Order075Map()
        {
            // Primary Key
            this.HasKey(t => t.Order075ID);

            // Properties
            this.Property(t => t.Customer075ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order075");
            this.Property(t => t.Order075ID).HasColumnName("Order075ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer075ID).HasColumnName("Customer075ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer075)
                .WithMany(t => t.Order075)
                .HasForeignKey(d => d.Customer075ID);

        }
    }
}
