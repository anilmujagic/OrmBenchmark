using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order019Map : EntityTypeConfiguration<Order019>
    {
        public Order019Map()
        {
            // Primary Key
            this.HasKey(t => t.Order019ID);

            // Properties
            this.Property(t => t.Customer019ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order019");
            this.Property(t => t.Order019ID).HasColumnName("Order019ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer019ID).HasColumnName("Customer019ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer019)
                .WithMany(t => t.Order019)
                .HasForeignKey(d => d.Customer019ID);

        }
    }
}
