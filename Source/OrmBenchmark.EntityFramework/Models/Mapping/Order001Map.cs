using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order001Map : EntityTypeConfiguration<Order001>
    {
        public Order001Map()
        {
            // Primary Key
            this.HasKey(t => t.Order001ID);

            // Properties
            this.Property(t => t.Customer001ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order001");
            this.Property(t => t.Order001ID).HasColumnName("Order001ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer001ID).HasColumnName("Customer001ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer001)
                .WithMany(t => t.Order001)
                .HasForeignKey(d => d.Customer001ID);

        }
    }
}
