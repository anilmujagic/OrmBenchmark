using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer056Map : EntityTypeConfiguration<Customer056>
    {
        public Customer056Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer056ID);

            // Properties
            this.Property(t => t.Customer056ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer056");
            this.Property(t => t.Customer056ID).HasColumnName("Customer056ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
