using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order086Map : EntityTypeConfiguration<Order086>
    {
        public Order086Map()
        {
            // Primary Key
            this.HasKey(t => t.Order086ID);

            // Properties
            this.Property(t => t.Customer086ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order086");
            this.Property(t => t.Order086ID).HasColumnName("Order086ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer086ID).HasColumnName("Customer086ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer086)
                .WithMany(t => t.Order086)
                .HasForeignKey(d => d.Customer086ID);

        }
    }
}
