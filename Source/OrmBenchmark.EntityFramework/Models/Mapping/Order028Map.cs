using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order028Map : EntityTypeConfiguration<Order028>
    {
        public Order028Map()
        {
            // Primary Key
            this.HasKey(t => t.Order028ID);

            // Properties
            this.Property(t => t.Customer028ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order028");
            this.Property(t => t.Order028ID).HasColumnName("Order028ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer028ID).HasColumnName("Customer028ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer028)
                .WithMany(t => t.Order028)
                .HasForeignKey(d => d.Customer028ID);

        }
    }
}
