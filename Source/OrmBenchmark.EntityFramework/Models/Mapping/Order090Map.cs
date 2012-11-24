using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order090Map : EntityTypeConfiguration<Order090>
    {
        public Order090Map()
        {
            // Primary Key
            this.HasKey(t => t.Order090ID);

            // Properties
            this.Property(t => t.Customer090ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order090");
            this.Property(t => t.Order090ID).HasColumnName("Order090ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer090ID).HasColumnName("Customer090ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer090)
                .WithMany(t => t.Order090)
                .HasForeignKey(d => d.Customer090ID);

        }
    }
}
