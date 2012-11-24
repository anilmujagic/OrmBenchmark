using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order094Map : EntityTypeConfiguration<Order094>
    {
        public Order094Map()
        {
            // Primary Key
            this.HasKey(t => t.Order094ID);

            // Properties
            this.Property(t => t.Customer094ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order094");
            this.Property(t => t.Order094ID).HasColumnName("Order094ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer094ID).HasColumnName("Customer094ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer094)
                .WithMany(t => t.Order094)
                .HasForeignKey(d => d.Customer094ID);

        }
    }
}
