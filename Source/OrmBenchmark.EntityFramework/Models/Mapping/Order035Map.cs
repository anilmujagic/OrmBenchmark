using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order035Map : EntityTypeConfiguration<Order035>
    {
        public Order035Map()
        {
            // Primary Key
            this.HasKey(t => t.Order035ID);

            // Properties
            this.Property(t => t.Customer035ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order035");
            this.Property(t => t.Order035ID).HasColumnName("Order035ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer035ID).HasColumnName("Customer035ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer035)
                .WithMany(t => t.Order035)
                .HasForeignKey(d => d.Customer035ID);

        }
    }
}
