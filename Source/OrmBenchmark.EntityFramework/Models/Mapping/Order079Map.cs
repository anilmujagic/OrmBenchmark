using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order079Map : EntityTypeConfiguration<Order079>
    {
        public Order079Map()
        {
            // Primary Key
            this.HasKey(t => t.Order079ID);

            // Properties
            this.Property(t => t.Customer079ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order079");
            this.Property(t => t.Order079ID).HasColumnName("Order079ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer079ID).HasColumnName("Customer079ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer079)
                .WithMany(t => t.Order079)
                .HasForeignKey(d => d.Customer079ID);

        }
    }
}
