using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order078Map : EntityTypeConfiguration<Order078>
    {
        public Order078Map()
        {
            // Primary Key
            this.HasKey(t => t.Order078ID);

            // Properties
            this.Property(t => t.Customer078ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order078");
            this.Property(t => t.Order078ID).HasColumnName("Order078ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer078ID).HasColumnName("Customer078ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer078)
                .WithMany(t => t.Order078)
                .HasForeignKey(d => d.Customer078ID);

        }
    }
}
