using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order069Map : EntityTypeConfiguration<Order069>
    {
        public Order069Map()
        {
            // Primary Key
            this.HasKey(t => t.Order069ID);

            // Properties
            this.Property(t => t.Customer069ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order069");
            this.Property(t => t.Order069ID).HasColumnName("Order069ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer069ID).HasColumnName("Customer069ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer069)
                .WithMany(t => t.Order069)
                .HasForeignKey(d => d.Customer069ID);

        }
    }
}
