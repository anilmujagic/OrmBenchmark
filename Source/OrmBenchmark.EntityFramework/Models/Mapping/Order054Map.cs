using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order054Map : EntityTypeConfiguration<Order054>
    {
        public Order054Map()
        {
            // Primary Key
            this.HasKey(t => t.Order054ID);

            // Properties
            this.Property(t => t.Customer054ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order054");
            this.Property(t => t.Order054ID).HasColumnName("Order054ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer054ID).HasColumnName("Customer054ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer054)
                .WithMany(t => t.Order054)
                .HasForeignKey(d => d.Customer054ID);

        }
    }
}
