using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order036Map : EntityTypeConfiguration<Order036>
    {
        public Order036Map()
        {
            // Primary Key
            this.HasKey(t => t.Order036ID);

            // Properties
            this.Property(t => t.Customer036ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order036");
            this.Property(t => t.Order036ID).HasColumnName("Order036ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer036ID).HasColumnName("Customer036ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer036)
                .WithMany(t => t.Order036)
                .HasForeignKey(d => d.Customer036ID);

        }
    }
}
