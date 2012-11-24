using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order070Map : EntityTypeConfiguration<Order070>
    {
        public Order070Map()
        {
            // Primary Key
            this.HasKey(t => t.Order070ID);

            // Properties
            this.Property(t => t.Customer070ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order070");
            this.Property(t => t.Order070ID).HasColumnName("Order070ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer070ID).HasColumnName("Customer070ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer070)
                .WithMany(t => t.Order070)
                .HasForeignKey(d => d.Customer070ID);

        }
    }
}
