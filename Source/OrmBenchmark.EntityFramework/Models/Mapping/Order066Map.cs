using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order066Map : EntityTypeConfiguration<Order066>
    {
        public Order066Map()
        {
            // Primary Key
            this.HasKey(t => t.Order066ID);

            // Properties
            this.Property(t => t.Customer066ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order066");
            this.Property(t => t.Order066ID).HasColumnName("Order066ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer066ID).HasColumnName("Customer066ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer066)
                .WithMany(t => t.Order066)
                .HasForeignKey(d => d.Customer066ID);

        }
    }
}
