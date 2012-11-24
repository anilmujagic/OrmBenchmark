using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order004Map : EntityTypeConfiguration<Order004>
    {
        public Order004Map()
        {
            // Primary Key
            this.HasKey(t => t.Order004ID);

            // Properties
            this.Property(t => t.Customer004ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order004");
            this.Property(t => t.Order004ID).HasColumnName("Order004ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer004ID).HasColumnName("Customer004ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer004)
                .WithMany(t => t.Order004)
                .HasForeignKey(d => d.Customer004ID);

        }
    }
}
