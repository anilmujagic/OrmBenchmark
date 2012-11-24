using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order098Map : EntityTypeConfiguration<Order098>
    {
        public Order098Map()
        {
            // Primary Key
            this.HasKey(t => t.Order098ID);

            // Properties
            this.Property(t => t.Customer098ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order098");
            this.Property(t => t.Order098ID).HasColumnName("Order098ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer098ID).HasColumnName("Customer098ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer098)
                .WithMany(t => t.Order098)
                .HasForeignKey(d => d.Customer098ID);

        }
    }
}
