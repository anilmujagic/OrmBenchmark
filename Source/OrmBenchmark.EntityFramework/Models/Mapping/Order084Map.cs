using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order084Map : EntityTypeConfiguration<Order084>
    {
        public Order084Map()
        {
            // Primary Key
            this.HasKey(t => t.Order084ID);

            // Properties
            this.Property(t => t.Customer084ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order084");
            this.Property(t => t.Order084ID).HasColumnName("Order084ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer084ID).HasColumnName("Customer084ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer084)
                .WithMany(t => t.Order084)
                .HasForeignKey(d => d.Customer084ID);

        }
    }
}
