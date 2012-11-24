using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order045Map : EntityTypeConfiguration<Order045>
    {
        public Order045Map()
        {
            // Primary Key
            this.HasKey(t => t.Order045ID);

            // Properties
            this.Property(t => t.Customer045ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order045");
            this.Property(t => t.Order045ID).HasColumnName("Order045ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer045ID).HasColumnName("Customer045ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer045)
                .WithMany(t => t.Order045)
                .HasForeignKey(d => d.Customer045ID);

        }
    }
}
