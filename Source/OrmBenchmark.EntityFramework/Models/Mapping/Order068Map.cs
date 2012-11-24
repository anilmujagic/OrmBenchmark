using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order068Map : EntityTypeConfiguration<Order068>
    {
        public Order068Map()
        {
            // Primary Key
            this.HasKey(t => t.Order068ID);

            // Properties
            this.Property(t => t.Customer068ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order068");
            this.Property(t => t.Order068ID).HasColumnName("Order068ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer068ID).HasColumnName("Customer068ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer068)
                .WithMany(t => t.Order068)
                .HasForeignKey(d => d.Customer068ID);

        }
    }
}
