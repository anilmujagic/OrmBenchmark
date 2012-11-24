using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order088Map : EntityTypeConfiguration<Order088>
    {
        public Order088Map()
        {
            // Primary Key
            this.HasKey(t => t.Order088ID);

            // Properties
            this.Property(t => t.Customer088ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order088");
            this.Property(t => t.Order088ID).HasColumnName("Order088ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer088ID).HasColumnName("Customer088ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer088)
                .WithMany(t => t.Order088)
                .HasForeignKey(d => d.Customer088ID);

        }
    }
}
