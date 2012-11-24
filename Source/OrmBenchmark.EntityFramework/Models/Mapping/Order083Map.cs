using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order083Map : EntityTypeConfiguration<Order083>
    {
        public Order083Map()
        {
            // Primary Key
            this.HasKey(t => t.Order083ID);

            // Properties
            this.Property(t => t.Customer083ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order083");
            this.Property(t => t.Order083ID).HasColumnName("Order083ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer083ID).HasColumnName("Customer083ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer083)
                .WithMany(t => t.Order083)
                .HasForeignKey(d => d.Customer083ID);

        }
    }
}
