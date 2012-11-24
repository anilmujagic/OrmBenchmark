using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order025Map : EntityTypeConfiguration<Order025>
    {
        public Order025Map()
        {
            // Primary Key
            this.HasKey(t => t.Order025ID);

            // Properties
            this.Property(t => t.Customer025ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order025");
            this.Property(t => t.Order025ID).HasColumnName("Order025ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer025ID).HasColumnName("Customer025ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer025)
                .WithMany(t => t.Order025)
                .HasForeignKey(d => d.Customer025ID);

        }
    }
}
