using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order085Map : EntityTypeConfiguration<Order085>
    {
        public Order085Map()
        {
            // Primary Key
            this.HasKey(t => t.Order085ID);

            // Properties
            this.Property(t => t.Customer085ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order085");
            this.Property(t => t.Order085ID).HasColumnName("Order085ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer085ID).HasColumnName("Customer085ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer085)
                .WithMany(t => t.Order085)
                .HasForeignKey(d => d.Customer085ID);

        }
    }
}
