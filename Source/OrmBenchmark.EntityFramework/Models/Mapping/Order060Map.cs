using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order060Map : EntityTypeConfiguration<Order060>
    {
        public Order060Map()
        {
            // Primary Key
            this.HasKey(t => t.Order060ID);

            // Properties
            this.Property(t => t.Customer060ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order060");
            this.Property(t => t.Order060ID).HasColumnName("Order060ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer060ID).HasColumnName("Customer060ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer060)
                .WithMany(t => t.Order060)
                .HasForeignKey(d => d.Customer060ID);

        }
    }
}
