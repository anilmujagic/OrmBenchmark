using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer090Map : EntityTypeConfiguration<Customer090>
    {
        public Customer090Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer090ID);

            // Properties
            this.Property(t => t.Customer090ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer090");
            this.Property(t => t.Customer090ID).HasColumnName("Customer090ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
