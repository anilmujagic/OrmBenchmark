using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order080Map : EntityTypeConfiguration<Order080>
    {
        public Order080Map()
        {
            // Primary Key
            this.HasKey(t => t.Order080ID);

            // Properties
            this.Property(t => t.Customer080ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order080");
            this.Property(t => t.Order080ID).HasColumnName("Order080ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer080ID).HasColumnName("Customer080ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer080)
                .WithMany(t => t.Order080)
                .HasForeignKey(d => d.Customer080ID);

        }
    }
}
