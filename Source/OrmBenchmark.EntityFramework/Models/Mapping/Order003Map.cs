using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order003Map : EntityTypeConfiguration<Order003>
    {
        public Order003Map()
        {
            // Primary Key
            this.HasKey(t => t.Order003ID);

            // Properties
            this.Property(t => t.Customer003ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order003");
            this.Property(t => t.Order003ID).HasColumnName("Order003ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer003ID).HasColumnName("Customer003ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer003)
                .WithMany(t => t.Order003)
                .HasForeignKey(d => d.Customer003ID);

        }
    }
}
