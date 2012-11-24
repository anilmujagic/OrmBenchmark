using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order018Map : EntityTypeConfiguration<Order018>
    {
        public Order018Map()
        {
            // Primary Key
            this.HasKey(t => t.Order018ID);

            // Properties
            this.Property(t => t.Customer018ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order018");
            this.Property(t => t.Order018ID).HasColumnName("Order018ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer018ID).HasColumnName("Customer018ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer018)
                .WithMany(t => t.Order018)
                .HasForeignKey(d => d.Customer018ID);

        }
    }
}
