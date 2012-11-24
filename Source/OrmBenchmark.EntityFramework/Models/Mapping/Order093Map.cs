using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order093Map : EntityTypeConfiguration<Order093>
    {
        public Order093Map()
        {
            // Primary Key
            this.HasKey(t => t.Order093ID);

            // Properties
            this.Property(t => t.Customer093ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order093");
            this.Property(t => t.Order093ID).HasColumnName("Order093ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer093ID).HasColumnName("Customer093ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer093)
                .WithMany(t => t.Order093)
                .HasForeignKey(d => d.Customer093ID);

        }
    }
}
