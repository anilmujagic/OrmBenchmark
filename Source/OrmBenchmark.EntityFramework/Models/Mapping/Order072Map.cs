using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order072Map : EntityTypeConfiguration<Order072>
    {
        public Order072Map()
        {
            // Primary Key
            this.HasKey(t => t.Order072ID);

            // Properties
            this.Property(t => t.Customer072ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order072");
            this.Property(t => t.Order072ID).HasColumnName("Order072ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer072ID).HasColumnName("Customer072ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer072)
                .WithMany(t => t.Order072)
                .HasForeignKey(d => d.Customer072ID);

        }
    }
}
