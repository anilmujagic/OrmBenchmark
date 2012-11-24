using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer004Map : EntityTypeConfiguration<Customer004>
    {
        public Customer004Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer004ID);

            // Properties
            this.Property(t => t.Customer004ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer004");
            this.Property(t => t.Customer004ID).HasColumnName("Customer004ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
