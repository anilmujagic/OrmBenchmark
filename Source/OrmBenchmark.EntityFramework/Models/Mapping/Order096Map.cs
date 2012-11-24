using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order096Map : EntityTypeConfiguration<Order096>
    {
        public Order096Map()
        {
            // Primary Key
            this.HasKey(t => t.Order096ID);

            // Properties
            this.Property(t => t.Customer096ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order096");
            this.Property(t => t.Order096ID).HasColumnName("Order096ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer096ID).HasColumnName("Customer096ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer096)
                .WithMany(t => t.Order096)
                .HasForeignKey(d => d.Customer096ID);

        }
    }
}
