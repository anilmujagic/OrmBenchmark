using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order015Map : EntityTypeConfiguration<Order015>
    {
        public Order015Map()
        {
            // Primary Key
            this.HasKey(t => t.Order015ID);

            // Properties
            this.Property(t => t.Customer015ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order015");
            this.Property(t => t.Order015ID).HasColumnName("Order015ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer015ID).HasColumnName("Customer015ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer015)
                .WithMany(t => t.Order015)
                .HasForeignKey(d => d.Customer015ID);

        }
    }
}
