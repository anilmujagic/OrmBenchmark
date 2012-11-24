using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order038Map : EntityTypeConfiguration<Order038>
    {
        public Order038Map()
        {
            // Primary Key
            this.HasKey(t => t.Order038ID);

            // Properties
            this.Property(t => t.Customer038ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order038");
            this.Property(t => t.Order038ID).HasColumnName("Order038ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer038ID).HasColumnName("Customer038ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer038)
                .WithMany(t => t.Order038)
                .HasForeignKey(d => d.Customer038ID);

        }
    }
}
