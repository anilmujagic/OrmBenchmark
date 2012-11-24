using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer009Map : EntityTypeConfiguration<Customer009>
    {
        public Customer009Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer009ID);

            // Properties
            this.Property(t => t.Customer009ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer009");
            this.Property(t => t.Customer009ID).HasColumnName("Customer009ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
