using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer041Map : EntityTypeConfiguration<Customer041>
    {
        public Customer041Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer041ID);

            // Properties
            this.Property(t => t.Customer041ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer041");
            this.Property(t => t.Customer041ID).HasColumnName("Customer041ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
