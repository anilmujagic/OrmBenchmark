using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order007Map : EntityTypeConfiguration<Order007>
    {
        public Order007Map()
        {
            // Primary Key
            this.HasKey(t => t.Order007ID);

            // Properties
            this.Property(t => t.Customer007ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order007");
            this.Property(t => t.Order007ID).HasColumnName("Order007ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer007ID).HasColumnName("Customer007ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer007)
                .WithMany(t => t.Order007)
                .HasForeignKey(d => d.Customer007ID);

        }
    }
}
