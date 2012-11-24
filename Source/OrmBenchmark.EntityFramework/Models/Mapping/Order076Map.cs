using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order076Map : EntityTypeConfiguration<Order076>
    {
        public Order076Map()
        {
            // Primary Key
            this.HasKey(t => t.Order076ID);

            // Properties
            this.Property(t => t.Customer076ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order076");
            this.Property(t => t.Order076ID).HasColumnName("Order076ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer076ID).HasColumnName("Customer076ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer076)
                .WithMany(t => t.Order076)
                .HasForeignKey(d => d.Customer076ID);

        }
    }
}
