using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order010Map : EntityTypeConfiguration<Order010>
    {
        public Order010Map()
        {
            // Primary Key
            this.HasKey(t => t.Order010ID);

            // Properties
            this.Property(t => t.Customer010ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order010");
            this.Property(t => t.Order010ID).HasColumnName("Order010ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer010ID).HasColumnName("Customer010ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer010)
                .WithMany(t => t.Order010)
                .HasForeignKey(d => d.Customer010ID);

        }
    }
}
