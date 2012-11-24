using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order059Map : EntityTypeConfiguration<Order059>
    {
        public Order059Map()
        {
            // Primary Key
            this.HasKey(t => t.Order059ID);

            // Properties
            this.Property(t => t.Customer059ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order059");
            this.Property(t => t.Order059ID).HasColumnName("Order059ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer059ID).HasColumnName("Customer059ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer059)
                .WithMany(t => t.Order059)
                .HasForeignKey(d => d.Customer059ID);

        }
    }
}
