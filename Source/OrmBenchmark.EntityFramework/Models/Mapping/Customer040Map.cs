using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer040Map : EntityTypeConfiguration<Customer040>
    {
        public Customer040Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer040ID);

            // Properties
            this.Property(t => t.Customer040ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer040");
            this.Property(t => t.Customer040ID).HasColumnName("Customer040ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
