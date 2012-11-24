using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer091Map : EntityTypeConfiguration<Customer091>
    {
        public Customer091Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer091ID);

            // Properties
            this.Property(t => t.Customer091ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer091");
            this.Property(t => t.Customer091ID).HasColumnName("Customer091ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
