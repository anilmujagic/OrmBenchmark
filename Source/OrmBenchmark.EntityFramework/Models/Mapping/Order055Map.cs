using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order055Map : EntityTypeConfiguration<Order055>
    {
        public Order055Map()
        {
            // Primary Key
            this.HasKey(t => t.Order055ID);

            // Properties
            this.Property(t => t.Customer055ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order055");
            this.Property(t => t.Order055ID).HasColumnName("Order055ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer055ID).HasColumnName("Customer055ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer055)
                .WithMany(t => t.Order055)
                .HasForeignKey(d => d.Customer055ID);

        }
    }
}
