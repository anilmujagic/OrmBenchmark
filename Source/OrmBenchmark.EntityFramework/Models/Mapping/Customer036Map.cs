using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer036Map : EntityTypeConfiguration<Customer036>
    {
        public Customer036Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer036ID);

            // Properties
            this.Property(t => t.Customer036ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer036");
            this.Property(t => t.Customer036ID).HasColumnName("Customer036ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
