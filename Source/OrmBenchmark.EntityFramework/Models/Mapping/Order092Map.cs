using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order092Map : EntityTypeConfiguration<Order092>
    {
        public Order092Map()
        {
            // Primary Key
            this.HasKey(t => t.Order092ID);

            // Properties
            this.Property(t => t.Customer092ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order092");
            this.Property(t => t.Order092ID).HasColumnName("Order092ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer092ID).HasColumnName("Customer092ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer092)
                .WithMany(t => t.Order092)
                .HasForeignKey(d => d.Customer092ID);

        }
    }
}
