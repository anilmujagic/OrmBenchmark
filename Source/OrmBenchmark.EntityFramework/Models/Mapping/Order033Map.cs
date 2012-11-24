using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order033Map : EntityTypeConfiguration<Order033>
    {
        public Order033Map()
        {
            // Primary Key
            this.HasKey(t => t.Order033ID);

            // Properties
            this.Property(t => t.Customer033ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order033");
            this.Property(t => t.Order033ID).HasColumnName("Order033ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer033ID).HasColumnName("Customer033ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer033)
                .WithMany(t => t.Order033)
                .HasForeignKey(d => d.Customer033ID);

        }
    }
}
