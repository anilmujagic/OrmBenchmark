using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order095Map : EntityTypeConfiguration<Order095>
    {
        public Order095Map()
        {
            // Primary Key
            this.HasKey(t => t.Order095ID);

            // Properties
            this.Property(t => t.Customer095ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order095");
            this.Property(t => t.Order095ID).HasColumnName("Order095ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer095ID).HasColumnName("Customer095ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer095)
                .WithMany(t => t.Order095)
                .HasForeignKey(d => d.Customer095ID);

        }
    }
}
