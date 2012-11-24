using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order002Map : EntityTypeConfiguration<Order002>
    {
        public Order002Map()
        {
            // Primary Key
            this.HasKey(t => t.Order002ID);

            // Properties
            this.Property(t => t.Customer002ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order002");
            this.Property(t => t.Order002ID).HasColumnName("Order002ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer002ID).HasColumnName("Customer002ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer002)
                .WithMany(t => t.Order002)
                .HasForeignKey(d => d.Customer002ID);

        }
    }
}
