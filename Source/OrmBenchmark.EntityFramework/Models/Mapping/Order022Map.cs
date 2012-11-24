using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order022Map : EntityTypeConfiguration<Order022>
    {
        public Order022Map()
        {
            // Primary Key
            this.HasKey(t => t.Order022ID);

            // Properties
            this.Property(t => t.Customer022ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order022");
            this.Property(t => t.Order022ID).HasColumnName("Order022ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer022ID).HasColumnName("Customer022ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer022)
                .WithMany(t => t.Order022)
                .HasForeignKey(d => d.Customer022ID);

        }
    }
}
