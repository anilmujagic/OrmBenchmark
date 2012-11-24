using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order050Map : EntityTypeConfiguration<Order050>
    {
        public Order050Map()
        {
            // Primary Key
            this.HasKey(t => t.Order050ID);

            // Properties
            this.Property(t => t.Customer050ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order050");
            this.Property(t => t.Order050ID).HasColumnName("Order050ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer050ID).HasColumnName("Customer050ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer050)
                .WithMany(t => t.Order050)
                .HasForeignKey(d => d.Customer050ID);

        }
    }
}
