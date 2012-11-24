using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order064Map : EntityTypeConfiguration<Order064>
    {
        public Order064Map()
        {
            // Primary Key
            this.HasKey(t => t.Order064ID);

            // Properties
            this.Property(t => t.Customer064ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order064");
            this.Property(t => t.Order064ID).HasColumnName("Order064ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer064ID).HasColumnName("Customer064ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer064)
                .WithMany(t => t.Order064)
                .HasForeignKey(d => d.Customer064ID);

        }
    }
}
