using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order031Map : EntityTypeConfiguration<Order031>
    {
        public Order031Map()
        {
            // Primary Key
            this.HasKey(t => t.Order031ID);

            // Properties
            this.Property(t => t.Customer031ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order031");
            this.Property(t => t.Order031ID).HasColumnName("Order031ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer031ID).HasColumnName("Customer031ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer031)
                .WithMany(t => t.Order031)
                .HasForeignKey(d => d.Customer031ID);

        }
    }
}
