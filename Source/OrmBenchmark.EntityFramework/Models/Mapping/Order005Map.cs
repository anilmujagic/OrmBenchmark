using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order005Map : EntityTypeConfiguration<Order005>
    {
        public Order005Map()
        {
            // Primary Key
            this.HasKey(t => t.Order005ID);

            // Properties
            this.Property(t => t.Customer005ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order005");
            this.Property(t => t.Order005ID).HasColumnName("Order005ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer005ID).HasColumnName("Customer005ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer005)
                .WithMany(t => t.Order005)
                .HasForeignKey(d => d.Customer005ID);

        }
    }
}
