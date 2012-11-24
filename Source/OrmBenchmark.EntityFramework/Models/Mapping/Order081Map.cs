using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order081Map : EntityTypeConfiguration<Order081>
    {
        public Order081Map()
        {
            // Primary Key
            this.HasKey(t => t.Order081ID);

            // Properties
            this.Property(t => t.Customer081ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order081");
            this.Property(t => t.Order081ID).HasColumnName("Order081ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer081ID).HasColumnName("Customer081ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer081)
                .WithMany(t => t.Order081)
                .HasForeignKey(d => d.Customer081ID);

        }
    }
}
