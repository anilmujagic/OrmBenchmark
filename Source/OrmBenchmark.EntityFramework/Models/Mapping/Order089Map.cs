using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order089Map : EntityTypeConfiguration<Order089>
    {
        public Order089Map()
        {
            // Primary Key
            this.HasKey(t => t.Order089ID);

            // Properties
            this.Property(t => t.Customer089ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order089");
            this.Property(t => t.Order089ID).HasColumnName("Order089ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer089ID).HasColumnName("Customer089ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer089)
                .WithMany(t => t.Order089)
                .HasForeignKey(d => d.Customer089ID);

        }
    }
}
