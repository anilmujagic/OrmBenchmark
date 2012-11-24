using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order043Map : EntityTypeConfiguration<Order043>
    {
        public Order043Map()
        {
            // Primary Key
            this.HasKey(t => t.Order043ID);

            // Properties
            this.Property(t => t.Customer043ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order043");
            this.Property(t => t.Order043ID).HasColumnName("Order043ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer043ID).HasColumnName("Customer043ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer043)
                .WithMany(t => t.Order043)
                .HasForeignKey(d => d.Customer043ID);

        }
    }
}
