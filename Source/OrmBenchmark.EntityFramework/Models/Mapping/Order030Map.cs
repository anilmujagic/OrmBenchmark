using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order030Map : EntityTypeConfiguration<Order030>
    {
        public Order030Map()
        {
            // Primary Key
            this.HasKey(t => t.Order030ID);

            // Properties
            this.Property(t => t.Customer030ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order030");
            this.Property(t => t.Order030ID).HasColumnName("Order030ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer030ID).HasColumnName("Customer030ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer030)
                .WithMany(t => t.Order030)
                .HasForeignKey(d => d.Customer030ID);

        }
    }
}
