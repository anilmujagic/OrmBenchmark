using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order040Map : EntityTypeConfiguration<Order040>
    {
        public Order040Map()
        {
            // Primary Key
            this.HasKey(t => t.Order040ID);

            // Properties
            this.Property(t => t.Customer040ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order040");
            this.Property(t => t.Order040ID).HasColumnName("Order040ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer040ID).HasColumnName("Customer040ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer040)
                .WithMany(t => t.Order040)
                .HasForeignKey(d => d.Customer040ID);

        }
    }
}
