using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order042Map : EntityTypeConfiguration<Order042>
    {
        public Order042Map()
        {
            // Primary Key
            this.HasKey(t => t.Order042ID);

            // Properties
            this.Property(t => t.Customer042ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order042");
            this.Property(t => t.Order042ID).HasColumnName("Order042ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer042ID).HasColumnName("Customer042ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer042)
                .WithMany(t => t.Order042)
                .HasForeignKey(d => d.Customer042ID);

        }
    }
}
