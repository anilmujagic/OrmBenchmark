using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order082Map : EntityTypeConfiguration<Order082>
    {
        public Order082Map()
        {
            // Primary Key
            this.HasKey(t => t.Order082ID);

            // Properties
            this.Property(t => t.Customer082ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order082");
            this.Property(t => t.Order082ID).HasColumnName("Order082ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer082ID).HasColumnName("Customer082ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer082)
                .WithMany(t => t.Order082)
                .HasForeignKey(d => d.Customer082ID);

        }
    }
}
