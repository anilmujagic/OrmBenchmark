using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer024Map : EntityTypeConfiguration<Customer024>
    {
        public Customer024Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer024ID);

            // Properties
            this.Property(t => t.Customer024ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer024");
            this.Property(t => t.Customer024ID).HasColumnName("Customer024ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
