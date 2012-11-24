using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order100Map : EntityTypeConfiguration<Order100>
    {
        public Order100Map()
        {
            // Primary Key
            this.HasKey(t => t.Order100ID);

            // Properties
            this.Property(t => t.Customer100ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order100");
            this.Property(t => t.Order100ID).HasColumnName("Order100ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer100ID).HasColumnName("Customer100ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer100)
                .WithMany(t => t.Order100)
                .HasForeignKey(d => d.Customer100ID);

        }
    }
}
