using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order009Map : EntityTypeConfiguration<Order009>
    {
        public Order009Map()
        {
            // Primary Key
            this.HasKey(t => t.Order009ID);

            // Properties
            this.Property(t => t.Customer009ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order009");
            this.Property(t => t.Order009ID).HasColumnName("Order009ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer009ID).HasColumnName("Customer009ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer009)
                .WithMany(t => t.Order009)
                .HasForeignKey(d => d.Customer009ID);

        }
    }
}
