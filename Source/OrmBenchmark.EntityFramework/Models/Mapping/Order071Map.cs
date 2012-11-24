using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order071Map : EntityTypeConfiguration<Order071>
    {
        public Order071Map()
        {
            // Primary Key
            this.HasKey(t => t.Order071ID);

            // Properties
            this.Property(t => t.Customer071ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order071");
            this.Property(t => t.Order071ID).HasColumnName("Order071ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer071ID).HasColumnName("Customer071ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer071)
                .WithMany(t => t.Order071)
                .HasForeignKey(d => d.Customer071ID);

        }
    }
}
