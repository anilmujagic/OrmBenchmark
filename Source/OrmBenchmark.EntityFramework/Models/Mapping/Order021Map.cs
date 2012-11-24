using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order021Map : EntityTypeConfiguration<Order021>
    {
        public Order021Map()
        {
            // Primary Key
            this.HasKey(t => t.Order021ID);

            // Properties
            this.Property(t => t.Customer021ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order021");
            this.Property(t => t.Order021ID).HasColumnName("Order021ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer021ID).HasColumnName("Customer021ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer021)
                .WithMany(t => t.Order021)
                .HasForeignKey(d => d.Customer021ID);

        }
    }
}
