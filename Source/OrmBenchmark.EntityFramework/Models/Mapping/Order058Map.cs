using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order058Map : EntityTypeConfiguration<Order058>
    {
        public Order058Map()
        {
            // Primary Key
            this.HasKey(t => t.Order058ID);

            // Properties
            this.Property(t => t.Customer058ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order058");
            this.Property(t => t.Order058ID).HasColumnName("Order058ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer058ID).HasColumnName("Customer058ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer058)
                .WithMany(t => t.Order058)
                .HasForeignKey(d => d.Customer058ID);

        }
    }
}
