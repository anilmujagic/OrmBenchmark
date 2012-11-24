using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order065Map : EntityTypeConfiguration<Order065>
    {
        public Order065Map()
        {
            // Primary Key
            this.HasKey(t => t.Order065ID);

            // Properties
            this.Property(t => t.Customer065ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order065");
            this.Property(t => t.Order065ID).HasColumnName("Order065ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer065ID).HasColumnName("Customer065ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer065)
                .WithMany(t => t.Order065)
                .HasForeignKey(d => d.Customer065ID);

        }
    }
}
