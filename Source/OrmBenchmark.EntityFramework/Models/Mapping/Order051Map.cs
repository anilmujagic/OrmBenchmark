using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order051Map : EntityTypeConfiguration<Order051>
    {
        public Order051Map()
        {
            // Primary Key
            this.HasKey(t => t.Order051ID);

            // Properties
            this.Property(t => t.Customer051ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order051");
            this.Property(t => t.Order051ID).HasColumnName("Order051ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer051ID).HasColumnName("Customer051ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer051)
                .WithMany(t => t.Order051)
                .HasForeignKey(d => d.Customer051ID);

        }
    }
}
