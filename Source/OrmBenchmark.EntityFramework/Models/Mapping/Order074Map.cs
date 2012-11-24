using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order074Map : EntityTypeConfiguration<Order074>
    {
        public Order074Map()
        {
            // Primary Key
            this.HasKey(t => t.Order074ID);

            // Properties
            this.Property(t => t.Customer074ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order074");
            this.Property(t => t.Order074ID).HasColumnName("Order074ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer074ID).HasColumnName("Customer074ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer074)
                .WithMany(t => t.Order074)
                .HasForeignKey(d => d.Customer074ID);

        }
    }
}
