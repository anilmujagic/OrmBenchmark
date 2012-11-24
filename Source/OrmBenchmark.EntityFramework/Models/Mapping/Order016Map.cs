using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order016Map : EntityTypeConfiguration<Order016>
    {
        public Order016Map()
        {
            // Primary Key
            this.HasKey(t => t.Order016ID);

            // Properties
            this.Property(t => t.Customer016ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order016");
            this.Property(t => t.Order016ID).HasColumnName("Order016ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer016ID).HasColumnName("Customer016ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer016)
                .WithMany(t => t.Order016)
                .HasForeignKey(d => d.Customer016ID);

        }
    }
}
