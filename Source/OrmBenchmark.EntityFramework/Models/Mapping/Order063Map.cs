using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order063Map : EntityTypeConfiguration<Order063>
    {
        public Order063Map()
        {
            // Primary Key
            this.HasKey(t => t.Order063ID);

            // Properties
            this.Property(t => t.Customer063ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order063");
            this.Property(t => t.Order063ID).HasColumnName("Order063ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer063ID).HasColumnName("Customer063ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer063)
                .WithMany(t => t.Order063)
                .HasForeignKey(d => d.Customer063ID);

        }
    }
}
