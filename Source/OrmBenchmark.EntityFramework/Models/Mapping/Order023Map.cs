using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order023Map : EntityTypeConfiguration<Order023>
    {
        public Order023Map()
        {
            // Primary Key
            this.HasKey(t => t.Order023ID);

            // Properties
            this.Property(t => t.Customer023ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order023");
            this.Property(t => t.Order023ID).HasColumnName("Order023ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer023ID).HasColumnName("Customer023ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer023)
                .WithMany(t => t.Order023)
                .HasForeignKey(d => d.Customer023ID);

        }
    }
}
