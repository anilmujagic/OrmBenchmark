using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Order056Map : EntityTypeConfiguration<Order056>
    {
        public Order056Map()
        {
            // Primary Key
            this.HasKey(t => t.Order056ID);

            // Properties
            this.Property(t => t.Customer056ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order056");
            this.Property(t => t.Order056ID).HasColumnName("Order056ID");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.Customer056ID).HasColumnName("Customer056ID");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.Customer056)
                .WithMany(t => t.Order056)
                .HasForeignKey(d => d.Customer056ID);

        }
    }
}
