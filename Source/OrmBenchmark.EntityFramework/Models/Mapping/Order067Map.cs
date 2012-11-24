using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order067Map : EntityTypeConfiguration<Order067>
    {
        public Order067Map()
        {
            // Primary Key
            this.HasKey(t => t.Order067ID);

            // Properties
            this.Property(t => t.Customer067ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order067");
            this.Property(t => t.Order067ID).HasColumnName("Order067ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer067ID).HasColumnName("Customer067ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer067)
                .WithMany(t => t.Order067)
                .HasForeignKey(d => d.Customer067ID);

        }
    }
}
