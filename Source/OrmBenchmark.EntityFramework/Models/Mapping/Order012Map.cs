using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order012Map : EntityTypeConfiguration<Order012>
    {
        public Order012Map()
        {
            // Primary Key
            this.HasKey(t => t.Order012ID);

            // Properties
            this.Property(t => t.Customer012ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order012");
            this.Property(t => t.Order012ID).HasColumnName("Order012ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer012ID).HasColumnName("Customer012ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer012)
                .WithMany(t => t.Order012)
                .HasForeignKey(d => d.Customer012ID);

        }
    }
}
