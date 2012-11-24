using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order052Map : EntityTypeConfiguration<Order052>
    {
        public Order052Map()
        {
            // Primary Key
            this.HasKey(t => t.Order052ID);

            // Properties
            this.Property(t => t.Customer052ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order052");
            this.Property(t => t.Order052ID).HasColumnName("Order052ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer052ID).HasColumnName("Customer052ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer052)
                .WithMany(t => t.Order052)
                .HasForeignKey(d => d.Customer052ID);

        }
    }
}
