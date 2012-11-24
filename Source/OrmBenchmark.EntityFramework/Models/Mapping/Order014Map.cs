using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order014Map : EntityTypeConfiguration<Order014>
    {
        public Order014Map()
        {
            // Primary Key
            this.HasKey(t => t.Order014ID);

            // Properties
            this.Property(t => t.Customer014ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order014");
            this.Property(t => t.Order014ID).HasColumnName("Order014ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer014ID).HasColumnName("Customer014ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer014)
                .WithMany(t => t.Order014)
                .HasForeignKey(d => d.Customer014ID);

        }
    }
}
