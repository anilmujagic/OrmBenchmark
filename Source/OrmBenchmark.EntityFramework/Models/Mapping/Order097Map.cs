using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order097Map : EntityTypeConfiguration<Order097>
    {
        public Order097Map()
        {
            // Primary Key
            this.HasKey(t => t.Order097ID);

            // Properties
            this.Property(t => t.Customer097ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order097");
            this.Property(t => t.Order097ID).HasColumnName("Order097ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer097ID).HasColumnName("Customer097ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer097)
                .WithMany(t => t.Order097)
                .HasForeignKey(d => d.Customer097ID);

        }
    }
}
