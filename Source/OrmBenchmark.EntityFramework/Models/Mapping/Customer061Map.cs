using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer061Map : EntityTypeConfiguration<Customer061>
    {
        public Customer061Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer061ID);

            // Properties
            this.Property(t => t.Customer061ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer061");
            this.Property(t => t.Customer061ID).HasColumnName("Customer061ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
