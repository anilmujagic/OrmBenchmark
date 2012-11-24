using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order041Map : EntityTypeConfiguration<Order041>
    {
        public Order041Map()
        {
            // Primary Key
            this.HasKey(t => t.Order041ID);

            // Properties
            this.Property(t => t.Customer041ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order041");
            this.Property(t => t.Order041ID).HasColumnName("Order041ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer041ID).HasColumnName("Customer041ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer041)
                .WithMany(t => t.Order041)
                .HasForeignKey(d => d.Customer041ID);

        }
    }
}
