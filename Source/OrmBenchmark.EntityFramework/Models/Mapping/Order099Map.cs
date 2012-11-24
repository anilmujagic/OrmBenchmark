using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order099Map : EntityTypeConfiguration<Order099>
    {
        public Order099Map()
        {
            // Primary Key
            this.HasKey(t => t.Order099ID);

            // Properties
            this.Property(t => t.Customer099ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order099");
            this.Property(t => t.Order099ID).HasColumnName("Order099ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer099ID).HasColumnName("Customer099ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer099)
                .WithMany(t => t.Order099)
                .HasForeignKey(d => d.Customer099ID);

        }
    }
}
