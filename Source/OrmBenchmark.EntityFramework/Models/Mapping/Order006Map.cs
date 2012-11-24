using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order006Map : EntityTypeConfiguration<Order006>
    {
        public Order006Map()
        {
            // Primary Key
            this.HasKey(t => t.Order006ID);

            // Properties
            this.Property(t => t.Customer006ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order006");
            this.Property(t => t.Order006ID).HasColumnName("Order006ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer006ID).HasColumnName("Customer006ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer006)
                .WithMany(t => t.Order006)
                .HasForeignKey(d => d.Customer006ID);

        }
    }
}
