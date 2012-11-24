using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order029Map : EntityTypeConfiguration<Order029>
    {
        public Order029Map()
        {
            // Primary Key
            this.HasKey(t => t.Order029ID);

            // Properties
            this.Property(t => t.Customer029ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order029");
            this.Property(t => t.Order029ID).HasColumnName("Order029ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer029ID).HasColumnName("Customer029ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer029)
                .WithMany(t => t.Order029)
                .HasForeignKey(d => d.Customer029ID);

        }
    }
}
