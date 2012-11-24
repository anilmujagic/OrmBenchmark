using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order049Map : EntityTypeConfiguration<Order049>
    {
        public Order049Map()
        {
            // Primary Key
            this.HasKey(t => t.Order049ID);

            // Properties
            this.Property(t => t.Customer049ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order049");
            this.Property(t => t.Order049ID).HasColumnName("Order049ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer049ID).HasColumnName("Customer049ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer049)
                .WithMany(t => t.Order049)
                .HasForeignKey(d => d.Customer049ID);

        }
    }
}
