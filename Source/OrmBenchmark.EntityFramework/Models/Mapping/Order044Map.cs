using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order044Map : EntityTypeConfiguration<Order044>
    {
        public Order044Map()
        {
            // Primary Key
            this.HasKey(t => t.Order044ID);

            // Properties
            this.Property(t => t.Customer044ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order044");
            this.Property(t => t.Order044ID).HasColumnName("Order044ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer044ID).HasColumnName("Customer044ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer044)
                .WithMany(t => t.Order044)
                .HasForeignKey(d => d.Customer044ID);

        }
    }
}
