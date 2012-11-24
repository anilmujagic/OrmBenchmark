using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer046Map : EntityTypeConfiguration<Customer046>
    {
        public Customer046Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer046ID);

            // Properties
            this.Property(t => t.Customer046ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer046");
            this.Property(t => t.Customer046ID).HasColumnName("Customer046ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
