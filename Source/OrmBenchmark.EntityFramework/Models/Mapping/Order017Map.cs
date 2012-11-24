using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order017Map : EntityTypeConfiguration<Order017>
    {
        public Order017Map()
        {
            // Primary Key
            this.HasKey(t => t.Order017ID);

            // Properties
            this.Property(t => t.Customer017ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order017");
            this.Property(t => t.Order017ID).HasColumnName("Order017ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer017ID).HasColumnName("Customer017ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer017)
                .WithMany(t => t.Order017)
                .HasForeignKey(d => d.Customer017ID);

        }
    }
}
