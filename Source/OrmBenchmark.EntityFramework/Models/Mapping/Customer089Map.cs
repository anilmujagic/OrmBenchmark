using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer089Map : EntityTypeConfiguration<Customer089>
    {
        public Customer089Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer089ID);

            // Properties
            this.Property(t => t.Customer089ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer089");
            this.Property(t => t.Customer089ID).HasColumnName("Customer089ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
