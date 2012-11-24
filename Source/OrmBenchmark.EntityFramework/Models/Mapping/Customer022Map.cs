using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer022Map : EntityTypeConfiguration<Customer022>
    {
        public Customer022Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer022ID);

            // Properties
            this.Property(t => t.Customer022ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer022");
            this.Property(t => t.Customer022ID).HasColumnName("Customer022ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
