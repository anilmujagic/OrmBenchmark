using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order053Map : EntityTypeConfiguration<Order053>
    {
        public Order053Map()
        {
            // Primary Key
            this.HasKey(t => t.Order053ID);

            // Properties
            this.Property(t => t.Customer053ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order053");
            this.Property(t => t.Order053ID).HasColumnName("Order053ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer053ID).HasColumnName("Customer053ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer053)
                .WithMany(t => t.Order053)
                .HasForeignKey(d => d.Customer053ID);

        }
    }
}
