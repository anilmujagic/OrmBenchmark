using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order062Map : EntityTypeConfiguration<Order062>
    {
        public Order062Map()
        {
            // Primary Key
            this.HasKey(t => t.Order062ID);

            // Properties
            this.Property(t => t.Customer062ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order062");
            this.Property(t => t.Order062ID).HasColumnName("Order062ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer062ID).HasColumnName("Customer062ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer062)
                .WithMany(t => t.Order062)
                .HasForeignKey(d => d.Customer062ID);

        }
    }
}
