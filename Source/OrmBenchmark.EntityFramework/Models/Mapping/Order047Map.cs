using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order047Map : EntityTypeConfiguration<Order047>
    {
        public Order047Map()
        {
            // Primary Key
            this.HasKey(t => t.Order047ID);

            // Properties
            this.Property(t => t.Customer047ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order047");
            this.Property(t => t.Order047ID).HasColumnName("Order047ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer047ID).HasColumnName("Customer047ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer047)
                .WithMany(t => t.Order047)
                .HasForeignKey(d => d.Customer047ID);

        }
    }
}
