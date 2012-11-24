using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order087Map : EntityTypeConfiguration<Order087>
    {
        public Order087Map()
        {
            // Primary Key
            this.HasKey(t => t.Order087ID);

            // Properties
            this.Property(t => t.Customer087ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order087");
            this.Property(t => t.Order087ID).HasColumnName("Order087ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer087ID).HasColumnName("Customer087ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer087)
                .WithMany(t => t.Order087)
                .HasForeignKey(d => d.Customer087ID);

        }
    }
}
