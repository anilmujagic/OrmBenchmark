using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order073Map : EntityTypeConfiguration<Order073>
    {
        public Order073Map()
        {
            // Primary Key
            this.HasKey(t => t.Order073ID);

            // Properties
            this.Property(t => t.Customer073ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order073");
            this.Property(t => t.Order073ID).HasColumnName("Order073ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer073ID).HasColumnName("Customer073ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer073)
                .WithMany(t => t.Order073)
                .HasForeignKey(d => d.Customer073ID);

        }
    }
}
