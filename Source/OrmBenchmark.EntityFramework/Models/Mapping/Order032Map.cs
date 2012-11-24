using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order032Map : EntityTypeConfiguration<Order032>
    {
        public Order032Map()
        {
            // Primary Key
            this.HasKey(t => t.Order032ID);

            // Properties
            this.Property(t => t.Customer032ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order032");
            this.Property(t => t.Order032ID).HasColumnName("Order032ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer032ID).HasColumnName("Customer032ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer032)
                .WithMany(t => t.Order032)
                .HasForeignKey(d => d.Customer032ID);

        }
    }
}
