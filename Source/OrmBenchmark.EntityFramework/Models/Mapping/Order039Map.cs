using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order039Map : EntityTypeConfiguration<Order039>
    {
        public Order039Map()
        {
            // Primary Key
            this.HasKey(t => t.Order039ID);

            // Properties
            this.Property(t => t.Customer039ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order039");
            this.Property(t => t.Order039ID).HasColumnName("Order039ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer039ID).HasColumnName("Customer039ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer039)
                .WithMany(t => t.Order039)
                .HasForeignKey(d => d.Customer039ID);

        }
    }
}
