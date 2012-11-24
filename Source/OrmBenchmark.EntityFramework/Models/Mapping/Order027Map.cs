using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order027Map : EntityTypeConfiguration<Order027>
    {
        public Order027Map()
        {
            // Primary Key
            this.HasKey(t => t.Order027ID);

            // Properties
            this.Property(t => t.Customer027ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order027");
            this.Property(t => t.Order027ID).HasColumnName("Order027ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer027ID).HasColumnName("Customer027ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer027)
                .WithMany(t => t.Order027)
                .HasForeignKey(d => d.Customer027ID);

        }
    }
}
