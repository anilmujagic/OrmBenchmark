using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order011Map : EntityTypeConfiguration<Order011>
    {
        public Order011Map()
        {
            // Primary Key
            this.HasKey(t => t.Order011ID);

            // Properties
            this.Property(t => t.Customer011ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order011");
            this.Property(t => t.Order011ID).HasColumnName("Order011ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer011ID).HasColumnName("Customer011ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer011)
                .WithMany(t => t.Order011)
                .HasForeignKey(d => d.Customer011ID);

        }
    }
}
