using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order034Map : EntityTypeConfiguration<Order034>
    {
        public Order034Map()
        {
            // Primary Key
            this.HasKey(t => t.Order034ID);

            // Properties
            this.Property(t => t.Customer034ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order034");
            this.Property(t => t.Order034ID).HasColumnName("Order034ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer034ID).HasColumnName("Customer034ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer034)
                .WithMany(t => t.Order034)
                .HasForeignKey(d => d.Customer034ID);

        }
    }
}
