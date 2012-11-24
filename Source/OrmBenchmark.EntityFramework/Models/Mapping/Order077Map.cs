using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order077Map : EntityTypeConfiguration<Order077>
    {
        public Order077Map()
        {
            // Primary Key
            this.HasKey(t => t.Order077ID);

            // Properties
            this.Property(t => t.Customer077ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order077");
            this.Property(t => t.Order077ID).HasColumnName("Order077ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer077ID).HasColumnName("Customer077ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer077)
                .WithMany(t => t.Order077)
                .HasForeignKey(d => d.Customer077ID);

        }
    }
}
