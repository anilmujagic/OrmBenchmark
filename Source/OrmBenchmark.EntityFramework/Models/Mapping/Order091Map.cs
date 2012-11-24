using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order091Map : EntityTypeConfiguration<Order091>
    {
        public Order091Map()
        {
            // Primary Key
            this.HasKey(t => t.Order091ID);

            // Properties
            this.Property(t => t.Customer091ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order091");
            this.Property(t => t.Order091ID).HasColumnName("Order091ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer091ID).HasColumnName("Customer091ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer091)
                .WithMany(t => t.Order091)
                .HasForeignKey(d => d.Customer091ID);

        }
    }
}
