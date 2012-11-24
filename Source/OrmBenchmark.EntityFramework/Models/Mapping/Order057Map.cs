using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order057Map : EntityTypeConfiguration<Order057>
    {
        public Order057Map()
        {
            // Primary Key
            this.HasKey(t => t.Order057ID);

            // Properties
            this.Property(t => t.Customer057ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order057");
            this.Property(t => t.Order057ID).HasColumnName("Order057ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer057ID).HasColumnName("Customer057ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer057)
                .WithMany(t => t.Order057)
                .HasForeignKey(d => d.Customer057ID);

        }
    }
}
